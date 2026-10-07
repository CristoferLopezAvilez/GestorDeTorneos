using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Jugador
    {
        private static int _ultimoId = 0;

        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Categoria { get; set; }
        public string Club { get; set; }

        public Jugador()
        {
            Id = ++_ultimoId;
        }
    }
}
