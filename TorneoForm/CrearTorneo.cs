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
    public partial class CrearTorneo : Form
    {
        private Torneo torneo;
        public CrearTorneo(Torneo torneo)
        {
            InitializeComponent();
            this.torneo = torneo;

            cbxRitmoTorneo.DataSource = Enum.GetValues(typeof(RitmoTorneo));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            torneo.NombreTorneo = txtNombreTorneo.Text;
            torneo.FechaInicio = dtpFechaInicioTorneo.Value;
            torneo.FechaFinalizacion = dtpFechaFinalizacionTorneo.Value;
            torneo.Lugar = txtLugarTorneo.Text;
            torneo.FederacionClub = txtFederacionClub.Text;
            torneo.Ritmo = (RitmoTorneo)cbxRitmoTorneo.SelectedItem;
            torneo.EspecificacionesDelRitmo = txtEspecificacionesRitmo.Text;

            if (rbtnSistemaRoundRobin.Checked)
            {
                torneo.Sistema = SistemaTorneo.RoundRobin;
            }
            else if (rbtnSistemaSuizo.Checked)
            {
                torneo.Sistema = SistemaTorneo.Suizo;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("¿Está seguro que desea cancelar " +
                        "la creación del torneo?", 
                        "Confirmar cancelación", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);
            if (cancelar == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }

        }
    }
}
