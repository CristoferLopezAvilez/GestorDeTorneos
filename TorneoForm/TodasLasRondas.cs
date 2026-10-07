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
    public partial class TodasLasRondas : Form
    {
        Torneo torneo;
        public TodasLasRondas(Torneo torneo)
        {
            this.torneo = torneo;
            InitializeComponent();

            DataGridViewTextBoxColumn columnaNumeroRonda =
                new DataGridViewTextBoxColumn();
            columnaNumeroRonda.Name = "NumeroRonda";
            columnaNumeroRonda.HeaderText = "Ronda";
            dgvTodasLasRondas.Columns.Add(columnaNumeroRonda);

            DataGridViewTextBoxColumn columnaMesa =
          new DataGridViewTextBoxColumn();

            columnaMesa.Name = "Mesa";
            columnaMesa.HeaderText = "Mesa";

            dgvTodasLasRondas.Columns.Add(columnaMesa);


            DataGridViewTextBoxColumn columnaBlancas =
                new DataGridViewTextBoxColumn();

            columnaBlancas.Name = "Blancas";
            columnaBlancas.HeaderText = "Blancas";

            dgvTodasLasRondas.Columns.Add(columnaBlancas);


            DataGridViewTextBoxColumn columnaNegras =
                new DataGridViewTextBoxColumn();

            columnaNegras.Name = "Negras";
            columnaNegras.HeaderText = "Negras";

            dgvTodasLasRondas.Columns.Add(columnaNegras);


            DataGridViewComboBoxColumn columnaResultado =
                new DataGridViewComboBoxColumn();

            columnaResultado.Name = "Resultado";
            columnaResultado.HeaderText = "Resultado";
            columnaResultado.Items.Add("1 - 0");
            columnaResultado.Items.Add("0 - 1");
            columnaResultado.Items.Add("½ - ½");

            dgvTodasLasRondas.Columns.Add(columnaResultado);

            columnaMesa.ReadOnly = true;
            columnaBlancas.ReadOnly = true;
            columnaNegras.ReadOnly = true;
            columnaResultado.ReadOnly = true;
        }


        private void btnEditarTodasLasRondas_Click(object sender, EventArgs e)
        {
            dgvTodasLasRondas.Columns["Resultado"].ReadOnly = false;

        }

        private void btnGuardarTodasLasRondas_Click(object sender, EventArgs e)
        {
            dgvTodasLasRondas.EndEdit();

            foreach (DataGridViewRow fila in dgvTodasLasRondas.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                Partida partida =
                    fila.Tag as Partida;

                if (partida == null)
                    continue;

                string valor =
                    fila.Cells["Resultado"]
                        .Value?
                        .ToString();

                if (string.IsNullOrEmpty(valor))
                    continue;

                if (valor == "1 - 0")
                {
                    partida.RegistrarResultado(
                        ResultadoEnum.VictoriaBlanca);
                }
                else if (valor == "0 - 1")
                {
                    partida.RegistrarResultado(
                        ResultadoEnum.VictoriaNegra);
                }
                else if (valor == "½ - ½")
                {
                    partida.RegistrarResultado(
                        ResultadoEnum.Empate);
                }
            }

            dgvTodasLasRondas.Columns["Resultado"].ReadOnly = true;

            this.Close();

        }

        private void TodasLasRondas_Load(object sender, EventArgs e)
        {
            
            dgvTodasLasRondas.Rows.Clear();
            
            foreach (var ronda in torneo.Rondas)
            {
                SeparadorRondas(ronda);
                foreach (var partida in ronda.ObtenerPartidas())
                {
                    int indiceFila = dgvTodasLasRondas.Rows.Add(
                    "",
                    partida.NumeroMesa,
                    partida.JugadorBlancas.NombreCompleto,
                    partida.JugadorNegras.NombreCompleto
                );
                    // Guardamos la Partida asociada a esta fila
                    dgvTodasLasRondas.Rows[indiceFila].Tag = partida;

                    if (partida.TieneResultado())
                    {
                        if (partida.GanoBlancas())
                        {
                            dgvTodasLasRondas.Rows[indiceFila].Cells["Resultado"].Value = "1 - 0";
                        }
                        else if (partida.GanoNegras())
                        {
                            dgvTodasLasRondas.Rows[indiceFila].Cells["Resultado"].Value = "0 - 1";
                        }
                        else if (partida.EsEmpate())
                        {
                            dgvTodasLasRondas.Rows[indiceFila].Cells["Resultado"].Value = "½ - ½";
                        }
                    }
                }

                

            }
          

        }

        private void SeparadorRondas(Ronda ronda)
        {
            
            int filaTitulo = dgvTodasLasRondas.Rows.Add();
           

            dgvTodasLasRondas.Rows[filaTitulo].Cells[0].Value =
                $"RONDA N° {ronda.NumeroDeRonda}";

            dgvTodasLasRondas.Rows[filaTitulo].ReadOnly = true;

            dgvTodasLasRondas.Rows[filaTitulo].DefaultCellStyle.Font =
                new Font(dgvTodasLasRondas.Font, FontStyle.Bold);
            dgvTodasLasRondas.Rows[filaTitulo].DefaultCellStyle.BackColor =
                Color.LightBlue;
            dgvTodasLasRondas.Rows[filaTitulo].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvTodasLasRondas.Rows[filaTitulo].Height = 30;
        }

    }
}
