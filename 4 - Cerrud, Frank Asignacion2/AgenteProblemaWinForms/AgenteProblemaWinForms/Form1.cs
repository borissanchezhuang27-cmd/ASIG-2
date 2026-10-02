using System;
using System.Windows.Forms;
using OpenAI;
using OpenAI.Chat;

namespace AgenteProblemaWinForms
{
    public partial class Form1 : Form
    {
        // Clientes para ambos proveedores
        private Google.GenAI.Client? _googleClient;
        private ChatClient? _groqClient;

        private string _proveedorSeleccionado = string.Empty;
        private string _instruccionesSistema = string.Empty;
        private string _historialConversacion = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void richTextBoxConversacion_TextChanged(object sender, EventArgs e) { }
        private void textBoxConsulta_TextChanged(object sender, EventArgs e) { }
        private void textBoxProblema_TextChanged(object sender, EventArgs e) { }
        private void comboBoxProveedor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void lblEstadoProveedor_Click(object sender, EventArgs e) { }

        private void btnCrearAgente_Click(object sender, EventArgs e)
        {
            // Obtenemos el proveedor seleccionado del ComboBox
            _proveedorSeleccionado = comboBoxProveedor.SelectedItem?.ToString() ?? "Gemini";
            string problemaEstatico = textBoxProblema.Text.Trim();
            string instruccionesEstaticas = textBoxInstruccionesDeAgente.Text.Trim();

            if (string.IsNullOrEmpty(problemaEstatico))
            {
                MessageBox.Show("El campo de problema está vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblEstadoProveedor.Text = "Estado: Error - Falta definir el problema.";
                lblEstadoProveedor.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Indicamos estado de conexión en el label
            lblEstadoProveedor.Text = $"Estado: Conectando con {_proveedorSeleccionado}...";
            lblEstadoProveedor.ForeColor = System.Drawing.Color.Blue;

            _instruccionesSistema = $"Problema de contexto: {problemaEstatico}\n\nInstrucciones de comportamiento:\n{instruccionesEstaticas}";

            try
            {
                // Limpiamos clientes previos
                _googleClient = null;
                _groqClient = null;

                if (_proveedorSeleccionado.Equals("Gemini", StringComparison.OrdinalIgnoreCase))
                {
                    string apiKey = Environment.GetEnvironmentVariable("GOOGLE_GENAI_API_KEY");
                    if (string.IsNullOrEmpty(apiKey))
                    {
                        MessageBox.Show("No se encontró la variable de entorno GOOGLE_GENAI_API_KEY.", "Error de Configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblEstadoProveedor.Text = "Estado: Error de clave API (Gemini).";
                        lblEstadoProveedor.ForeColor = System.Drawing.Color.Red;
                        return;
                    }

                    _googleClient = new Google.GenAI.Client(apiKey: apiKey);
                }
                else if (_proveedorSeleccionado.Equals("Groq", StringComparison.OrdinalIgnoreCase))
                {
                    string apiKey = Environment.GetEnvironmentVariable("GROQ_API_KEY");
                    if (string.IsNullOrEmpty(apiKey))
                    {
                        MessageBox.Show("No se encontró la variable de entorno GROQ_API_KEY.", "Error de Configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblEstadoProveedor.Text = "Estado: Error de clave API (Groq).";
                        lblEstadoProveedor.ForeColor = System.Drawing.Color.Red;
                        return;
                    }

                    // Configuración de Groq usando el cliente compatible con OpenAI y tu modelo seleccionado
                    var clientOptions = new OpenAIClientOptions { Endpoint = new Uri("https://api.groq.com/openai/v1") };
                    var openAIClient = new OpenAIClient(new System.ClientModel.ApiKeyCredential(apiKey), clientOptions);
                    _groqClient = openAIClient.GetChatClient("openai/gpt-oss-20b");
                }

                // Inicializamos el historial con el contexto del sistema
                _historialConversacion = _instruccionesSistema + "\n\n--- Inicio de la Conversación ---\n";

                richTextBoxConversacion.Clear();

                // Éxito en el label
                lblEstadoProveedor.Text = $"¡Agente activo usando {_proveedorSeleccionado}!";
                lblEstadoProveedor.ForeColor = System.Drawing.Color.Green;

                MessageBox.Show($"¡Agente creado con éxito usando {_proveedorSeleccionado}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblEstadoProveedor.Text = "Error crítico en la inicialización.";
                lblEstadoProveedor.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Error al inicializar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (_googleClient is null && _groqClient is null)
            {
                MessageBox.Show("Primero debes hacer clic en 'Crear Agente' para inicializarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pregunta = textBoxConsulta.Text.Trim();
            if (string.IsNullOrWhiteSpace(pregunta)) return;

            btnEnviar.Enabled = false;

            // Estado procesando consulta
            lblEstadoProveedor.Text = "Procesando consulta...";
            lblEstadoProveedor.ForeColor = System.Drawing.Color.DarkOrange;

            richTextBoxConversacion.AppendText($"Usuario: {pregunta}\r\n\r\n");

            try
            {
                _historialConversacion += $"\nUsuario: {pregunta}";
                string textoRespuesta = "Sin respuesta";

                // Evaluamos cuál proveedor está activo para enviar la petición correctamente
                if (_proveedorSeleccionado.Equals("Gemini", StringComparison.OrdinalIgnoreCase) && _googleClient is not null)
                {
                    var response = await _googleClient.Models.GenerateContentAsync(
                        model: "gemini-3.8-flash", // Tu modelo de Gemini funcional
                        contents: _historialConversacion
                    );
                    textoRespuesta = response.Text ?? "Sin respuesta";
                }
                else if (_proveedorSeleccionado.Equals("Groq", StringComparison.OrdinalIgnoreCase) && _groqClient is not null)
                {
                    var messages = new ChatMessage[]
                    {
                        new SystemChatMessage(_instruccionesSistema),
                        new UserChatMessage(_historialConversacion)
                    };

                    var response = await _groqClient.CompleteChatAsync(messages);
                    textoRespuesta = response.Value.Content[0].Text ?? "Sin respuesta";
                }

                _historialConversacion += $"\nAgente: {textoRespuesta}";
                richTextBoxConversacion.AppendText($"Agente: {textoRespuesta}\r\n\r\n");

                // Vuelve a verde de operación normal
                lblEstadoProveedor.Text = $"Operando con normalidad ({_proveedorSeleccionado}).";
                lblEstadoProveedor.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblEstadoProveedor.Text = "Error de comunicación con la IA.";
                lblEstadoProveedor.ForeColor = System.Drawing.Color.Red;
                richTextBoxConversacion.AppendText($"Error de comunicación: {ex.Message}\r\n\r\n");
            }
            finally
            {
                btnEnviar.Enabled = true;
                textBoxConsulta.Clear();
            }
        }

        private void btnNuevaSesion_Click(object sender, EventArgs e)
        {
            if (_googleClient is not null || _groqClient is not null)
            {
                _historialConversacion = _instruccionesSistema + "\n\n--- Nueva Sesión ---\n";
                richTextBoxConversacion.Clear();

                lblEstadoProveedor.Text = $"Nueva sesión iniciada ({_proveedorSeleccionado}).";
                lblEstadoProveedor.ForeColor = System.Drawing.Color.Green;

                MessageBox.Show("Se ha iniciado una nueva sesión (memoria reiniciada, contexto estático conservado).", "Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}