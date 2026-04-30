using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Torneo
    {

      
        public Guid Id { get; set; }

        public string NombreTorneo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }

        public RitmoTorneo Ritmo { get; set; }

        public List<Jugador> Jugadores { get; set; } = new List<Jugador>();

        private readonly List<Ronda> _rondas = new List<Ronda>();
        public IReadOnlyList<Ronda> Rondas => _rondas;

        public TablaDePosicion TablaDePosicion { get; set; }

        public EstadoTorneo Estado
        {
            get
            {
                if (_rondas.Count == 0)
                    return EstadoTorneo.TorneoSinCrear;

                if (RondaActual == CantidadRondas &&
                    _rondas.All(r => r.EstadoRonda == Ronda.Estado.RondaFinalizada))
                {
                    return EstadoTorneo.TorneoFinalizado;
                }

                return EstadoTorneo.TorneoEnCurso;
            }
        }

        public int RondaActual { get; private set; } = 0;

        public int CantidadRondas { get; set; }
        public string Lugar { get; set; }

        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        public void AgregarRonda(Ronda ronda)
        {
            _rondas.Add(ronda);
        }

        public void IniciarTorneo()
        {
            if (Jugadores.Count > 2)
            {
                GenerarTodasLasRondas();
            }
            else
            {
                throw new Exception("No hay suficientes jugadores");
            }
        }

        public void GenerarTodasLasRondas()
        {
            RoundRobinGenerator roundRobinGenerator = new RoundRobinGenerator();
        }

        public void RegistrarResultado(int numeroRonda, int numeroMesa, Resultado resultado)
        {
            var ronda = _rondas.FirstOrDefault(r => r.NumeroRonda == numeroRonda);

            if (ronda == null)
                throw new Exception("Ronda no encontrada");

            var partida = ronda.BuscarPartidaPorMesa(numeroMesa);

            if (partida == null)
                throw new Exception("Partida no encontrada");

            partida.RegistrarResultado(resultado);
        }

        public TablaDePosicion ObtenerTablaFinal()
        {
            if (Estado != EstadoTorneo.TorneoFinalizado)
                throw new InvalidOperationException("El torneo aún no ha finalizado.");

            return TablaDePosicion;

        }

        public TablaDePosicion ObtenerTablaRonda()
        {
            if (Estado == EstadoTorneo.TorneoSinCrear)
                throw new InvalidOperationException("El torneo aún no ha sido creado");

            if (RondaActual == 0)
                throw new InvalidOperationException("El torneo no ha comenzado");

            var rondaActual = _rondas[RondaActual - 1];

            if (!rondaActual.TerminoRonda())
                throw new InvalidOperationException("La ronda no ha finalizado");

            return TablaDePosicion;

        }

        public int ObtenerRondaActual()
        {
            return RondaActual;
        }

        public void FinalizarTorneo()
        {

            if (Estado != EstadoTorneo.TorneoFinalizado)
                throw new InvalidOperationException("El torneo aún no ha finalizado");

            // Acá podrías hacer lógica de dominio más adelante
        }

        public void PasarASiguienteRonda()
        {
            if (RondaActual == 0)
                throw new InvalidOperationException("El torneo no ha comenzado");

            var rondaActual = _rondas[RondaActual - 1];

            if (!rondaActual.TerminoRonda())
                throw new InvalidOperationException("La ronda actual no ha finalizado");

            if (RondaActual < CantidadRondas)
            {
                RondaActual += 1;
            }
        }
     
       
    }

    public enum EstadoTorneo
    {
        TorneoSinCrear,
        TorneoEnCurso,
        TorneoFinalizado
    }

    public enum RitmoTorneo
    {
        Bullet,
        Blitz,
        Rapid,
        Clasico
    }


}
