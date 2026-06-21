using Dominio;
using Xunit;

namespace DominioTesting
{
   
    public class RoundRobinGeneratorShould
    {
        [Fact]
        public void Generar_RondasCorrectas()
        {
            // Arrange
          var jugadores = new List<Jugador>
            {
                new Jugador { NombreCompleto = "A" },
                new Jugador { NombreCompleto = "B" },
                new Jugador { NombreCompleto = "C" },
                new Jugador { NombreCompleto = "D" }
            };
            // Act
            var rondas = RoundRobinGenerator.Generar(jugadores);
        }
        
    }
}
