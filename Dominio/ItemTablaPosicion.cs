using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class ItemTablaPosicion
    {
        public Jugador Jugador { get; set; }
        public int PartidasJugadas { get; set; }
        public int Victorias { get; set; }
        public int Empates { get; set; }
        public int Derrotas { get; set; }

        public double Puntos => Victorias + Empates * 0.5;

        public void AgregarResultado(Partida partida)
        {
            if (partida.JugadorBlancas.Id != Jugador.Id &&
         partida.JugadorNegras.Id != Jugador.Id)
                return;

            PartidasJugadas++;

            double puntos = partida.ObtenerPuntos(Jugador);

            if (puntos == 1)
                Victorias++;
            else if (puntos == 0.5)
                Empates++;
            else
                Derrotas++;
        }
    }
}
