using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum ResultadoEnum
    {
        VictoriaBlanca,
        VictoriaNegra,
        Empate
    }

    public class Partida
    {
        public int NumeroDeRonda { get; private set; }
        public int NumeroMesa { get; private set; }
        public Jugador JugadorBlancas { get; set; }
        public Jugador JugadorNegras { get; set; }

        private ResultadoEnum? _resultado;
        public ResultadoEnum? Resultado => _resultado;


        public Partida(int numeroDeRonda, int numeroMesa)
        {
            NumeroDeRonda = numeroDeRonda;
            NumeroMesa = numeroMesa;
        }

        public void RegistrarResultado(ResultadoEnum resultado)
        {
           _resultado = resultado;
        }

        public bool TieneResultado()
        {
            return _resultado.HasValue;
        }

        public bool GanoBlancas()
        {
            return _resultado == ResultadoEnum.VictoriaBlanca;
        }

        public bool GanoNegras()
        {
            return _resultado == ResultadoEnum.VictoriaNegra;
        }

        public bool EsEmpate()
        {
            return _resultado == ResultadoEnum.Empate;
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
    
