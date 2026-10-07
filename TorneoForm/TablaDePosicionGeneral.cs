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
    public partial class TablaDePosicionGeneral : Form
    {
        private Torneo torneo;
        public TablaDePosicionGeneral(Torneo torneo)
        {
            this.torneo = torneo;
            InitializeComponent();


            dgvTablaDePosiciones.AutoGenerateColumns = false;
            dgvTablaDePosiciones.Columns.Clear();

           /* dgvTablaDePosiciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id"
            });*/

            dgvTablaDePosiciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Puesto",
                HeaderText = "Puesto",
                DataPropertyName = "Puesto"
            });

            dgvTablaDePosiciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreCompleto",
                HeaderText = "Nombre Completo",
                DataPropertyName = "NombreCompleto"
            });

            dgvTablaDePosiciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Categoria",
                HeaderText = "Categoría",
                DataPropertyName = "Categoria"
            });

            dgvTablaDePosiciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Club",
                HeaderText = "Club",
                DataPropertyName = "Club"
            });

            dgvTablaDePosiciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Puntos",
                HeaderText = "Puntos",
                DataPropertyName = "Puntos",
                DefaultCellStyle = { Format = "N1" }
            });

            dgvTablaDePosiciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PartidasJugadas",
                HeaderText = "Partidas Jugadas",
                DataPropertyName = "PartidasJugadas"
            });

            dgvTablaDePosiciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Victorias",
                HeaderText = "Victorias",
                DataPropertyName = "Victorias"
            });

            dgvTablaDePosiciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Empates",
                HeaderText = "Empates",
                DataPropertyName = "Empates"
            });

            dgvTablaDePosiciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Derrotas",
                HeaderText = "Derrotas",
                DataPropertyName = "Derrotas"
            });
        }

        private void TablaDePosicionGeneral_Load(object sender, EventArgs e)
        {
            lblNombreTorneoTablaDePosicionGeneral.Text = $"Nombre del Torneo: {torneo.NombreTorneo}";
            lblFederacionTablaDePosicionGeneral.Text = $"Federación/Club: {torneo.FederacionClub}";
            lblLugarTablaDePosicionGeneral.Text = $"Lugar: {torneo.Lugar}";
            lblRitmoTablaDePosicionGeneral.Text = $"Ritmo del Torneo: {torneo.Ritmo}";
            lblSistemaTablaDePosicionGeneral.Text = $"Sistema del Torneo: {torneo.Sistema}";
            lblFechaInicioTablaDePosicionGeneral.Text = $"Fecha de Inicio: {torneo.FechaInicio.ToShortDateString()}";
            lblFechaFinalizacionTablaDePosicionGeneral.Text = $"Fecha de Finalización:{torneo.FechaFinalizacion.ToShortDateString()}";

            MostrarPosiciones_dgvTablaDePosiciones();

        }

        private void MostrarPosiciones_dgvTablaDePosiciones()
        {
            var tablaDePosiciones = torneo.ObtenerTablaPosicion();
            dgvTablaDePosiciones.DataSource = tablaDePosiciones;

        }

      
    }
}
