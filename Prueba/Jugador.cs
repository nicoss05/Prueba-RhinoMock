using System;

namespace Prueba
{
    public class Jugador : IJugador
    {
        public Jugador()
        {
        }
        public int PuntuacionTotal { get; set; }
        public int Bono { get; set; }

        public int CantidadPuntos(int CantidadPuntos)
        {
            return Bono + CantidadPuntos;
        }

        public double TotalPuntos()
        {
            return PuntuacionTotal;
        }

    }
}
