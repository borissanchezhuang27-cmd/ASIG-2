using System.ComponentModel;

namespace ModeloIATuristico;

public class Actividad
{
    [Description("Nombre de la actividad o lugar")]
    public string Nombre { get; set; } = string.Empty;

    [Description("Duración en horas, incluyendo traslado")]
    public double DuracionHoras { get; set; }

    [Description("Categoría: Historia, Naturaleza, Gastronomía, etc.")]
    public string Categoria { get; set; } = string.Empty;
}

public class ResultadoVerificacion
{
    public int TotalActividades { get; set; }
    public double TiempoRequeridoHoras { get; set; }
    public double TiempoDisponibleHoras { get; set; }
    public double TiempoRestanteHoras { get; set; }
    public bool EsViable { get; set; }
    public string Mensaje { get; set; } = string.Empty;
}

public class ItineraryTool
{
    // El formulario se suscribe para mostrar el resultado REAL de la herramienta.
    public event Action<ResultadoVerificacion>? Verificado;

    [Description("Verifica si la suma de duraciones de las actividades propuestas cabe en el tiempo disponible del usuario. Debe llamarse antes de presentar un itinerario final.")]
    public ResultadoVerificacion VerificarTiemposItinerario(
        [Description("Lista de actividades propuestas")] List<Actividad> actividades,
        [Description("Horas totales que el usuario tiene disponibles")] double tiempoDisponibleHoras)
    {
        // La herramienta es segura: valida la entrada y no accede a red ni archivos.
        if (actividades is null || actividades.Count == 0)
            return Publicar(new ResultadoVerificacion { Mensaje = "Sin actividades para verificar." });

        if (tiempoDisponibleHoras <= 0 || tiempoDisponibleHoras > 168)
            return Publicar(new ResultadoVerificacion { Mensaje = "Tiempo disponible inválido." });

        double total = actividades.Where(a => a.DuracionHoras > 0).Sum(a => a.DuracionHoras);
        double restante = tiempoDisponibleHoras - total;
        bool viable = restante >= 0;

        return Publicar(new ResultadoVerificacion
        {
            TotalActividades = actividades.Count,
            TiempoRequeridoHoras = Math.Round(total, 2),
            TiempoDisponibleHoras = tiempoDisponibleHoras,
            TiempoRestanteHoras = Math.Round(Math.Max(restante, 0), 2),
            EsViable = viable,
            Mensaje = viable
                ? "ITINERARIO VIABLE: el tiempo se ajusta."
                : $"EXCEDE EL TIEMPO por {Math.Round(-restante, 2)} h: reduce o quita actividades."
        });
    }

    private ResultadoVerificacion Publicar(ResultadoVerificacion r)
    {
        Verificado?.Invoke(r);
        return r;
    }
}
