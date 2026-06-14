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

        private Resultado? _resultado;

        public int NumeroMesa { get; private set; }
        public int NumeroDeRonda { get; private set; }

        public Partida(int numeroDeRonda, int numeroMesa)
        {
            NumeroDeRonda = numeroDeRonda;
            NumeroMesa = numeroMesa;
        }

        public void RegistrarResultado(Resultado resultado)
        {
           _resultado = resultado;
        }

        public bool TieneResultado()
        {
            return _resultado.HasValue;
        }

        public bool GanoBlancas()
        {
            return _resultado == Resultado.VictoriaBlanca;
        }

        public bool GanoNegras()
        {
            return _resultado == Resultado.VictoriaNegra;
        }

        public bool EsEmpate()
        {
            return _resultado == Resultado.Empate;
        }

       
        public double ObtenerResultado(Jugador jugador)
        {
            if (!TieneResultado())
                throw new InvalidOperationException("No tiene resultado");

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
    
