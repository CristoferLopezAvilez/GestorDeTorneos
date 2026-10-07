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
        private int indiceJugadorActual = -1;
        private bool navegandoJugadores = false;
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

        private void MostrarJugadorActual()
        {
            Jugador jugador = torneo.Jugadores[indiceJugadorActual];

            txtNombreCompletoAgregarJugadores.Text = jugador.NombreCompleto;
            txtCategoriaAgregarJugadores.Text = jugador.Categoria;
            txtClubAgregarJugadores.Text = jugador.Club;

            this.Text = $"Agregar jugadores - ID: {jugador.Id} - {jugador.NombreCompleto}";
        }
        private void btnAnteriorAgregarJugadores_Click(object sender, EventArgs e)
        {
            if (torneo.Jugadores.Count == 0)
                return;

           
            if (!navegandoJugadores)
            {
                indiceJugadorActual = torneo.Jugadores.Count - 1;
                navegandoJugadores = true;
            }
            else
            {
                if (indiceJugadorActual > 0)
                {
                    indiceJugadorActual--;
                }
                else
                {
                    MessageBox.Show("No hay jugadores anteriores.");
                    return;
                }
            }

            MostrarJugadorActual();
        }

        private void btnSiguienteAgregarJugadores_Click(object sender, EventArgs e)
        {
            if (torneo.Jugadores.Count == 0)
                return;

            if (indiceJugadorActual < torneo.Jugadores.Count)
            {
                indiceJugadorActual++;
            }

            if (indiceJugadorActual == torneo.Jugadores.Count)
            {
                LimpiarFormulario();
                this.Text = "Agregar jugadores - Nuevo jugador";
                navegandoJugadores = false;
            }
            else
            {
                MostrarJugadorActual();
                navegandoJugadores = true;
            }
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
