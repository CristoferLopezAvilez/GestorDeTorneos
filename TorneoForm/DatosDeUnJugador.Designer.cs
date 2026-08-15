namespace TorneoForm
{
    partial class DatosDeUnJugador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreDatosDeUnJugador = new System.Windows.Forms.Label();
            this.lblIdDatosDeUnJugador = new System.Windows.Forms.Label();
            this.lblPuntosDatosDeUnJugador = new System.Windows.Forms.Label();
            this.lblClubDatosDeUnJugador = new System.Windows.Forms.Label();
            this.lblPuestoDatosDeUnJugador = new System.Windows.Forms.Label();
            this.dgvInformacionDatosDeUnJugador = new System.Windows.Forms.DataGridView();
            this.lblInformacionDatosDeUnJugador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacionDatosDeUnJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreDatosDeUnJugador
            // 
            this.lblNombreDatosDeUnJugador.AutoSize = true;
            this.lblNombreDatosDeUnJugador.Location = new System.Drawing.Point(31, 23);
            this.lblNombreDatosDeUnJugador.Name = "lblNombreDatosDeUnJugador";
            this.lblNombreDatosDeUnJugador.Size = new System.Drawing.Size(91, 13);
            this.lblNombreDatosDeUnJugador.TabIndex = 0;
            this.lblNombreDatosDeUnJugador.Text = "Nombre Completo";
            // 
            // lblIdDatosDeUnJugador
            // 
            this.lblIdDatosDeUnJugador.AutoSize = true;
            this.lblIdDatosDeUnJugador.Location = new System.Drawing.Point(31, 51);
            this.lblIdDatosDeUnJugador.Name = "lblIdDatosDeUnJugador";
            this.lblIdDatosDeUnJugador.Size = new System.Drawing.Size(16, 13);
            this.lblIdDatosDeUnJugador.TabIndex = 1;
            this.lblIdDatosDeUnJugador.Text = "Id";
            // 
            // lblPuntosDatosDeUnJugador
            // 
            this.lblPuntosDatosDeUnJugador.AutoSize = true;
            this.lblPuntosDatosDeUnJugador.Location = new System.Drawing.Point(31, 109);
            this.lblPuntosDatosDeUnJugador.Name = "lblPuntosDatosDeUnJugador";
            this.lblPuntosDatosDeUnJugador.Size = new System.Drawing.Size(40, 13);
            this.lblPuntosDatosDeUnJugador.TabIndex = 2;
            this.lblPuntosDatosDeUnJugador.Text = "Puntos";
            // 
            // lblClubDatosDeUnJugador
            // 
            this.lblClubDatosDeUnJugador.AutoSize = true;
            this.lblClubDatosDeUnJugador.Location = new System.Drawing.Point(31, 83);
            this.lblClubDatosDeUnJugador.Name = "lblClubDatosDeUnJugador";
            this.lblClubDatosDeUnJugador.Size = new System.Drawing.Size(28, 13);
            this.lblClubDatosDeUnJugador.TabIndex = 3;
            this.lblClubDatosDeUnJugador.Text = "Club";
            // 
            // lblPuestoDatosDeUnJugador
            // 
            this.lblPuestoDatosDeUnJugador.AutoSize = true;
            this.lblPuestoDatosDeUnJugador.Location = new System.Drawing.Point(31, 138);
            this.lblPuestoDatosDeUnJugador.Name = "lblPuestoDatosDeUnJugador";
            this.lblPuestoDatosDeUnJugador.Size = new System.Drawing.Size(40, 13);
            this.lblPuestoDatosDeUnJugador.TabIndex = 4;
            this.lblPuestoDatosDeUnJugador.Text = "Puesto";
            // 
            // dgvInformacionDatosDeUnJugador
            // 
            this.dgvInformacionDatosDeUnJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacionDatosDeUnJugador.Location = new System.Drawing.Point(34, 225);
            this.dgvInformacionDatosDeUnJugador.Name = "dgvInformacionDatosDeUnJugador";
            this.dgvInformacionDatosDeUnJugador.Size = new System.Drawing.Size(240, 150);
            this.dgvInformacionDatosDeUnJugador.TabIndex = 5;
            // 
            // lblInformacionDatosDeUnJugador
            // 
            this.lblInformacionDatosDeUnJugador.AutoSize = true;
            this.lblInformacionDatosDeUnJugador.Location = new System.Drawing.Point(34, 206);
            this.lblInformacionDatosDeUnJugador.Name = "lblInformacionDatosDeUnJugador";
            this.lblInformacionDatosDeUnJugador.Size = new System.Drawing.Size(134, 13);
            this.lblInformacionDatosDeUnJugador.TabIndex = 6;
            this.lblInformacionDatosDeUnJugador.Text = "Información de las Partidas";
            // 
            // DatosDeUnJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInformacionDatosDeUnJugador);
            this.Controls.Add(this.dgvInformacionDatosDeUnJugador);
            this.Controls.Add(this.lblPuestoDatosDeUnJugador);
            this.Controls.Add(this.lblClubDatosDeUnJugador);
            this.Controls.Add(this.lblPuntosDatosDeUnJugador);
            this.Controls.Add(this.lblIdDatosDeUnJugador);
            this.Controls.Add(this.lblNombreDatosDeUnJugador);
            this.Name = "DatosDeUnJugador";
            this.Text = "Datos de un Jugador";
            this.Load += new System.EventHandler(this.DatosDeUnJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacionDatosDeUnJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreDatosDeUnJugador;
        private System.Windows.Forms.Label lblIdDatosDeUnJugador;
        private System.Windows.Forms.Label lblPuntosDatosDeUnJugador;
        private System.Windows.Forms.Label lblClubDatosDeUnJugador;
        private System.Windows.Forms.Label lblPuestoDatosDeUnJugador;
        private System.Windows.Forms.DataGridView dgvInformacionDatosDeUnJugador;
        private System.Windows.Forms.Label lblInformacionDatosDeUnJugador;
    }
}