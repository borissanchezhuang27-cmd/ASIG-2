using System.Globalization;
using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;

namespace ModeloIATuristico
{
    public partial class Form1 : Form
    {
        // Guarda el agente de IA y la sesión para mantener la conversación.
        private AIAgent? _agent;
        private AgentSession? _session;

        // Herramienta local utilizada para comprobar el tiempo del itinerario.
        private readonly ItineraryTool _itineraryTool = new();

        // Etiqueta que muestra al usuario el estado actual del agente.
        private readonly Label lblEstado = new Label
        {
            AutoSize = true,
            Text = "Agente sin crear",
            Font = new Font("Segoe UI", 10F, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Color.SeaGreen,
            Padding = new Padding(8, 4, 8, 4)
        };

        private const string Problema =
         "Los turistas con poco tiempo necesitan organizar un itinerario de viaje de acuerdo con su destino, tiempo disponible, preferencias y ritmo de viaje.";

        // Instrucciones que definen el comportamiento y formato de respuesta del agente.
        private const string Instrucciones =
        @"Eres TravelPlan AI, un agente experto en planificación de itinerarios turísticos.

        El usuario proporciona cuatro datos principales:
        1. Destino: país, ciudad o lugar que desea visitar.
        2. Horas disponibles: cantidad de tiempo que tiene para realizar el itinerario.
        3. Preferencias: actividades o tipos de lugares que le interesan, por ejemplo naturaleza, playas, historia, gastronomía o cultura.
        4. Ritmo: velocidad del viaje, que puede ser Tranquilo, Moderado o Intenso.

        REGLAS:
        1. Utiliza siempre los cuatro datos proporcionados por el usuario para elaborar el itinerario.
        2. El destino determina el país, ciudad o zona donde deben proponerse las actividades.
        3. Las horas disponibles determinan cuánto tiempo puede durar el itinerario.
        4. Las preferencias determinan el tipo de actividades que se deben priorizar.
        5. El ritmo determina la cantidad y distribución de actividades. Un ritmo tranquilo debe incluir menos actividades y más tiempo para cada una, mientras que un ritmo intenso puede incluir más actividades.
        6. Si falta alguno de los datos necesarios, solicita al usuario la información faltante antes de crear el itinerario.
        7. Propón actividades relacionadas con el destino indicado por el usuario.
        8. Incluye una duración estimada para cada actividad y considera los traslados.
        9. SIEMPRE utiliza la herramienta verificar_tiempos_itinerario antes de presentar el itinerario final.
        10. Si el itinerario excede las horas disponibles, reduce o elimina actividades hasta que se ajuste al tiempo indicado.
        11. No inventes horarios, precios ni disponibilidad. Indica que estos datos son estimados y deben confirmarse.
        12. No des consejos médicos, legales ni financieros definitivos.

        FORMATO:
        Responde siempre como texto plano, sin Markdown.
        No uses asteriscos (*), almohadillas (#), guiones de separación (---), negritas ni otros símbolos de Markdown.
        Usa una lista numerada sencilla.
        Cada actividad debe mostrar la hora, actividad, duración y descripción.
        Al final muestra el resultado de la verificación.";

        public Form1()
        {
            InitializeComponent();

            Text = "TravelPlan AI";
            tituloEmpresa.Text = "TravelPlan AI";
            btnCrearItinerario.Text = "Crear itinerario";

            cmbRitmo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRitmo.Items.AddRange(new object[] { "Tranquilo", "Moderado", "Intenso" });
            cmbRitmo.SelectedIndex = 0;

            btnNuevaSesion.Click += btnNuevaSesion_Click;
            rtbConversacion.ReadOnly = true;

            ReiniciarPanelTiempos();

            lblEstado.Location = new Point(panel1.Width - 260, 30);
            lblEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(lblEstado);
            lblEstado.BringToFront();

            // Se ejecuta cuando la herramienta termina de verificar el itinerario.
            _itineraryTool.Verificado += r =>
            {
                if (InvokeRequired)
                {
                    BeginInvoke(() => MostrarVerificacion(r));
                    return;
                }

                MostrarVerificacion(r);
            };
        }

        // Actualiza el mensaje y el color que indican el estado del agente.
        private void SetEstado(string texto)
        {
            lblEstado.Text = texto;
            lblEstado.BackColor = texto.StartsWith("error") ? Color.Firebrick
                                : texto.StartsWith("pensando") ? Color.DarkOrange
                                : Color.SeaGreen;
        }

        private void Escribir(string texto)
        {
            rtbConversacion.AppendText(texto + "\n\n");
            rtbConversacion.ScrollToCaret();
        }

        private void ReiniciarPanelTiempos()
        {
            lblTiempoUtilizado.Text = "Tiempo utilizado: -";
            lblTiempoRestante.Text = "Tiempo restante: -";
            lblResultadoViabilidad.Text = "Resultado: -";
        }

        // Muestra en la interfaz el resultado obtenido de la herramienta local.
        private void MostrarVerificacion(ResultadoVerificacion r)
        {
            lblTiempoUtilizado.Text = $"Tiempo utilizado: {r.TiempoRequeridoHoras} h";
            lblTiempoRestante.Text = $"Tiempo restante: {r.TiempoRestanteHoras} h";
            lblResultadoViabilidad.Text = r.EsViable ? "Resultado: VIABLE" : "Resultado: EXCEDIDO";

            Escribir($"[Herramienta local] {r.Mensaje} " +
                     $"({r.TotalActividades} actividades, {r.TiempoRequeridoHoras}/{r.TiempoDisponibleHoras} h)");
        }

        // Crea el agente, registra la herramienta y abre una sesión de conversación.
        private async Task<bool> CrearAgenteAsync()
        {
            try
            {
                // Convierte el método de verificación en una herramienta que el agente puede utilizar.
                var herramientas = new List<AITool>
                {
                    AIFunctionFactory.Create(
                        _itineraryTool.VerificarTiemposItinerario,
                        name: "verificar_tiempos_itinerario")
                };

                _agent = AgentFactory.CrearGemini(
                    "TravelPlanAI",
                    $"{Instrucciones}\n\nPROBLEMA A RESOLVER: {Problema}",
                    herramientas);

                _session = await _agent.CreateSessionAsync();

                SetEstado("agente listo (Gemini)");
                return true;
            }
            catch (Exception ex)
            {
                // Si ocurre un error al crear el agente, se limpian sus referencias.
                _agent = null;
                _session = null;

                SetEstado("error al crear el agente");
                Escribir($"Error: {ex.Message}");
                return false;
            }
        }

        // Envía una solicitud al agente y muestra la respuesta en la interfaz.
        private async Task EnviarAsync(string mensaje, Button boton)
        {
            if (_agent is null || _session is null)
            {
                if (!await CrearAgenteAsync()) return;
            }

            Escribir($"Usuario: {mensaje}");
            boton.Enabled = false;
            SetEstado("pensando...");

            // Permite medir el tiempo que tarda el agente en responder.
            var reloj = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                var respuesta = await _agent!.RunAsync(mensaje, _session!);
                reloj.Stop();

                // Elimina algunos símbolos de Markdown para mostrar una respuesta más limpia.
                string texto = respuesta.Text
                    .Replace("**", "")
                    .Replace("###", "")
                    .Replace("---", "")
                    .Replace("*", "");

                Escribir($"Agente: {texto}");
                SetEstado($"listo ({reloj.Elapsed.TotalSeconds:F1} s)");
            }
            catch (Exception ex)
            {
                SetEstado("error de conexión");
                Escribir($"Error: {ex.Message}");
            }
            finally
            {
                boton.Enabled = true;
            }
        }

        // Obtiene los datos del formulario y solicita al agente que cree el itinerario.
        private async void btnCrearItinerario_Click(object? sender, EventArgs e)
        {
            string destino = txtDestino.Text.Trim();
            string tiempo = txtTiempoDisponible.Text.Trim().Replace(',', '.');
            string ritmo = cmbRitmo.SelectedItem?.ToString() ?? "Tranquilo";

            // Valida que el destino y las horas ingresadas sean correctos.
            if (string.IsNullOrEmpty(destino) ||
                !double.TryParse(tiempo, NumberStyles.Float, CultureInfo.InvariantCulture, out double horas) ||
                horas <= 0)
            {
                MessageBox.Show("Ingresa un destino y un tiempo disponible válido (horas).",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string solicitud = $"Quiero visitar {destino} durante {horas.ToString(CultureInfo.InvariantCulture)} horas. " +
                               $"Me interesan: {txtPreferencias.Text.Trim()}. Ritmo: {ritmo}. " +
                               "Propón un itinerario y verifícalo con tu herramienta.";

            await EnviarAsync(solicitud, btnCrearItinerario);
        }

        // Permite enviar una pregunta adicional al agente.
        private async void btnEnviar_Click(object? sender, EventArgs e)
        {
            string consulta = txtConsulta.Text.Trim();

            if (string.IsNullOrEmpty(consulta)) return;

            txtConsulta.Clear();
            await EnviarAsync(consulta, btnEnviar);
        }

        // Crea una nueva sesión para comenzar una conversación sin el historial anterior.
        private async void btnNuevaSesion_Click(object? sender, EventArgs e)
        {
            rtbConversacion.Clear();
            ReiniciarPanelTiempos();

            if (_agent is not null)
                _session = await _agent.CreateSessionAsync();

            Escribir("Sistema: sesión reiniciada, memoria borrada.");
        }

        // Eventos requeridos por el diseñador de Windows Forms.
        private void cmbRitmo_SelectedIndexChanged(object? sender, EventArgs e) { }
        private void rtbConversacion_TextChanged(object? sender, EventArgs e) { }
        private void tiempodisTxt_Click(object sender, EventArgs e) { }
    }
}