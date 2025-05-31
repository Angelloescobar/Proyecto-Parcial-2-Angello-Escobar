namespace proyecto_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBoxTerreno = new TextBox();
            textBoxCultivo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            BotonContinuar = new Button();
            textBoxLugar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            labelRespuesta = new Label();
            listBoxConversacion = new ListBox();
            label5 = new Label();
            textBoxPregunta = new TextBox();
            buttonConsulta = new Button();
            comboBoxOpciones = new ComboBox();
            label4 = new Label();
            tabPage3 = new TabPage();
            buttonReinicio = new Button();
            listBoxPerfil = new ListBox();
            label7 = new Label();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.PaleTurquoise;
            tabPage1.Controls.Add(textBoxTerreno);
            tabPage1.Controls.Add(textBoxCultivo);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(BotonContinuar);
            tabPage1.Controls.Add(textBoxLugar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingreso de Datos";
            tabPage1.Click += tabPage1_Click;
            // 
            // textBoxTerreno
            // 
            textBoxTerreno.Font = new Font("Segoe UI Historic", 9F, FontStyle.Italic);
            textBoxTerreno.Location = new Point(371, 222);
            textBoxTerreno.Name = "textBoxTerreno";
            textBoxTerreno.Size = new Size(284, 27);
            textBoxTerreno.TabIndex = 9;
            // 
            // textBoxCultivo
            // 
            textBoxCultivo.Font = new Font("Segoe UI Historic", 9F, FontStyle.Italic);
            textBoxCultivo.Location = new Point(371, 162);
            textBoxCultivo.Name = "textBoxCultivo";
            textBoxCultivo.Size = new Size(284, 27);
            textBoxCultivo.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Historic", 9F, FontStyle.Italic);
            label9.Location = new Point(151, 229);
            label9.Name = "label9";
            label9.Size = new Size(157, 20);
            label9.TabIndex = 7;
            label9.Text = "Condición de Terrreno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Historic", 9F, FontStyle.Italic);
            label8.Location = new Point(200, 169);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 6;
            label8.Text = "Cultivo";
            // 
            // BotonContinuar
            // 
            BotonContinuar.Font = new Font("Segoe UI Historic", 9F, FontStyle.Italic);
            BotonContinuar.Location = new Point(312, 304);
            BotonContinuar.Name = "BotonContinuar";
            BotonContinuar.Size = new Size(161, 29);
            BotonContinuar.TabIndex = 4;
            BotonContinuar.Text = "Continuar";
            BotonContinuar.UseVisualStyleBackColor = true;
            BotonContinuar.Click += button1_Click;
            // 
            // textBoxLugar
            // 
            textBoxLugar.Font = new Font("Segoe UI Historic", 9F, FontStyle.Italic);
            textBoxLugar.Location = new Point(371, 113);
            textBoxLugar.Name = "textBoxLugar";
            textBoxLugar.Size = new Size(284, 27);
            textBoxLugar.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Italic);
            label3.Location = new Point(200, 120);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Municipio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Italic);
            label2.Location = new Point(312, 68);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese sus datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Italic);
            label1.Location = new Point(277, 19);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a este programa";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PaleTurquoise;
            tabPage2.Controls.Add(labelRespuesta);
            tabPage2.Controls.Add(listBoxConversacion);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBoxPregunta);
            tabPage2.Controls.Add(buttonConsulta);
            tabPage2.Controls.Add(comboBoxOpciones);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chat";
            // 
            // labelRespuesta
            // 
            labelRespuesta.AutoSize = true;
            labelRespuesta.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic);
            labelRespuesta.Location = new Point(323, 198);
            labelRespuesta.Name = "labelRespuesta";
            labelRespuesta.Size = new Size(150, 20);
            labelRespuesta.TabIndex = 6;
            labelRespuesta.Text = "Esperando Respuesta";
            labelRespuesta.Visible = false;
            labelRespuesta.Click += labelRespuesta_Click;
            // 
            // listBoxConversacion
            // 
            listBoxConversacion.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic);
            listBoxConversacion.FormattingEnabled = true;
            listBoxConversacion.Location = new Point(8, 230);
            listBoxConversacion.Name = "listBoxConversacion";
            listBoxConversacion.Size = new Size(763, 184);
            listBoxConversacion.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic);
            label5.Location = new Point(323, 136);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 4;
            label5.Text = "Escriba su pregunta";
            label5.Visible = false;
            // 
            // textBoxPregunta
            // 
            textBoxPregunta.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic);
            textBoxPregunta.Location = new Point(53, 159);
            textBoxPregunta.Name = "textBoxPregunta";
            textBoxPregunta.Size = new Size(435, 27);
            textBoxPregunta.TabIndex = 3;
            textBoxPregunta.Visible = false;
            textBoxPregunta.TextChanged += textBoxPregunta_TextChanged;
            // 
            // buttonConsulta
            // 
            buttonConsulta.Enabled = false;
            buttonConsulta.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic);
            buttonConsulta.Location = new Point(538, 117);
            buttonConsulta.Name = "buttonConsulta";
            buttonConsulta.Size = new Size(132, 39);
            buttonConsulta.TabIndex = 2;
            buttonConsulta.Text = "Consultar";
            buttonConsulta.UseVisualStyleBackColor = true;
            buttonConsulta.Click += buttonEnviar_Click;
            // 
            // comboBoxOpciones
            // 
            comboBoxOpciones.Enabled = false;
            comboBoxOpciones.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic);
            comboBoxOpciones.FormattingEnabled = true;
            comboBoxOpciones.Items.AddRange(new object[] { "En que temporada deberia sembrar?", "Cuales son las previsiones del clima para la siembra?", "Otra pregunta?" });
            comboBoxOpciones.Location = new Point(51, 89);
            comboBoxOpciones.Name = "comboBoxOpciones";
            comboBoxOpciones.Size = new Size(437, 28);
            comboBoxOpciones.TabIndex = 1;
            comboBoxOpciones.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic);
            label4.Location = new Point(330, 25);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 0;
            label4.Text = "Escoja una Opcion";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.PaleTurquoise;
            tabPage3.Controls.Add(buttonReinicio);
            tabPage3.Controls.Add(listBoxPerfil);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Perfil";
            // 
            // buttonReinicio
            // 
            buttonReinicio.Enabled = false;
            buttonReinicio.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic);
            buttonReinicio.Location = new Point(616, 185);
            buttonReinicio.Name = "buttonReinicio";
            buttonReinicio.Size = new Size(152, 57);
            buttonReinicio.TabIndex = 3;
            buttonReinicio.Text = "Reiniciar Datos";
            buttonReinicio.UseVisualStyleBackColor = true;
            buttonReinicio.Click += botonreinicio_Click;
            // 
            // listBoxPerfil
            // 
            listBoxPerfil.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic);
            listBoxPerfil.FormattingEnabled = true;
            listBoxPerfil.Location = new Point(29, 78);
            listBoxPerfil.Name = "listBoxPerfil";
            listBoxPerfil.Size = new Size(546, 264);
            listBoxPerfil.TabIndex = 2;
            listBoxPerfil.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(134, 119);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic);
            label6.Location = new Point(333, 28);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 0;
            label6.Text = "Perfil";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "AgroAsistente";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private Button BotonContinuar;
        private TextBox textBoxLugar;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxOpciones;
        private Label label4;
        private Label label5;
        private TextBox textBoxPregunta;
        private Button buttonConsulta;
        private TabPage tabPage3;
        private ListBox listBoxConversacion;
        private Label label6;
        private ListBox listBoxPerfil;
        private Label label7;
        private Label label8;
        private Button buttonReinicio;
        private Label label9;
        private TextBox textBoxTerreno;
        private TextBox textBoxCultivo;
        private Label labelRespuesta;
    }
}
