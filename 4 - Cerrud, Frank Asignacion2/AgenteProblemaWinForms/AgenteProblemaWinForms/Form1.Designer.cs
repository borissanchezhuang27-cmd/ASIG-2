namespace AgenteProblemaWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblProveedor = new Label();
            btnCrearAgente = new Button();
            lblProblema = new Label();
            textBoxProblema = new TextBox();
            textBoxInstruccionesDeAgente = new TextBox();
            lblInstrucciones = new Label();
            lblConversacion = new Label();
            richTextBoxConversacion = new RichTextBox();
            lblConsulta = new Label();
            textBoxConsulta = new TextBox();
            btnEnviar = new Button();
            btnNuevaSesion = new Button();
            comboBoxProveedor = new ComboBox();
            label1 = new Label();
            lblEstadoProveedor = new Label();
            SuspendLayout();
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProveedor.Location = new Point(27, 23);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(247, 28);
            lblProveedor.TabIndex = 0;
            lblProveedor.Text = "Proveedor de IA elegido:";
            lblProveedor.Click += label1_Click;
            // 
            // btnCrearAgente
            // 
            btnCrearAgente.BackColor = Color.Green;
            btnCrearAgente.FlatAppearance.BorderColor = Color.Black;
            btnCrearAgente.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearAgente.ForeColor = Color.White;
            btnCrearAgente.Location = new Point(1048, 57);
            btnCrearAgente.Name = "btnCrearAgente";
            btnCrearAgente.Size = new Size(424, 58);
            btnCrearAgente.TabIndex = 3;
            btnCrearAgente.Text = "Crear Agente";
            btnCrearAgente.UseVisualStyleBackColor = false;
            btnCrearAgente.Click += btnCrearAgente_Click;
            // 
            // lblProblema
            // 
            lblProblema.AutoSize = true;
            lblProblema.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProblema.Location = new Point(27, 132);
            lblProblema.Name = "lblProblema";
            lblProblema.Size = new Size(322, 28);
            lblProblema.TabIndex = 4;
            lblProblema.Text = "Problema que atiende el agente:";
            lblProblema.Click += label3_Click;
            // 
            // textBoxProblema
            // 
            textBoxProblema.BackColor = SystemColors.Window;
            textBoxProblema.BorderStyle = BorderStyle.FixedSingle;
            textBoxProblema.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxProblema.Location = new Point(27, 172);
            textBoxProblema.Multiline = true;
            textBoxProblema.Name = "textBoxProblema";
            textBoxProblema.ReadOnly = true;
            textBoxProblema.Size = new Size(705, 127);
            textBoxProblema.TabIndex = 5;
            textBoxProblema.Text = "Los estudiantes universitarios a menudo no saben cómo planificar su tiempo de estudio de forma eficiente, acumulando materias y sin saber cómo dividir las horas disponibles en bloques realistas.";
            textBoxProblema.TextChanged += textBoxProblema_TextChanged;
            // 
            // textBoxInstruccionesDeAgente
            // 
            textBoxInstruccionesDeAgente.BackColor = SystemColors.Window;
            textBoxInstruccionesDeAgente.BorderStyle = BorderStyle.FixedSingle;
            textBoxInstruccionesDeAgente.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInstruccionesDeAgente.Location = new Point(755, 172);
            textBoxInstruccionesDeAgente.Multiline = true;
            textBoxInstruccionesDeAgente.Name = "textBoxInstruccionesDeAgente";
            textBoxInstruccionesDeAgente.ReadOnly = true;
            textBoxInstruccionesDeAgente.Size = new Size(717, 127);
            textBoxInstruccionesDeAgente.TabIndex = 6;
            textBoxInstruccionesDeAgente.Text = resources.GetString("textBoxInstruccionesDeAgente.Text");
            textBoxInstruccionesDeAgente.TextChanged += textBox2_TextChanged;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstrucciones.Location = new Point(755, 132);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(250, 28);
            lblInstrucciones.TabIndex = 7;
            lblInstrucciones.Text = "Instrucciones del agente:";
            // 
            // lblConversacion
            // 
            lblConversacion.AutoSize = true;
            lblConversacion.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConversacion.Location = new Point(27, 323);
            lblConversacion.Name = "lblConversacion";
            lblConversacion.Size = new Size(145, 28);
            lblConversacion.TabIndex = 8;
            lblConversacion.Text = "Conversación:";
            // 
            // richTextBoxConversacion
            // 
            richTextBoxConversacion.BackColor = Color.White;
            richTextBoxConversacion.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxConversacion.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxConversacion.Location = new Point(27, 368);
            richTextBoxConversacion.Name = "richTextBoxConversacion";
            richTextBoxConversacion.ReadOnly = true;
            richTextBoxConversacion.Size = new Size(1445, 433);
            richTextBoxConversacion.TabIndex = 9;
            richTextBoxConversacion.Text = "";
            richTextBoxConversacion.TextChanged += richTextBoxConversacion_TextChanged;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsulta.Location = new Point(31, 828);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(125, 28);
            lblConsulta.TabIndex = 10;
            lblConsulta.Text = "Tu consulta:";
            // 
            // textBoxConsulta
            // 
            textBoxConsulta.BorderStyle = BorderStyle.FixedSingle;
            textBoxConsulta.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConsulta.Location = new Point(27, 870);
            textBoxConsulta.Multiline = true;
            textBoxConsulta.Name = "textBoxConsulta";
            textBoxConsulta.Size = new Size(1006, 136);
            textBoxConsulta.TabIndex = 11;
            textBoxConsulta.TextChanged += textBoxConsulta_TextChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.MediumBlue;
            btnEnviar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(1048, 870);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(424, 60);
            btnEnviar.TabIndex = 12;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnNuevaSesion
            // 
            btnNuevaSesion.BackColor = Color.DarkRed;
            btnNuevaSesion.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaSesion.ForeColor = Color.White;
            btnNuevaSesion.Location = new Point(1048, 946);
            btnNuevaSesion.Name = "btnNuevaSesion";
            btnNuevaSesion.Size = new Size(424, 60);
            btnNuevaSesion.TabIndex = 13;
            btnNuevaSesion.Text = "Nueva Sesión";
            btnNuevaSesion.UseVisualStyleBackColor = false;
            btnNuevaSesion.Click += btnNuevaSesion_Click;
            // 
            // comboBoxProveedor
            // 
            comboBoxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProveedor.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxProveedor.ForeColor = Color.Black;
            comboBoxProveedor.FormattingEnabled = true;
            comboBoxProveedor.Items.AddRange(new object[] { "Gemini", "Groq" });
            comboBoxProveedor.Location = new Point(31, 65);
            comboBoxProveedor.Name = "comboBoxProveedor";
            comboBoxProveedor.Size = new Size(1002, 36);
            comboBoxProveedor.TabIndex = 14;
            comboBoxProveedor.SelectedIndexChanged += comboBoxProveedor_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(703, 23);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 15;
            label1.Text = "Estado:";
            label1.Click += label1_Click_1;
            // 
            // lblEstadoProveedor
            // 
            lblEstadoProveedor.AutoSize = true;
            lblEstadoProveedor.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoProveedor.Location = new Point(790, 23);
            lblEstadoProveedor.Name = "lblEstadoProveedor";
            lblEstadoProveedor.Size = new Size(30, 28);
            lblEstadoProveedor.TabIndex = 16;
            lblEstadoProveedor.Text = "...";
            lblEstadoProveedor.Click += lblEstadoProveedor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1496, 1033);
            Controls.Add(lblEstadoProveedor);
            Controls.Add(label1);
            Controls.Add(comboBoxProveedor);
            Controls.Add(btnNuevaSesion);
            Controls.Add(btnEnviar);
            Controls.Add(textBoxConsulta);
            Controls.Add(lblConsulta);
            Controls.Add(richTextBoxConversacion);
            Controls.Add(lblConversacion);
            Controls.Add(lblInstrucciones);
            Controls.Add(textBoxInstruccionesDeAgente);
            Controls.Add(textBoxProblema);
            Controls.Add(lblProblema);
            Controls.Add(btnCrearAgente);
            Controls.Add(lblProveedor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProveedor;
        private Button btnCrearAgente;
        private Label lblProblema;
        private TextBox textBoxProblema;
        private TextBox textBoxInstruccionesDeAgente;
        private Label lblInstrucciones;
        private Label lblConversacion;
        private RichTextBox richTextBoxConversacion;
        private Label lblConsulta;
        private TextBox textBoxConsulta;
        private Button btnEnviar;
        private Button btnNuevaSesion;
        private ComboBox comboBoxProveedor;
        private Label label1;
        private Label lblEstadoProveedor;
    }
}
