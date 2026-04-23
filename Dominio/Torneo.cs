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
        public List<Ronda> Rondas { get; set; } = new List<Ronda>();

        public TablaDePosicion TablaDePosicion { get; set; }

        public EstadoTorneo Estado { get; set; }

        public int RondaActual { get; set; }

        public int CantidadRondas { get; set; }
        public string Lugar { get; set; }
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
