using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Ronda
    {
 
        public int NumeroRonda { get; }

        private readonly List<Partida> _partidas = new List<Partida>();

        public Ronda(int numeroRonda)
        {
            if (numeroRonda <= 0)
                throw new ArgumentException("El número de ronda debe ser mayor a cero.");

            NumeroRonda = numeroRonda;
        }

        public Estado EstadoRonda
        {
            get
            {
                if (!_partidas.Any())
                    return Estado.RondaNoCreada;

                if (TerminoRonda())
                    return Estado.RondaFinalizada;

                return Estado.RondaEnCurso;
            }
        }

        public enum Estado
        {
            RondaNoCreada,
            RondaEnCurso,
            RondaFinalizada
        }

        public void AgregarPartida(Partida partida)
        {
            if (partida == null)
                throw new ArgumentNullException(nameof(partida));

            if (EstadoRonda == Estado.RondaFinalizada)
                throw new InvalidOperationException("No se pueden agregar partidas a una ronda finalizada.");

            _partidas.Add(partida);
        }

        public IReadOnlyList<Partida> ObtenerPartidas()
        {
            return _partidas;
        }

        public Partida BuscarPartidaPorMesa(int numeroMesa)
        {
            return _partidas.FirstOrDefault(p => p.NumeroMesa == numeroMesa);
        }

        public bool TerminoRonda()
        {
            return _partidas.Any() && _partidas.All(p => p.TieneResultado());
        }




    }
}
