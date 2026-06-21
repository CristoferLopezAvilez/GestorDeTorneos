using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ronda
    {
 
        public int NumeroDeRonda { get; }

        private readonly List<Partida> _partidas = new List<Partida>();

        public List<Partida> Partidas 
        {
            get
            {
                return _partidas;
            }
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
        public Ronda(int numeroDeRonda)
        {
            if (numeroDeRonda <= 0)
                throw new ArgumentException("El número de ronda debe ser mayor a cero.");

            NumeroDeRonda = numeroDeRonda;
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

            if (_partidas.Any(p => p.NumeroMesa == partida.NumeroMesa))
                throw new InvalidOperationException("Ya existe una partida en esa mesa.");

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
