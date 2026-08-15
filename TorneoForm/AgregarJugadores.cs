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
    public partial class AgregarJugadores : Form
    {
        
        private Torneo torneo;
        public AgregarJugadores(Torneo torneo)
        {
            InitializeComponent();
            this.torneo = torneo;
        }

        private void GuardarJugador()
        {
            Jugador jugador = new Jugador
            {
                NombreCompleto = txtNombreCompletoAgregarJugadores.Text,
                Categoria = txtCategoriaAgregarJugadores.Text,
                Club = txtClubAgregarJugadores.Text
            };

            torneo.AgregarJugador(jugador);
        }
        private void btnAnteriorAgregarJugadores_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguienteAgregarJugadores_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAgregarJugadores_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnAceptarAgregarJugadores_Click(object sender, EventArgs e)
        {
            GuardarJugador();
            LimpiarFormulario();

        }

        private void btnFinalizarAgregarJugadores_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarFormulario()
        {
            txtNombreCompletoAgregarJugadores.Clear();
            txtCategoriaAgregarJugadores.Clear();
            txtClubAgregarJugadores.Clear();

            txtNombreCompletoAgregarJugadores.Focus();
        }

     
    }
}
