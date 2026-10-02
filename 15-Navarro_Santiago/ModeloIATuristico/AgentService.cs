using Google.GenAI;// Librería de Google para conectarse y trabajar con los modelos Gemini
using Microsoft.Agents.AI;// Librería de Microsoft para crear y trabajar con agentes de inteligencia artificial
using Microsoft.Extensions.AI;// Librería que proporciona elementos para trabajar con clientes de IA y herramientas

namespace ModeloIATuristico;

public static class AgentFactory
{
    // Crea y configura el agente de inteligencia artificial utilizando Gemini
    public static AIAgent CrearGemini(string nombre, string instrucciones, IList<AITool> herramientas)
    {
        // Obtiene la API Key desde las variables de entorno para no escribirla directamente en el código
        string key = Environment.GetEnvironmentVariable("GOOGLE_GENAI_API_KEY")
            ?? throw new InvalidOperationException(
                "Defina la variable de entorno GOOGLE_GENAI_API_KEY y reinicie Visual Studio.");

        // Crea el cliente de Gemini y selecciona el modelo que utilizará el agente
        var chat = new Client(vertexAI: false, apiKey: key)
                 .AsIChatClient("gemini-3.8-flash");

        // Crea el agente utilizando el cliente, las instrucciones y las herramientas disponibles
        return new ChatClientAgent(
            chat,
            name: nombre,
            instructions: instrucciones,
            tools: herramientas);
    }
}