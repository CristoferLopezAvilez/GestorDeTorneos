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
        public Jugador JugadorBlancas {  get; set; }
        public Jugador JugadorNegras { get; set; }
        private Resultado? resultado;
        
        public int NumeroMesa { get; set; }

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

      
        public (double blancas, double negras) ObtenerPuntos()
        {
            if (!TieneResultado())
                throw new InvalidOperationException("No se puede calcular puntos sin resultado.");

            if (GanoBlancas())
                return (1, 0);

            if (GanoNegras())
                return (0, 1);

            return (0.5, 0.5);
        }


    }
}
