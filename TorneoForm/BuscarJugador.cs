using System;
using Dominio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneoForm
{
    public partial class BuscarJugador : Form
    {
        private Torneo torneo;
        private ItemTablaPosicion itemTablaPosicion;
        public BuscarJugador(Torneo torneo)
        {
            InitializeComponent();

            this.torneo = torneo;
        }

        private void btnBuscarJugador_Click(object sender, EventArgs e)
        {
            string cadenaBusqueda = txtBuscarJugador.Text.ToLower();
            foreach (Jugador jugador in torneo.Jugadores)
            {
                if (jugador.NombreCompleto.ToLower().Contains(cadenaBusqueda))
                {

                    DatosDeUnJugador datosDeUnJugadorForm = new DatosDeUnJugador(torneo, itemTablaPosicion, jugador.Id);
                    datosDeUnJugadorForm.Show();
                    
                }
              
            }
           
        }
    }
}
