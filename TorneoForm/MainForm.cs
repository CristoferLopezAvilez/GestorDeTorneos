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
        private int numeroRondaMostrada = 0;
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
            columnaResultado.Items.Add("1 - 0");
            columnaResultado.Items.Add("0 - 1");
            columnaResultado.Items.Add("½ - ½");

            dgvMain.Columns.Add(columnaResultado);
        }



        private void btnMostrarTodasLasRondas_Click(object sender, EventArgs e)
        {
            AbrirMostrarTodasLasRondas();


        }

        private void btnTablaDePosicion_Click(object sender, EventArgs e)
        {
            TablaDePosicionGeneral tablaDePosicionGeneralForm = new TablaDePosicionGeneral(torneo);
            tablaDePosicionGeneralForm.ShowDialog();
        }

        private void btnRondaSiguienteMain_Click(object sender, EventArgs e)
        {
            if (torneo.Estado != EstadoTorneo.TorneoEnCurso)
            {
                MessageBox.Show("El torneo no ha sido iniciado o ya ha finalizado.");
                return;
            }

            if (numeroRondaMostrada >= torneo.CantidadRondas)
            {
                MessageBox.Show("Ya estás en la última ronda.");
                return;
            }

            numeroRondaMostrada++;

            var rondaSiguiente = torneo.Rondas
                .FirstOrDefault(r => r.NumeroDeRonda == numeroRondaMostrada);

            if (rondaSiguiente != null)
            {
                MostrarRonda(rondaSiguiente);
            }
        }

        private void btnRondaAnteriorMain_Click(object sender, EventArgs e)
        {
            if (numeroRondaMostrada <= 1)
            {
                MessageBox.Show("Ya estás en la primera ronda.");
                return;
            }

            numeroRondaMostrada--;

            var rondaAnterior = torneo.Rondas
                .FirstOrDefault(r => r.NumeroDeRonda == numeroRondaMostrada);

            if (rondaAnterior != null)
            {
                MostrarRonda(rondaAnterior);
            }
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

                if (partida.JugadorBlancas.NombreCompleto == "BYE")
                {
                    partida.RegistrarResultado(ResultadoEnum.VictoriaNegra);

                    dgvMain.Rows[fila].Cells["Resultado"].Value = "0 - 1";
                    dgvMain.Rows[fila].Cells["Resultado"].ReadOnly = true;
                }
                else if (partida.JugadorNegras.NombreCompleto == "BYE")
                {
                    partida.RegistrarResultado(ResultadoEnum.VictoriaBlanca);

                    dgvMain.Rows[fila].Cells["Resultado"].Value = "1 - 0";
                    dgvMain.Rows[fila].Cells["Resultado"].ReadOnly = true;
                }

                if (partida.TieneResultado())
                {
                    dgvMain.Rows[fila].Cells["Resultado"].Value =
                        ConvertirResultadoTexto(partida.Resultado.Value);
                }

                lblNumeroRondaMain.Text = $"Ronda N°: {ronda.NumeroDeRonda}";
            }


        }
        private void btnIniciarTorneoMain_Click(object sender, EventArgs e)
        {
            if (torneo.Estado == EstadoTorneo.TorneoNoIniciado)
            {
                torneo.IniciarTorneo();

                var ronda = torneo.Rondas
                   .FirstOrDefault(r => r.NumeroDeRonda == 1);

                numeroRondaMostrada = 1;

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

        // Actualiza el resultado de la partida cuando cambia la celda Resultado.
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

            if (partida.JugadorBlancas.NombreCompleto == "BYE" ||
                  partida.JugadorNegras.NombreCompleto == "BYE")
            {
                return;
            }

            string valor =
                dgvMain.Rows[e.RowIndex]
                    .Cells["Resultado"].Value.ToString();

            ResultadoEnum resultado = ConvertirResultado(valor);

            partida.RegistrarResultado(resultado);

        }

        // Confirma inmediatamente el cambio del ComboBox.
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

        private ResultadoEnum ConvertirResultado(string valor)
        {
           
            switch (valor)
            {
                case "1 - 0":
                    return ResultadoEnum.VictoriaBlanca;

                case "0 - 1":
                    return ResultadoEnum.VictoriaNegra;

                case "½ - ½":
                    return ResultadoEnum.Empate;

                default:
                    throw new ArgumentException(
                        "El resultado no es válido.",
                        nameof(valor));
            }
        }
        private string ConvertirResultadoTexto(ResultadoEnum resultado)
        {
            switch (resultado)
            {
                case ResultadoEnum.VictoriaBlanca:
                    return "1 - 0";

                case ResultadoEnum.VictoriaNegra:
                    return "0 - 1";

                case ResultadoEnum.Empate:
                    return "½ - ½";

                default:
                    return "";
            }
        }
        private void nuevoTorneoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VentanaCrearTorneo();
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
            VentanaCrearTorneo();
        }

        private void configuraciónDelTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaCrearTorneo();
        }

        private void iniciarTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnIniciarTorneoMain_Click(sender, e);
        }

        private void agregarJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarJugadores agregarJugadoresForm = new AgregarJugadores(torneo);
            agregarJugadoresForm.ShowDialog();
        }

        private void listaDeJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeJugadores listaDeJugadoresForm = new ListaDeJugadores(torneo);
            listaDeJugadoresForm.ShowDialog();
        }

        private void buscarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarJugador buscarJugadorForm = new BuscarJugador(torneo);
            buscarJugadorForm.ShowDialog();
        }

        private void mostrarTodasLasRondasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirMostrarTodasLasRondas();
        }

        private void buscarRondaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void editarResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AbrirMostrarTodasLasRondas()
        {
            TodasLasRondas todasLasRondasForm = new TodasLasRondas(torneo);
            todasLasRondasForm.ShowDialog();

            // Buscar nuevamente la ronda que estaba mostrando el MainForm
            var rondaActual = torneo.Rondas
                .FirstOrDefault(r => r.NumeroDeRonda == numeroRondaMostrada);
            if (rondaActual != null)
            {
                MostrarRonda(rondaActual);
            }
        }


        private void VentanaCrearTorneo()
        {
            if (torneo.Estado == EstadoTorneo.TorneoEnCurso || torneo.Estado == EstadoTorneo.TorneoFinalizado)
            {
                MessageBox.Show("No se puede crear un nuevo torneo mientras hay uno en curso o finalizado.");
                return;
            }
            CrearTorneo crearTorneoForm = new CrearTorneo(torneo);
            crearTorneoForm.ShowDialog();
        }

     
    }
}
