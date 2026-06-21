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

            var generador = new RoundRobinGenerator();

            // Act
            List<Ronda> rondas = generador.Generar(jugadores);

            // Assert
            Assert.Equal(3, rondas.Count);
        }
    }
}
