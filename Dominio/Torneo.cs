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

      
        public Guid Id { get; }

        public string NombreTorneo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }

        public RitmoTorneo Ritmo { get; set; }

        private readonly List<Jugador> _jugadores = new List<Jugador>();

        public IReadOnlyList<Jugador> Jugadores => _jugadores;
       
        private readonly List<Ronda> _rondas = new List<Ronda>();
        public IReadOnlyList<Ronda> Rondas => _rondas;



        public EstadoTorneo Estado
        {
            get
            {
                if (!_rondas.Any())
                    return EstadoTorneo.TorneoNoIniciado;

                if (_rondas.Count == CantidadRondas &&
                    _rondas.All(r => r.EstadoRonda == Ronda.Estado.RondaFinalizada))
                {
                    return EstadoTorneo.TorneoFinalizado;
                }

                return EstadoTorneo.TorneoEnCurso;
            }
        }

        public int CantidadRondas { get; private set; }
        public string Lugar { get; set; }

        public Torneo()
        {
            Id = Guid.NewGuid();
        }

        public void AgregarJugador(Jugador jugador)
        {
            if (jugador == null)
                throw new ArgumentNullException(nameof(jugador));

            if (Estado != EstadoTorneo.TorneoNoIniciado)
                throw new InvalidOperationException(
                    "No se pueden agregar jugadores una vez iniciado el torneo.");

            if (_jugadores.Any(j => j.Id == jugador.Id))
                throw new InvalidOperationException(
                    "El jugador ya está registrado.");

            _jugadores.Add(jugador);
        }

        // Guardo este método para el futuro, cuando se implemente el sistema suizo,
        // para permitir registrar rondas manualmente en caso de ser necesario.
        public void RegistrarRonda(Ronda ronda)
        {
            if (ronda == null)
                throw new ArgumentNullException(nameof(ronda));

            _rondas.Add(ronda);
        }

        public void IniciarTorneo()
        {
            if (Jugadores.Count < 2)
                throw new Exception("No hay suficientes jugadores");

            GenerarTodasLasRondas();

            
        }

        public void GenerarTodasLasRondas()
        {
            RoundRobinGenerator roundRobinGenerator = new RoundRobinGenerator();
        }

        public void RegistrarResultado(int numeroRonda, int numeroMesa, Resultado resultado)
        {
            var ronda = _rondas.FirstOrDefault(r => r.NumeroDeRonda == numeroRonda);

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

           return ObtenerTablaPosicion();

        }

        public TablaDePosicion ObtenerTablaPosicion()
        {
            var tabla = new TablaDePosicion();
            tabla.RecalcularTabla(_rondas);

            return tabla;
        }

        public IReadOnlyList<Jugador> ObtenerJugadoresOrdenados()
        {
            return Jugadores
                .OrderBy(j => j.NombreCompleto)
                .ToList();
        }      

        public void FinalizarTorneo()
        {

            if (Estado != EstadoTorneo.TorneoFinalizado)
                throw new InvalidOperationException("El torneo aún no ha finalizado");

            // Acá podrías hacer lógica de dominio más adelante
        }       

        public int ObtenerNumeroRondaActual()
        {
            if (!_rondas.Any())
                return 0;

            var rondaActiva = _rondas
                .FirstOrDefault(r => r.EstadoRonda != Ronda.Estado.RondaFinalizada);

            return rondaActiva?.NumeroDeRonda ?? CantidadRondas;
        }


    }

    public enum EstadoTorneo
    {
        TorneoNoIniciado,
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
