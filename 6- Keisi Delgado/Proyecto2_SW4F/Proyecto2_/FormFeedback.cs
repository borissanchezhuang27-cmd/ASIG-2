using System;
using System.Windows.Forms;

namespace Proyecto2_
{
    public partial class FormFeedback : Form
    {
        public FormFeedback()
        {
            InitializeComponent();
            
            this.btnSubmit.Click += BtnSubmit_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por tu feedback! Ayuda a mejorar las respuestas del agente.", "Feedback recibido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
