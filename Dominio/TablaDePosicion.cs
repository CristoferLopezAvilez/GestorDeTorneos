using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class TablaDePosicion
    {
        public int RondaRepresentada { get; private set; }
        private List<ItemTablaPosicion> _items { get; set; } = new List<ItemTablaPosicion>();

        public IReadOnlyList<ItemTablaPosicion> Items => _items;

        public void RecalcularTabla(List<Ronda> rondas)
        {
            if (rondas == null)
                throw new ArgumentNullException(nameof(rondas));

            if (!InicializarEstado(rondas))
                return;

            // Recolectar todas las partidas de las rondas provistas
            var partidas = rondas
                .SelectMany(r => r.ObtenerPartidas())
                .ToList();

            // Obtener jugadores únicos encontrados en las partidas
            var jugadores = partidas
                .SelectMany(p => new[] { p.JugadorBlancas, p.JugadorNegras })
                .Where(j => j != null)
                .GroupBy(j => j.Id)
                .Select(g => g.First())
                .ToList();

            // Crear items iniciales por jugador
            _items = jugadores
                .Select(j => new ItemTablaPosicion { Jugador = j })
                .ToList();

            ProcesarResultados(partidas);

            OrdenarTabla();
        }

        private void ProcesarResultados(List<Partida> partidas)
        {
            // Índice por Id para acceso rápido
            var itemsPorId = _items.ToDictionary(i => i.Jugador.Id);

            foreach (var partida in partidas)
            {
                if (!partida.TieneResultado())
                    continue;

                if (partida.JugadorBlancas != null &&
                    itemsPorId.TryGetValue(partida.JugadorBlancas.Id, out var itemBlancas))
                {
                    itemBlancas.AgregarResultado(partida);
                }

                if (partida.JugadorNegras != null &&
                    itemsPorId.TryGetValue(partida.JugadorNegras.Id, out var itemNegras))
                {
                    itemNegras.AgregarResultado(partida);
                }
            }
        }

        private void OrdenarTabla()
        {
            _items = _items
                .OrderByDescending(i => i.Puntos)
                .ThenByDescending(i => i.Victorias)
                .ThenByDescending(i => i.Empates)
                .ThenBy(i => i.Derrotas)
                .ThenBy(i => i.Jugador.NombreCompleto)
                .ToList();
        }

        private int ObtenerUltimaRondaConResultados(List<Ronda> rondas)
        {
            return rondas
                .Where(r => r.ObtenerPartidas().Any(p => p.TieneResultado()))
                .Select(r => r.NumeroDeRonda)
                .DefaultIfEmpty(0)
                .Max();
        }

        private bool InicializarEstado(List<Ronda> rondas)
        {
            // Si no hay rondas, limpiar tabla
            if (!rondas.Any())
            {
                RondaRepresentada = 0;
                _items.Clear();
                return false;
            }

            RondaRepresentada = ObtenerUltimaRondaConResultados(rondas);
            return true;
        }
    }
}
