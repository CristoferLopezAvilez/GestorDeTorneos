using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// Genera todas las rondas de un torneo Round Robin utilizando
    /// el algoritmo Berger (Circle Method).
    ///
    /// Si la cantidad de jugadores es impar se agrega un jugador BYE.
    /// Los colores se asignan siguiendo las tablas Berger oficiales.
    /// </summary>
    internal class RoundRobinGenerator
    {
        private const int IdBye = -1;

        public List<Ronda> Generar(IReadOnlyList<Jugador> jugadores)
        {
            if (jugadores == null)
                throw new ArgumentNullException(nameof(jugadores));

            if (jugadores.Count < 2)
                throw new InvalidOperationException(
                    "Se requieren al menos dos jugadores.");

            var slots = jugadores.ToList();

            if (slots.Count % 2 != 0)
                slots.Add(CrearJugadorBye());

            int n = slots.Count;
            int cantidadRondas = n - 1;

            var rondas = new List<Ronda>();

            for (int nroRonda = 1; nroRonda <= cantidadRondas; nroRonda++)
            {
                var ronda = new Ronda(nroRonda);
                int mesa = 1;

                for (int i = 0; i < n / 2; i++)
                {
                    var jugadorA = slots[i];
                    var jugadorB = slots[n - 1 - i];

                    var partida = CrearPartida(
                        nroRonda,
                        mesa,
                        i,
                        jugadorA,
                        jugadorB);

                    ronda.AgregarPartida(partida);
                    mesa++;
                }

                rondas.Add(ronda);
                RotarSlots(slots);
            }

            return rondas;
        }

        private Partida CrearPartida(
            int nroRonda,
            int nroMesa,
            int indiceMesa,
            Jugador jugadorA,
            Jugador jugadorB)
        {
            var partida = new Partida(nroRonda, nroMesa);

            bool primeraMesa = indiceMesa == 0;

            if (primeraMesa && nroRonda % 2 == 0)
            {
                partida.JugadorBlancas = jugadorB;
                partida.JugadorNegras = jugadorA;
            }
            else
            {
                partida.JugadorBlancas = jugadorA;
                partida.JugadorNegras = jugadorB;
            }

            return partida;
        }

        /// <summary>
        /// Rotación Berger:
        /// [A, B, C, D, E, F]
        /// ->
        /// [A, F, B, C, D, E]
        /// </summary>
        private void RotarSlots(List<Jugador> slots)
        {
            if (slots.Count <= 2)
                return;

            var ultimo = slots[slots.Count - 1];

            slots.RemoveAt(slots.Count - 1);
            slots.Insert(1, ultimo);
        }

        private Jugador CrearJugadorBye()
        {
            return new Jugador
            {
                Id = IdBye,
                NombreCompleto = "BYE",
                Categoria = string.Empty,
                Club = string.Empty
            };
        }
    }
}