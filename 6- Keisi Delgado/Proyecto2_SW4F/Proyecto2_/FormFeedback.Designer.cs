namespace Proyecto2_
{
    partial class FormFeedback
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            
            this.lblUtility = new System.Windows.Forms.Label();
            this.rbVeryUseful = new System.Windows.Forms.RadioButton();
            this.rbUseful = new System.Windows.Forms.RadioButton();
            this.rbNotVeryUseful = new System.Windows.Forms.RadioButton();
            this.rbNotUseful = new System.Windows.Forms.RadioButton();
            
            this.lblQuality = new System.Windows.Forms.Label();
            this.chkClear = new System.Windows.Forms.CheckBox();
            this.chkRelevant = new System.Windows.Forms.CheckBox();
            this.chkEasy = new System.Windows.Forms.CheckBox();
            this.chkPractical = new System.Windows.Forms.CheckBox();
            this.chkMissingInfo = new System.Windows.Forms.CheckBox();
            
            this.lblLimitations = new System.Windows.Forms.Label();
            this.rtbLimitations = new System.Windows.Forms.RichTextBox();
            
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            
            this.SuspendLayout();
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "¿Qué te pareció la respuesta de Kodu?";
            
            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblSubtitle.Location = new System.Drawing.Point(32, 65);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(400, 23);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Tu feedback ayuda a evaluar la utilidad del agente.";
            
            // lblUtility
            this.lblUtility.AutoSize = true;
            this.lblUtility.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUtility.ForeColor = System.Drawing.Color.White;
            this.lblUtility.Location = new System.Drawing.Point(32, 110);
            this.lblUtility.Name = "lblUtility";
            this.lblUtility.Size = new System.Drawing.Size(250, 25);
            this.lblUtility.TabIndex = 2;
            this.lblUtility.Text = "¿Qué tan útil fue la respuesta?";
            
            // rbVeryUseful
            this.rbVeryUseful.AutoSize = true;
            this.rbVeryUseful.ForeColor = System.Drawing.Color.White;
            this.rbVeryUseful.Location = new System.Drawing.Point(36, 140);
            this.rbVeryUseful.Name = "rbVeryUseful";
            this.rbVeryUseful.Size = new System.Drawing.Size(95, 24);
            this.rbVeryUseful.TabIndex = 3;
            this.rbVeryUseful.TabStop = true;
            this.rbVeryUseful.Text = "Muy útil";
            
            // rbUseful
            this.rbUseful.AutoSize = true;
            this.rbUseful.ForeColor = System.Drawing.Color.White;
            this.rbUseful.Location = new System.Drawing.Point(150, 140);
            this.rbUseful.Name = "rbUseful";
            this.rbUseful.Size = new System.Drawing.Size(60, 24);
            this.rbUseful.TabIndex = 4;
            this.rbUseful.TabStop = true;
            this.rbUseful.Text = "Útil";
            
            // rbNotVeryUseful
            this.rbNotVeryUseful.AutoSize = true;
            this.rbNotVeryUseful.ForeColor = System.Drawing.Color.White;
            this.rbNotVeryUseful.Location = new System.Drawing.Point(240, 140);
            this.rbNotVeryUseful.Name = "rbNotVeryUseful";
            this.rbNotVeryUseful.Size = new System.Drawing.Size(95, 24);
            this.rbNotVeryUseful.TabIndex = 5;
            this.rbNotVeryUseful.TabStop = true;
            this.rbNotVeryUseful.Text = "Poco útil";
            
            // rbNotUseful
            this.rbNotUseful.AutoSize = true;
            this.rbNotUseful.ForeColor = System.Drawing.Color.White;
            this.rbNotUseful.Location = new System.Drawing.Point(350, 140);
            this.rbNotUseful.Name = "rbNotUseful";
            this.rbNotUseful.Size = new System.Drawing.Size(105, 24);
            this.rbNotUseful.TabIndex = 6;
            this.rbNotUseful.TabStop = true;
            this.rbNotUseful.Text = "No fue útil";
            
            // lblQuality
            this.lblQuality.AutoSize = true;
            this.lblQuality.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuality.ForeColor = System.Drawing.Color.White;
            this.lblQuality.Location = new System.Drawing.Point(32, 190);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(160, 25);
            this.lblQuality.TabIndex = 7;
            this.lblQuality.Text = "La respuesta fue:";
            
            // chkClear
            this.chkClear.AutoSize = true;
            this.chkClear.ForeColor = System.Drawing.Color.White;
            this.chkClear.Location = new System.Drawing.Point(36, 225);
            this.chkClear.Name = "chkClear";
            this.chkClear.Size = new System.Drawing.Size(70, 24);
            this.chkClear.TabIndex = 8;
            this.chkClear.Text = "Clara";
            
            // chkRelevant
            this.chkRelevant.AutoSize = true;
            this.chkRelevant.ForeColor = System.Drawing.Color.White;
            this.chkRelevant.Location = new System.Drawing.Point(130, 225);
            this.chkRelevant.Name = "chkRelevant";
            this.chkRelevant.Size = new System.Drawing.Size(200, 24);
            this.chkRelevant.TabIndex = 9;
            this.chkRelevant.Text = "Relevante para mi negocio";
            
            // chkEasy
            this.chkEasy.AutoSize = true;
            this.chkEasy.ForeColor = System.Drawing.Color.White;
            this.chkEasy.Location = new System.Drawing.Point(350, 225);
            this.chkEasy.Name = "chkEasy";
            this.chkEasy.Size = new System.Drawing.Size(140, 24);
            this.chkEasy.TabIndex = 10;
            this.chkEasy.Text = "Fácil de entender";
            
            // chkPractical
            this.chkPractical.AutoSize = true;
            this.chkPractical.ForeColor = System.Drawing.Color.White;
            this.chkPractical.Location = new System.Drawing.Point(36, 255);
            this.chkPractical.Name = "chkPractical";
            this.chkPractical.Size = new System.Drawing.Size(85, 24);
            this.chkPractical.TabIndex = 11;
            this.chkPractical.Text = "Práctica";
            
            // chkMissingInfo
            this.chkMissingInfo.AutoSize = true;
            this.chkMissingInfo.ForeColor = System.Drawing.Color.White;
            this.chkMissingInfo.Location = new System.Drawing.Point(130, 255);
            this.chkMissingInfo.Name = "chkMissingInfo";
            this.chkMissingInfo.Size = new System.Drawing.Size(160, 24);
            this.chkMissingInfo.TabIndex = 12;
            this.chkMissingInfo.Text = "Le faltó información";
            
            // lblLimitations
            this.lblLimitations.AutoSize = true;
            this.lblLimitations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLimitations.ForeColor = System.Drawing.Color.White;
            this.lblLimitations.Location = new System.Drawing.Point(32, 300);
            this.lblLimitations.Name = "lblLimitations";
            this.lblLimitations.Size = new System.Drawing.Size(260, 25);
            this.lblLimitations.TabIndex = 13;
            this.lblLimitations.Text = "¿Qué podría mejorar Kodu?";
            
            // rtbLimitations
            this.rtbLimitations.BackColor = System.Drawing.Color.FromArgb(40, 80, 140);
            this.rtbLimitations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLimitations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbLimitations.ForeColor = System.Drawing.Color.White;
            this.rtbLimitations.Location = new System.Drawing.Point(36, 335);
            this.rtbLimitations.Name = "rtbLimitations";
            this.rtbLimitations.Size = new System.Drawing.Size(460, 60);
            this.rtbLimitations.TabIndex = 14;
            this.rtbLimitations.Text = "Describe brevemente qué información faltó o qué debería mejorar.";
            
            // lblComments
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblComments.ForeColor = System.Drawing.Color.White;
            this.lblComments.Location = new System.Drawing.Point(32, 415);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(200, 25);
            this.lblComments.TabIndex = 15;
            this.lblComments.Text = "Comentario adicional";
            
            // txtComments
            this.txtComments.BackColor = System.Drawing.Color.FromArgb(40, 80, 140);
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComments.ForeColor = System.Drawing.Color.White;
            this.txtComments.Location = new System.Drawing.Point(36, 450);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(460, 60);
            this.txtComments.TabIndex = 16;
            this.txtComments.Text = "Escribe cualquier observación adicional...";
            
            // btnSubmit
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(100, 200, 100);
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(336, 540);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 45);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Enviar feedback";
            this.btnSubmit.UseVisualStyleBackColor = false;
            
            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(80, 100, 150);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(190, 540);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 45);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            
            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblStatus.ForeColor = System.Drawing.Color.LightGray;
            this.lblStatus.Location = new System.Drawing.Point(36, 610);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(150, 20);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Evaluación pendiente";
            
            // FormFeedback
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(12, 34, 79);
            this.ClientSize = new System.Drawing.Size(530, 650);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.rtbLimitations);
            this.Controls.Add(this.lblLimitations);
            this.Controls.Add(this.chkMissingInfo);
            this.Controls.Add(this.chkPractical);
            this.Controls.Add(this.chkEasy);
            this.Controls.Add(this.chkRelevant);
            this.Controls.Add(this.chkClear);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.rbNotUseful);
            this.Controls.Add(this.rbNotVeryUseful);
            this.Controls.Add(this.rbUseful);
            this.Controls.Add(this.rbVeryUseful);
            this.Controls.Add(this.lblUtility);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Evaluar Respuesta";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUtility;
        private System.Windows.Forms.RadioButton rbVeryUseful;
        private System.Windows.Forms.RadioButton rbUseful;
        private System.Windows.Forms.RadioButton rbNotVeryUseful;
        private System.Windows.Forms.RadioButton rbNotUseful;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.CheckBox chkClear;
        private System.Windows.Forms.CheckBox chkRelevant;
        private System.Windows.Forms.CheckBox chkEasy;
        private System.Windows.Forms.CheckBox chkPractical;
        private System.Windows.Forms.CheckBox chkMissingInfo;
        private System.Windows.Forms.Label lblLimitations;
        private System.Windows.Forms.RichTextBox rtbLimitations;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStatus;
    }
}
