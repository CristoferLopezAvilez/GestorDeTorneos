using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Jugador
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Categoria { get; set; }
        public string Club { get; set; }

        // Se requiere una instancia de Torneo para acceder a sus miembros no estáticos.
        public void IdDelJugador(Torneo torneo)
        {
            // Ejemplo de cómo acceder a la lista de jugadores de un torneo específico
            foreach (var item in torneo.Jugadores)
            {
                // Lógica aquí
            }
        }
    }
}
