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
    public partial class DatosDeUnJugador : Form
    {
        private Torneo torneo;
        private ItemTablaPosicion itemTablaPosicion;
        private int jugadorId;

        public DatosDeUnJugador(Torneo torneo, ItemTablaPosicion itemTablaPosicion, int jugadorId)
        {
         
            InitializeComponent();
            this.torneo = torneo;
            this.itemTablaPosicion = itemTablaPosicion;
            this.jugadorId = jugadorId;
        }

        private void DatosDeUnJugador_Load(object sender, EventArgs e)
        {
            Jugador jugador = torneo.Jugadores
     .FirstOrDefault(j => j.Id == jugadorId);

            if (jugador == null)
                return;

            txtNombreCompleto.Text = jugador.NombreCompleto;
            txtId.Text = jugador.Id.ToString();
            txtCategoria.Text = jugador.Categoria;
            txtClub.Text = jugador.Club;

          
            if (itemTablaPosicion != null)
            {
                txtPuntos.Text = itemTablaPosicion.Puntos.ToString();
                txtPuesto.Text = itemTablaPosicion.Puesto.ToString();
            }
            else
            {
                txtPuntos.Text = "";
                txtPuesto.Text = "";
            }
        }
    }
}
