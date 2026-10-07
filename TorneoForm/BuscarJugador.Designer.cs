namespace TorneoForm
{
    partial class BuscarJugador
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
            this.lblBuscarJugador = new System.Windows.Forms.Label();
            this.txtBuscarJugador = new System.Windows.Forms.TextBox();
            this.btnBuscarJugador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBuscarJugador
            // 
            this.lblBuscarJugador.AutoSize = true;
            this.lblBuscarJugador.Location = new System.Drawing.Point(12, 27);
            this.lblBuscarJugador.Name = "lblBuscarJugador";
            this.lblBuscarJugador.Size = new System.Drawing.Size(186, 13);
            this.lblBuscarJugador.TabIndex = 0;
            this.lblBuscarJugador.Text = "Buscar Jugador por Nombre Completo";
            // 
            // txtBuscarJugador
            // 
            this.txtBuscarJugador.Location = new System.Drawing.Point(204, 20);
            this.txtBuscarJugador.Name = "txtBuscarJugador";
            this.txtBuscarJugador.Size = new System.Drawing.Size(198, 20);
            this.txtBuscarJugador.TabIndex = 1;
            // 
            // btnBuscarJugador
            // 
            this.btnBuscarJugador.Location = new System.Drawing.Point(204, 59);
            this.btnBuscarJugador.Name = "btnBuscarJugador";
            this.btnBuscarJugador.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarJugador.TabIndex = 2;
            this.btnBuscarJugador.Text = "Buscar";
            this.btnBuscarJugador.UseVisualStyleBackColor = true;
            this.btnBuscarJugador.Click += new System.EventHandler(this.btnBuscarJugador_Click);
            // 
            // BuscarJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 89);
            this.Controls.Add(this.btnBuscarJugador);
            this.Controls.Add(this.txtBuscarJugador);
            this.Controls.Add(this.lblBuscarJugador);
            this.Name = "BuscarJugador";
            this.Text = "BuscarJugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarJugador;
        private System.Windows.Forms.TextBox txtBuscarJugador;
        private System.Windows.Forms.Button btnBuscarJugador;
    }
}