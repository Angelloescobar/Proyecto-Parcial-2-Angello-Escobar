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
                MessageBox.Show("ERROR: No se encontró la variable OPENAI_API_KEY en .env o en el entorno.",
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

            consulta_usuario = $"Información del usuario:" +
                $"Municipio {usuario.Municipio}" +
                $"Terreno {usuario.terreno}" +
                $"Cultivo {usuario.cultivo}" +
                $"Fecha de consulta{usuario.fecha}" +
                $"Consulta {consulta_usuario}";

            string promptSystem = "Eres un asistente especializado en:\r\n  1) Meteorología agrícola\r\n  2) Análisis de suelos y condiciones agroclimáticas regionales\r\n  3) Recomendaciones prácticas para distintos tipos de cultivo.\r\n\r\nCuando recibas los datos del usuario, debes:\r\n  a) Analizar las condiciones climáticas actuales y pronosticadas para el municipio indicado.\r\n  b) Evaluar la condición del suelo/terreno en función de descripción dada (por ejemplo: arcilloso, arenoso, franco, exceso de encharcamiento, sequía, etc.).\r\n  c) Ofrecer recomendaciones específicas (siembra, fertilización, riego, plagas/enfermedades) ajustadas a:\r\n     - la fecha de la consulta (para saber la estación del año o posibles eventos climáticos),\r\n     - el tipo de cultivo que se menciona,\r\n     - y la ubicación geográfica (municipio).\r\n\r\nLa respuesta debe entregarse en cuatro secciones claramente diferenciadas (con encabezados):\r\n  1) **Resumen climático** (clima actual y pronóstico más cercano)\r\n  2) **Análisis del suelo/terreno** (principales impactos agroclimáticos de la condición descrita)\r\n  3) **Recomendaciones de manejo agronómico** (prácticas de siembra, fertilización, riego, control de plagas/enfermedades)\r\n  4) **Fuentes y referencias** (si correspondiera, indicar URLs o referencias a organismos oficiales: estaciones meteorológicas, institutos de investigación agropecuaria, etc.)\r\n\r\nSé conciso en cada sección (no más de 5–7 líneas por bloque), pero cubre los puntos esenciales para que el agricultor o técnico local pueda tomar decisiones inmediatas.\r\n";

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
                    listBoxConversacion.Items.Add("Sucedió un error al conectar con la API.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al llamar a la API:\n{ex.Message}",
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
