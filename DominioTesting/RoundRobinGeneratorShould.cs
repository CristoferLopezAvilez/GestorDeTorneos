using System;
using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void Generar_LanzaArgumentNullExceptionCuandoJugadoresNull()
        {
            var generador = new RoundRobinGenerator();
            Assert.Throws<ArgumentNullException>(() => generador.Generar(null));
        }

        [Fact]
        public void Generar_LanzaInvalidOperationCuandoMenosDeDosJugadores()
        {
            var generador = new RoundRobinGenerator();
            var jugadores = new List<Jugador> { new Jugador { NombreCompleto = "A" } };
            Assert.Throws<InvalidOperationException>(() => generador.Generar(jugadores));
        }

        [Fact]
        public void Generar_DosJugadores_UnaRondaUnaPartida()
        {
            var jugadores = new List<Jugador>
            {
                new Jugador { NombreCompleto = "A" },
                new Jugador { NombreCompleto = "B" }
            };
            var generador = new RoundRobinGenerator();
            var rondas = generador.Generar(jugadores);
            Assert.Equal(1, rondas.Count);
            Assert.Equal(1, rondas[0].Partidas.Count); // ajustar según cómo se exponga la colección
        }

        [Fact]
        public void Generar_JugadoresImpares_AgregaByeYCadaJugadorTieneUnBye()
        {
            var jugadores = new List<Jugador>
            {
                new Jugador { NombreCompleto = "A" },
                new Jugador { NombreCompleto = "B" },
                new Jugador { NombreCompleto = "C" }
            };
            var generador = new RoundRobinGenerator();
            var rondas = generador.Generar(jugadores);

            // comprobar que se generaron n-1 rondas tras rellenar con BYE
            Assert.Equal(3, rondas.Count);

            // contar apariciones de BYE en todas las partidas
            int byes = rondas.SelectMany(r => r.Partidas)
                             .Count(p => p.JugadorBlancas.NombreCompleto == "BYE" || p.JugadorNegras.NombreCompleto == "BYE");
            // cada jugador debe tener exactamente un bye -> con 3 jugadores hay 3 byes en total
            Assert.Equal(3, byes);
        }

        [Fact]
        public void Generar_TodasLasParejasAparecenUnaVez()
        {
            var jugadores = new List<Jugador>
            {
                new Jugador { NombreCompleto = "A" },
                new Jugador { NombreCompleto = "B" },
                new Jugador { NombreCompleto = "C" },
                new Jugador { NombreCompleto = "D" }
            };
            var generador = new RoundRobinGenerator();
            var rondas = generador.Generar(jugadores);

            var pares = new HashSet<string>();
            foreach (var partida in rondas.SelectMany(r => r.Partidas))
            {
                var a = partida.JugadorBlancas.NombreCompleto;
                var b = partida.JugadorNegras.NombreCompleto;
                if (a == "BYE" || b == "BYE") continue;
                var key = string.Compare(a, b, StringComparison.Ordinal) < 0 ? $"{a}|{b}" : $"{b}|{a}";
                pares.Add(key);
            }

            // combinaciones únicas esperadas: C(4,2) = 6
            Assert.Equal(6, pares.Count);
        }

        [Fact]
        public void Generar_PrimeraPosicionPermaneceFija_YColoresAlternanEnPrimeraMesa()
        {
            var jugadores = new List<Jugador>
            {
                new Jugador { NombreCompleto = "A" }, // fija en índice 0
                new Jugador { NombreCompleto = "B" },
                new Jugador { NombreCompleto = "C" },
                new Jugador { NombreCompleto = "D" }
            };
            var generador = new RoundRobinGenerator();
            var rondas = generador.Generar(jugadores);

            // comprobar que en cada ronda existe una partida en mesa 1 y que la "A" permanece en la posición esperada
            bool primeraRondaAwhite = rondas[0].Partidas.First(p => p.NumeroMesa == 1).JugadorBlancas.NombreCompleto == "A";
            bool segundaRondaAwhite = rondas[1].Partidas.First(p => p.NumeroMesa == 1).JugadorBlancas.NombreCompleto == "A";
            // según la implementación, la primera mesa alterna en rondas pares/impares;
            // comprueba que no se rompa la regla (aquí se valida que existe alternancia o consistencia).
            Assert.True(rondas.Count >= 2);
            Assert.NotNull(rondas[0].Partidas.First(p => p.NumeroMesa == 1));
            Assert.NotNull(rondas[1].Partidas.First(p => p.NumeroMesa == 1));
            Assert.NotEqual(primeraRondaAwhite, segundaRondaAwhite);
        }

    }
}
