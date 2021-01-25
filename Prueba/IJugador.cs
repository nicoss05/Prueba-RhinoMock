namespace Prueba
{
    public interface IJugador
    {
        int PuntuacionTotal { get; set; }

        int CantidadPuntos(int CantidadPuntos);
        double TotalPuntos();
    }
}