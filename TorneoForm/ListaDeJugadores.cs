using Dominio;
using System;
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
    public partial class ListaDeJugadores : Form
    {
        private Torneo torneo;
        private ItemTablaPosicion itemTablaPosicion;
        private List<Jugador> jugadoresEditados = new List<Jugador>();
        public ListaDeJugadores(Torneo torneo)
        {
            this.torneo = torneo;
            InitializeComponent();
         

            dgvListaDeJugadores.ReadOnly = true;
        }

        private void btnEditarListaDeJugadores_Click(object sender, EventArgs e)
        {

            CrearCopiaDeJugadores();

            dgvListaDeJugadores.ReadOnly = false;
            dgvListaDeJugadores.DataSource = null;
            dgvListaDeJugadores.DataSource = jugadoresEditados;

        }

        private void btnCancelarListaDeJugadores_Click(object sender, EventArgs e)
        {
           CargarJugadores();
           dgvListaDeJugadores.ReadOnly = true;
        }

        private void btnGuardarListaDeJugadores_Click(object sender, EventArgs e)
        {
            dgvListaDeJugadores.EndEdit();

            torneo.ActualizarJugadores(jugadoresEditados);

            dgvListaDeJugadores.ReadOnly = true;

            CargarJugadores();
        }

      
        private void ListaDeJugadores_Load(object sender, EventArgs e)
        {
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            dgvListaDeJugadores.DataSource = null;
            dgvListaDeJugadores.DataSource = torneo.Jugadores;
        }
        private void CrearCopiaDeJugadores()
        {
            jugadoresEditados = torneo.Jugadores
                .Select(j => new Jugador
                {
                    Id = j.Id,
                    NombreCompleto = j.NombreCompleto,
                    Categoria = j.Categoria,
                    Club = j.Club
                })
                .ToList();
        }

        private void VerDatosDeUnJugador_Click(object sender, EventArgs e)
        {
            if (dgvListaDeJugadores.CurrentRow == null)
                return;

            int jugadorId = (int)dgvListaDeJugadores.CurrentRow.Cells["Id"].Value;

            ItemTablaPosicion itemTablaPosicion = torneo.ObtenerTablaPosicion()
                .FirstOrDefault(i => i.Jugador.Id == jugadorId);

           
            DatosDeUnJugador datosDeUnJugadorForm =
                new DatosDeUnJugador(torneo, itemTablaPosicion, jugadorId);

            datosDeUnJugadorForm.ShowDialog();
        }
    }
}
