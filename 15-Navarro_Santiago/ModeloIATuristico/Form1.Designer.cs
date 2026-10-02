namespace ModeloIATuristico
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
            txtDestino = new TextBox();
            txtTiempoDisponible = new TextBox();
            txtPreferencias = new TextBox();
            cmbRitmo = new ComboBox();
            btnCrearItinerario = new Button();
            rtbConversacion = new RichTextBox();
            txtConsulta = new TextBox();
            btnEnviar = new Button();
            btnNuevaSesion = new Button();
            lblTiempoUtilizado = new Label();
            lblTiempoRestante = new Label();
            lblResultadoViabilidad = new Label();
            tituloEmpresa = new Label();
            panel1 = new Panel();
            subtitulo = new Label();
            panel2viaje = new Panel();
            ritmoViajeTxt = new Label();
            preferenciasTxt = new Label();
            tiempodisTxt = new Label();
            destinotxt = new Label();
            label1 = new Label();
            panel3viaje = new Panel();
            panelComunicacion = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2viaje.SuspendLayout();
            panel3viaje.SuspendLayout();
            panelComunicacion.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtDestino
            // 
            txtDestino.BackColor = SystemColors.GradientInactiveCaption;
            txtDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDestino.Location = new Point(11, 85);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(347, 34);
            txtDestino.TabIndex = 0;
            // 
            // txtTiempoDisponible
            // 
            txtTiempoDisponible.BackColor = SystemColors.GradientActiveCaption;
            txtTiempoDisponible.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTiempoDisponible.Location = new Point(11, 183);
            txtTiempoDisponible.Name = "txtTiempoDisponible";
            txtTiempoDisponible.Size = new Size(347, 34);
            txtTiempoDisponible.TabIndex = 1;
            // 
            // txtPreferencias
            // 
            txtPreferencias.BackColor = SystemColors.GradientActiveCaption;
            txtPreferencias.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreferencias.Location = new Point(11, 286);
            txtPreferencias.Name = "txtPreferencias";
            txtPreferencias.Size = new Size(347, 34);
            txtPreferencias.TabIndex = 2;
            // 
            // cmbRitmo
            // 
            cmbRitmo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRitmo.FormattingEnabled = true;
            cmbRitmo.Location = new Point(11, 367);
            cmbRitmo.Name = "cmbRitmo";
            cmbRitmo.Size = new Size(347, 36);
            cmbRitmo.TabIndex = 3;
            cmbRitmo.SelectedIndexChanged += cmbRitmo_SelectedIndexChanged;
            // 
            // btnCrearItinerario
            // 
            btnCrearItinerario.BackColor = Color.MidnightBlue;
            btnCrearItinerario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearItinerario.ForeColor = SystemColors.Control;
            btnCrearItinerario.Location = new Point(81, 423);
            btnCrearItinerario.Name = "btnCrearItinerario";
            btnCrearItinerario.Size = new Size(210, 41);
            btnCrearItinerario.TabIndex = 4;
            btnCrearItinerario.Text = "Crear itenerario";
            btnCrearItinerario.UseVisualStyleBackColor = false;
            btnCrearItinerario.Click += btnCrearItinerario_Click;
            // 
            // rtbConversacion
            // 
            rtbConversacion.Location = new Point(0, 0);
            rtbConversacion.Name = "rtbConversacion";
            rtbConversacion.Size = new Size(679, 481);
            rtbConversacion.TabIndex = 5;
            rtbConversacion.Text = "";
            rtbConversacion.TextChanged += rtbConversacion_TextChanged;
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(3, 499);
            txtConsulta.Multiline = true;
            txtConsulta.Name = "txtConsulta";
            txtConsulta.PlaceholderText = "Escriba su mensaje";
            txtConsulta.Size = new Size(553, 45);
            txtConsulta.TabIndex = 6;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.MidnightBlue;
            btnEnviar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = SystemColors.Control;
            btnEnviar.Location = new Point(562, 499);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(116, 45);
            btnEnviar.TabIndex = 7;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnNuevaSesion
            // 
            btnNuevaSesion.BackColor = Color.Navy;
            btnNuevaSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaSesion.ForeColor = SystemColors.Control;
            btnNuevaSesion.Location = new Point(12, 661);
            btnNuevaSesion.Name = "btnNuevaSesion";
            btnNuevaSesion.Size = new Size(155, 37);
            btnNuevaSesion.TabIndex = 8;
            btnNuevaSesion.Text = "Nueva sesión";
            btnNuevaSesion.UseVisualStyleBackColor = false;
            // 
            // lblTiempoUtilizado
            // 
            lblTiempoUtilizado.AutoSize = true;
            lblTiempoUtilizado.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempoUtilizado.Location = new Point(29, 54);
            lblTiempoUtilizado.Name = "lblTiempoUtilizado";
            lblTiempoUtilizado.Size = new Size(18, 25);
            lblTiempoUtilizado.TabIndex = 9;
            lblTiempoUtilizado.Text = "t";
            // 
            // lblTiempoRestante
            // 
            lblTiempoRestante.AutoSize = true;
            lblTiempoRestante.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempoRestante.Location = new Point(29, 108);
            lblTiempoRestante.Name = "lblTiempoRestante";
            lblTiempoRestante.Size = new Size(18, 25);
            lblTiempoRestante.TabIndex = 10;
            lblTiempoRestante.Text = "r";
            // 
            // lblResultadoViabilidad
            // 
            lblResultadoViabilidad.AutoSize = true;
            lblResultadoViabilidad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadoViabilidad.Location = new Point(26, 154);
            lblResultadoViabilidad.Name = "lblResultadoViabilidad";
            lblResultadoViabilidad.Size = new Size(21, 25);
            lblResultadoViabilidad.TabIndex = 11;
            lblResultadoViabilidad.Text = "v";
            // 
            // tituloEmpresa
            // 
            tituloEmpresa.AutoSize = true;
            tituloEmpresa.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloEmpresa.ForeColor = SystemColors.ButtonHighlight;
            tituloEmpresa.Location = new Point(33, 9);
            tituloEmpresa.Name = "tituloEmpresa";
            tituloEmpresa.Size = new Size(222, 39);
            tituloEmpresa.TabIndex = 12;
            tituloEmpresa.Text = "TavelPlan AI";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(subtitulo);
            panel1.Controls.Add(tituloEmpresa);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1489, 91);
            panel1.TabIndex = 13;
            // 
            // subtitulo
            // 
            subtitulo.AutoSize = true;
            subtitulo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtitulo.ForeColor = SystemColors.Control;
            subtitulo.Location = new Point(33, 58);
            subtitulo.Name = "subtitulo";
            subtitulo.Size = new Size(529, 23);
            subtitulo.TabIndex = 14;
            subtitulo.Text = "Agente inteligente para planificacion de itinerarios turísticos";
            // 
            // panel2viaje
            // 
            panel2viaje.BackColor = Color.White;
            panel2viaje.Controls.Add(ritmoViajeTxt);
            panel2viaje.Controls.Add(preferenciasTxt);
            panel2viaje.Controls.Add(tiempodisTxt);
            panel2viaje.Controls.Add(destinotxt);
            panel2viaje.Controls.Add(txtDestino);
            panel2viaje.Controls.Add(txtTiempoDisponible);
            panel2viaje.Controls.Add(txtPreferencias);
            panel2viaje.Controls.Add(btnCrearItinerario);
            panel2viaje.Controls.Add(cmbRitmo);
            panel2viaje.Location = new Point(12, 151);
            panel2viaje.Name = "panel2viaje";
            panel2viaje.Size = new Size(414, 491);
            panel2viaje.TabIndex = 14;
            // 
            // ritmoViajeTxt
            // 
            ritmoViajeTxt.AutoSize = true;
            ritmoViajeTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ritmoViajeTxt.Location = new Point(11, 336);
            ritmoViajeTxt.Name = "ritmoViajeTxt";
            ritmoViajeTxt.Size = new Size(154, 28);
            ritmoViajeTxt.TabIndex = 5;
            ritmoViajeTxt.Text = "Ritmo de viaje:";
            // 
            // preferenciasTxt
            // 
            preferenciasTxt.AutoSize = true;
            preferenciasTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            preferenciasTxt.Location = new Point(11, 244);
            preferenciasTxt.Name = "preferenciasTxt";
            preferenciasTxt.Size = new Size(134, 28);
            preferenciasTxt.TabIndex = 2;
            preferenciasTxt.Text = "Preferencias:";
            // 
            // tiempodisTxt
            // 
            tiempodisTxt.AutoSize = true;
            tiempodisTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tiempodisTxt.Location = new Point(11, 142);
            tiempodisTxt.Name = "tiempodisTxt";
            tiempodisTxt.Size = new Size(279, 28);
            tiempodisTxt.TabIndex = 1;
            tiempodisTxt.Text = "Tiempo disponible en horas:";
            tiempodisTxt.Click += tiempodisTxt_Click;
            // 
            // destinotxt
            // 
            destinotxt.AutoSize = true;
            destinotxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            destinotxt.Location = new Point(11, 54);
            destinotxt.Name = "destinotxt";
            destinotxt.Size = new Size(90, 28);
            destinotxt.TabIndex = 0;
            destinotxt.Text = "Destino:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 31);
            label1.TabIndex = 15;
            label1.Text = "Información del viaje";
            // 
            // panel3viaje
            // 
            panel3viaje.BackColor = Color.Navy;
            panel3viaje.Controls.Add(label1);
            panel3viaje.Location = new Point(12, 151);
            panel3viaje.Name = "panel3viaje";
            panel3viaje.Size = new Size(414, 39);
            panel3viaje.TabIndex = 0;
            // 
            // panelComunicacion
            // 
            panelComunicacion.BackColor = Color.LightSkyBlue;
            panelComunicacion.Controls.Add(rtbConversacion);
            panelComunicacion.Controls.Add(txtConsulta);
            panelComunicacion.Controls.Add(btnEnviar);
            panelComunicacion.Location = new Point(467, 151);
            panelComunicacion.Name = "panelComunicacion";
            panelComunicacion.Size = new Size(681, 547);
            panelComunicacion.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblTiempoUtilizado);
            panel2.Controls.Add(lblResultadoViabilidad);
            panel2.Controls.Add(lblTiempoRestante);
            panel2.Location = new Point(1171, 151);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 454);
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(297, 39);
            panel3.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(49, 3);
            label2.Name = "label2";
            label2.Size = new Size(202, 28);
            label2.TabIndex = 15;
            label2.Text = "Itinerario propuesto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1487, 710);
            Controls.Add(panel2);
            Controls.Add(panelComunicacion);
            Controls.Add(btnNuevaSesion);
            Controls.Add(panel3viaje);
            Controls.Add(panel2viaje);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2viaje.ResumeLayout(false);
            panel2viaje.PerformLayout();
            panel3viaje.ResumeLayout(false);
            panel3viaje.PerformLayout();
            panelComunicacion.ResumeLayout(false);
            panelComunicacion.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDestino;
        private TextBox txtTiempoDisponible;
        private TextBox txtPreferencias;
        private ComboBox cmbRitmo;
        private Button btnCrearItinerario;
        private RichTextBox rtbConversacion;
        private TextBox txtConsulta;
        private Button btnEnviar;
        private Button btnNuevaSesion;
        private Label lblTiempoUtilizado;
        private Label lblTiempoRestante;
        private Label lblResultadoViabilidad;
        private Label tituloEmpresa;
        private Panel panel1;
        private Label subtitulo;
        private Panel panel2viaje;
        private Label label1;
        private Panel panel3viaje;
        private Label destinotxt;
        private Label preferenciasTxt;
        private Label tiempodisTxt;
        private Label ritmoViajeTxt;
        private Panel panelComunicacion;
        private Label label2;
        private Panel panel3;
        private Panel panel2;
        private Label l;
        private Label label3;
    }
}
