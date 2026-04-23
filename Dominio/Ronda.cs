using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Ronda
    {
        //Tal vez faltan métodos como:
        //BuscarPartidaPorMesa(numeroMesa)  
        //BuscarPartidaPorJugador(Jugador)
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
                    return Estado.NoCreada;
                if (TerminoRonda())
                    return Estado.Finalizada;
                return Estado.EnCurso;
            }
        }

        public enum Estado
        {
            NoCreada,
            EnCurso,
            Finalizada
        }

        public void AgregarPartida(Partida partida)
        {
            if (partida == null)
                throw new ArgumentNullException(nameof(partida)); 
            if (EstadoRonda == Estado.Finalizada)
                throw new InvalidOperationException("No se pueden agregar partidas a una ronda finalizada.");
            _partidas.Add(partida);
        }

        public IReadOnlyList<Partida> ObtenerPartidas()  
        {
            if (!_partidas.Any())
                throw new InvalidOperationException("No hay partidas creadas."); 
            return _partidas;
        }

        public bool TerminoRonda()
        {
            return _partidas.Any() && _partidas.All(p => p.TieneResultado());
        }
    




    }
}
