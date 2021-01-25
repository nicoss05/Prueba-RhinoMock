using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Level
    {
            public Level()
            {
            }

            public int Bono { get; internal set; }
            public bool Sipaso { get; internal set; }

        internal void Avanzar(IJugador jugador)
            {
                if (jugador.TotalPuntos() >= 0.8)
                {
                    jugador.CantidadPuntos(this.Bono);
                    this.Sipaso = true;
                }
                else
                {
                    this.Sipaso = false;
                }

            }
    }
}
