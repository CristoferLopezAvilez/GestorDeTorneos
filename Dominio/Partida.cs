using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    enum Resultado
    {
        VictoriaBlanca,
        VictoriaNegra,
        Empate
    }

    internal class Partida
    {
        public Jugador JugadorBlancas { get; set; }
        public Jugador JugadorNegras { get; set; }

        private Resultado? resultado;

        public int NumeroMesa { get; private set; }
        public int NumeroRonda { get; private set; }

        public Partida(int numeroRonda, int numeroMesa)
        {
            NumeroRonda = numeroRonda;
            NumeroMesa = numeroMesa;
        }

        public void RegistrarResultado(Resultado resultado)
        {
           this.resultado = resultado;
        }

        public bool TieneResultado()
        {
            return resultado.HasValue;
        }

        public bool GanoBlancas()
        {
            return resultado == Resultado.VictoriaBlanca;
        }

        public bool GanoNegras()
        {
            return resultado == Resultado.VictoriaNegra;
        }

        public bool EsEmpate()
        {
            return resultado == Resultado.Empate;
        }

       
        public double ObtenerPuntos(Jugador jugador)
        {
            if (!TieneResultado())
                throw new InvalidOperationException("No se puede calcular puntos sin resultado.");

            if (EsEmpate())
                return 0.5;

            if (JugadorBlancas.Id == jugador.Id && GanoBlancas())
                return 1;

            if (JugadorNegras.Id == jugador.Id && GanoNegras())
                return 1;

            return 0;
        }
    }
}
    
