using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// Genera todas las rondas de un torneo Round Robin usando el algoritmo
    /// de rotación de Berger (algoritmo del círculo).
    ///
    /// Reglas aplicadas:
    ///   - Si hay número impar de jugadores, se agrega un jugador BYE ficticio.
    ///     El jugador real que le toca contra BYE tiene la ronda libre.
    ///   - En cada ronda, el jugador en la posición 0 (ancla) es fijo;
    ///     los demás rotan en sentido horario una posición por ronda.
    ///   - Los colores se asignan por contador acumulado: el jugador con menos
    ///     veces de blancas toma ese color, minimizando el desequilibrio.
    /// </summary>
    internal class RoundRobinGenerator
    {
        private const int IdBye = -1;

        /// <summary>
        /// Genera todas las rondas del torneo Round Robin.
        /// </summary>
        /// <param name="jugadores">Lista de jugadores inscriptos. Mínimo 2.</param>
        /// <returns>Lista ordenada de rondas con sus partidas ya armadas.</returns>
        /// <exception cref="ArgumentNullException">Si jugadores es null.</exception>
        /// <exception cref="InvalidOperationException">Si hay menos de 2 jugadores.</exception>
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

            var vecesDeBlancos = slots.ToDictionary(j => j.Id, _ => 0);
            var rondas = new List<Ronda>();

            for (int nroRonda = 1; nroRonda <= cantidadRondas; nroRonda++)
            {
                var ronda = new Ronda(nroRonda);
                int mesa = 1;

                for (int i = 0; i < n / 2; i++)
                {
                    var jugadorA = slots[i];
                    var jugadorB = slots[n - 1 - i];

                    if (jugadorA.Id == IdBye || jugadorB.Id == IdBye)
                        continue;

                    var partida = CrearPartida(nroRonda, mesa, jugadorA, jugadorB, vecesDeBlancos);
                    ronda.AgregarPartida(partida);
                    mesa++;
                }

                rondas.Add(ronda);
                RotarSlots(slots);
            }

            return rondas;
        }

        /// <summary>
        /// Crea una partida asignando colores por contador acumulado:
        /// el jugador con menos veces de blancas toma ese color.
        /// En caso de empate, jugadorA toma blancas.
        /// </summary>
        private Partida CrearPartida(
            int nroRonda,
            int nroMesa,
            Jugador jugadorA,
            Jugador jugadorB,
            Dictionary<int, int> vecesDeBlancos)
        {
            var partida = new Partida(nroRonda, nroMesa);

            bool aJuegaDeBlancos = vecesDeBlancos[jugadorA.Id] <= vecesDeBlancos[jugadorB.Id];

            partida.JugadorBlancas = aJuegaDeBlancos ? jugadorA : jugadorB;
            partida.JugadorNegras = aJuegaDeBlancos ? jugadorB : jugadorA;

            vecesDeBlancos[partida.JugadorBlancas.Id]++;

            return partida;
        }

        /// <summary>
        /// Rotación de Berger: ancla fija en posición 0, el último sube a posición 1.
        /// Ejemplo: [A, B, C, D, E, F] → [A, F, B, C, D, E]
        /// </summary>
        private void RotarSlots(List<Jugador> slots)
        {
            if (slots.Count <= 2) return;

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