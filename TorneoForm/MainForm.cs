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
    public partial class MainForm : Form
    {
        private Torneo torneo = new Torneo();
        public MainForm()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn columnaMesa =
            new DataGridViewTextBoxColumn();

            columnaMesa.Name = "Mesa";
            columnaMesa.HeaderText = "Mesa";

            dgvMain.Columns.Add(columnaMesa);


            DataGridViewTextBoxColumn columnaBlancas =
                new DataGridViewTextBoxColumn();

            columnaBlancas.Name = "Blancas";
            columnaBlancas.HeaderText = "Blancas";

            dgvMain.Columns.Add(columnaBlancas);


            DataGridViewTextBoxColumn columnaNegras =
                new DataGridViewTextBoxColumn();

            columnaNegras.Name = "Negras";
            columnaNegras.HeaderText = "Negras";

            dgvMain.Columns.Add(columnaNegras);


            DataGridViewComboBoxColumn columnaResultado =
                new DataGridViewComboBoxColumn();

            columnaResultado.Name = "Resultado";
            columnaResultado.HeaderText = "Resultado";
            columnaResultado.Items.Add("VictoriaBlanca");
            columnaResultado.Items.Add("VictoriaNegra");
            columnaResultado.Items.Add("Empate");

            dgvMain.Columns.Add(columnaResultado);
        }

        private void btnCargarResultados_Click(object sender, EventArgs e)
        {
            CargaDeResultados();
        }

        private void btnMostrarTodasLasRondas_Click(object sender, EventArgs e)
        {
            AbrirMostrarTodasLasRondas();

        }

        private void btnTablaDePosicion_Click(object sender, EventArgs e)
        {
            TablaDePosicionGeneral tablaDePosicionGeneralForm = new TablaDePosicionGeneral();
            tablaDePosicionGeneralForm.ShowDialog();
        }

        private void btnRondaSiguienteMain_Click(object sender, EventArgs e)
        {

        }

        private void btnRondaAnteriorMain_Click(object sender, EventArgs e)
        {

        }
        private void MostrarRonda(Ronda ronda)
        {
            dgvMain.Rows.Clear();

            foreach (Partida partida in ronda.ObtenerPartidas())
            {
                int fila = dgvMain.Rows.Add();

                dgvMain.Rows[fila].Cells["Mesa"].Value =
                    partida.NumeroMesa;

                dgvMain.Rows[fila].Cells["Blancas"].Value =
                    partida.JugadorBlancas.NombreCompleto;

                dgvMain.Rows[fila].Cells["Negras"].Value =
                    partida.JugadorNegras.NombreCompleto;

                dgvMain.Rows[fila].Tag = partida;
            }
        }
        private void btnIniciarTorneoMain_Click(object sender, EventArgs e)
        {
            if (torneo.Estado == EstadoTorneo.TorneoNoIniciado)
            {
                torneo.IniciarTorneo();

                var ronda = torneo.Rondas
                    .FirstOrDefault(r => r.NumeroDeRonda == 1);

                MostrarRonda(ronda);
            }
            else if (torneo.Estado == EstadoTorneo.TorneoEnCurso)
            {
                MessageBox.Show("El torneo ya ha sido iniciado.");
            }
            else if (torneo.Estado == EstadoTorneo.TorneoFinalizado)
            {
                MessageBox.Show("El torneo ya ha finalizado.");
            }
        }

         private void dgvMain_CellValueChanged(
        object sender,
        DataGridViewCellEventArgs e)
            {
            if (e.RowIndex < 0)
                return;

            if (dgvMain.Columns[e.ColumnIndex].Name != "Resultado")
                return;

            Partida partida =
                (Partida)dgvMain.Rows[e.RowIndex].Tag;

            string valor =
                dgvMain.Rows[e.RowIndex]
                    .Cells["Resultado"].Value.ToString();

            Resultado resultado =
                (Resultado)Enum.Parse(typeof(Resultado), valor);

            partida.RegistrarResultado(resultado);

        }
        private void dgvMain_CurrentCellDirtyStateChanged(
         object sender,
         EventArgs e)
            {
                 if (dgvMain.IsCurrentCellDirty)
                {
                    dgvMain.CommitEdit(
                        DataGridViewDataErrorContexts.Commit);
                }
            }

        private void nuevoTorneoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearTorneo crearTorneoForm = new CrearTorneo();
            crearTorneoForm.ShowDialog();


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "Si cierra la ventana se perderán todos los datos.",
            "Advertencia",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning);

               if (resultado == DialogResult.OK)
                {
                    this.Close();
                }
        }

        private void datosDelTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void configuraciónDelTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iniciarTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarJugadores agregarJugadoresForm = new AgregarJugadores(torneo);
            agregarJugadoresForm.ShowDialog();
        }

        private void listaDeJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeJugadores listaDeJugadoresForm = new ListaDeJugadores();
            listaDeJugadoresForm.ShowDialog();
        }

        private void buscarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarTodasLasRondasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMostrarTodasLasRondas();
        }

        private void buscarRondaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargaDeResultados();
        }

        private void editarResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AbrirMostrarTodasLasRondas()
        {
            TodasLasRondas todasLasRondasForm = new TodasLasRondas();
            todasLasRondasForm.ShowDialog();
        }

        private void CargaDeResultados()
        {

        }

       
    }
}
