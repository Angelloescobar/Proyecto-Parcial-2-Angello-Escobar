using System.Windows.Forms;
using DotNetEnv;
using OpenAI.Chat;
using static System.Windows.Forms.Design.AxImporter;

namespace proyecto_2
{
    public partial class Form1 : Form
    {
        private ChatClient _chatClient;
        public Persona usuario;
        public Form1()
        {
            InitializeComponent();
            Env.Load();

            string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            if (string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("ERROR: No se encontr� la variable OPENAI_API_KEY en .env o en el entorno.",
                                "Clave no encontrada",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _chatClient = new ChatClient(
                model: "gpt-3.5-turbo",
                apiKey: apiKey
            );
        }

        private async void buttonEnviar_Click(object sender, EventArgs e)
        {
            buttonConsulta.Enabled = false;
            listBoxConversacion.Items.Clear();

            string consulta_usuario = "";

            if (comboBoxOpciones.Text == "Otra pregunta") consulta_usuario = textBoxPregunta.Text;
            else consulta_usuario = comboBoxOpciones.Text;

            if (string.IsNullOrEmpty(consulta_usuario))
            {
                MessageBox.Show("Por favor ingresa primero el texto de usuario.",
                                "Falta texto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            consulta_usuario = $"Informaci�n del usuario:" +
                $"Municipio {usuario.Municipio}" +
                $"Terreno {usuario.terreno}" +
                $"Cultivo {usuario.cultivo}" +
                $"Fecha de consulta{usuario.fecha}" +
                $"Consulta {consulta_usuario}";

            string promptSystem = "Eres un asistente especializado en:\r\n  1) Meteorolog�a agr�cola\r\n  2) An�lisis de suelos y condiciones agroclim�ticas regionales\r\n  3) Recomendaciones pr�cticas para distintos tipos de cultivo.\r\n\r\nCuando recibas los datos del usuario, debes:\r\n  a) Analizar las condiciones clim�ticas actuales y pronosticadas para el municipio indicado.\r\n  b) Evaluar la condici�n del suelo/terreno en funci�n de descripci�n dada (por ejemplo: arcilloso, arenoso, franco, exceso de encharcamiento, sequ�a, etc.).\r\n  c) Ofrecer recomendaciones espec�ficas (siembra, fertilizaci�n, riego, plagas/enfermedades) ajustadas a:\r\n     - la fecha de la consulta (para saber la estaci�n del a�o o posibles eventos clim�ticos),\r\n     - el tipo de cultivo que se menciona,\r\n     - y la ubicaci�n geogr�fica (municipio).\r\n\r\nLa respuesta debe entregarse en cuatro secciones claramente diferenciadas (con encabezados):\r\n  1) **Resumen clim�tico** (clima actual y pron�stico m�s cercano)\r\n  2) **An�lisis del suelo/terreno** (principales impactos agroclim�ticos de la condici�n descrita)\r\n  3) **Recomendaciones de manejo agron�mico** (pr�cticas de siembra, fertilizaci�n, riego, control de plagas/enfermedades)\r\n  4) **Fuentes y referencias** (si correspondiera, indicar URLs o referencias a organismos oficiales: estaciones meteorol�gicas, institutos de investigaci�n agropecuaria, etc.)\r\n\r\nS� conciso en cada secci�n (no m�s de 5�7 l�neas por bloque), pero cubre los puntos esenciales para que el agricultor o t�cnico local pueda tomar decisiones inmediatas.\r\n";

            var messages = new List<ChatMessage>
            {
                new SystemChatMessage(promptSystem),
                new UserChatMessage(consulta_usuario)
            };

            var options = new ChatCompletionOptions
            {
                Temperature = 0.7f
            };
            try
            {
                ChatCompletion completion = await _chatClient.CompleteChatAsync(messages, options);

                if (completion.Content?.Count > 0)
                {
                    string respuesta = completion.Content[0].Text.Trim();
                    listBoxConversacion.Items.Add($"Asistente: {respuesta}");
                }
                else
                {
                    listBoxConversacion.Items.Add("Sucedi� un error al conectar con la API.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurri� un error al llamar a la API:\n{ex.Message}",
                                "Error en OpenAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxConversacion.Items.Add($"ERROR: {ex.Message}");
            }
            finally
            {
                buttonConsulta.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLugar.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                buttonConsulta.Enabled = true;
                comboBoxOpciones.Enabled = true;
                buttonReinicio.Enabled = true;
                MessageBox.Show("Datos guardados");
                usuario = new Persona(textBoxLugar.Text, textBoxCultivo.Text, textBoxTerreno.Text, DateTime.Now);
                textBoxCultivo.Enabled = false;
                textBoxLugar.Enabled = false;
                textBoxTerreno.Enabled = false;
                BotonContinuar.Enabled = false;
                MessageBox.Show("Datos guardados correctamente");
                tabControl1.SelectedIndex = 1;
                insertarDatos(usuario.Municipio, usuario.cultivo, usuario.terreno, usuario.fecha.ToString());

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxOpciones.Text == "Otra pregunta?")
            {
                MessageBox.Show("TEXTBOX");
            }
            else
            {
                MessageBox.Show("COMBOBOX");
            }
        }

        public void reiniciarControles()
        {
            textBoxCultivo.Enabled = true;
            textBoxLugar.Enabled = true;
            textBoxTerreno.Enabled = true;
            textBoxCultivo.Text = "";
            textBoxLugar.Text = "";
            textBoxTerreno.Text = "";

            BotonContinuar.Enabled = true;
            tabControl1.SelectedIndex = 0;
            listBoxConversacion.Items.Clear();
            listBoxPerfil.Items.Clear();
            textBoxPregunta.Text = "";
            comboBoxOpciones.SelectedIndex = -1;

            buttonConsulta.Enabled = false;
            comboBoxOpciones.Enabled = false;
            buttonReinicio.Enabled = false;

        }

        public void insertarDatos(string lugar, String cultivo, string terreno, string fecha)
        {
            listBoxPerfil.Items.Add("Municipio de la persona");
            listBoxPerfil.Items.Add(lugar);
            listBoxPerfil.Items.Add("Condicion de Terreno");
            listBoxPerfil.Items.Add(terreno);
            listBoxPerfil.Items.Add("Tipo de Cultivo");
            listBoxPerfil.Items.Add(cultivo);
            listBoxPerfil.Items.Add("Fecha");
            listBoxPerfil.Items.Add(fecha);


        }




        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxOpciones.Text == "Otra pregunta?")
            {
                label5.Visible = true;
                textBoxPregunta.Visible = true;
            }
            else
            {
                label5.Visible = false;
                textBoxPregunta.Visible = false;
            }
            {

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonreinicio_Click(object sender, EventArgs e)
        {
            reiniciarControles();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPregunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRespuesta_Click(object sender, EventArgs e)
        {

        }
    }
}
