namespace TorneoForm
{
    partial class ListaDeJugadores
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
            this.dgvListaDeJugadores = new System.Windows.Forms.DataGridView();
            this.btnEditarListaDeJugadores = new System.Windows.Forms.Button();
            this.btnGuardarListaDeJugadores = new System.Windows.Forms.Button();
            this.VerCaracteristicaListaDeJugadores = new System.Windows.Forms.Button();
            this.btnCancelarListaDeJugadores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaDeJugadores
            // 
            this.dgvListaDeJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeJugadores.Location = new System.Drawing.Point(12, 12);
            this.dgvListaDeJugadores.Name = "dgvListaDeJugadores";
            this.dgvListaDeJugadores.Size = new System.Drawing.Size(541, 325);
            this.dgvListaDeJugadores.TabIndex = 0;
            // 
            // btnEditarListaDeJugadores
            // 
            this.btnEditarListaDeJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditarListaDeJugadores.Location = new System.Drawing.Point(582, 12);
            this.btnEditarListaDeJugadores.Name = "btnEditarListaDeJugadores";
            this.btnEditarListaDeJugadores.Size = new System.Drawing.Size(190, 55);
            this.btnEditarListaDeJugadores.TabIndex = 1;
            this.btnEditarListaDeJugadores.Text = "Editar";
            this.btnEditarListaDeJugadores.UseVisualStyleBackColor = true;
            this.btnEditarListaDeJugadores.Click += new System.EventHandler(this.btnEditarListaDeJugadores_Click);
            // 
            // btnGuardarListaDeJugadores
            // 
            this.btnGuardarListaDeJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardarListaDeJugadores.Location = new System.Drawing.Point(582, 192);
            this.btnGuardarListaDeJugadores.Name = "btnGuardarListaDeJugadores";
            this.btnGuardarListaDeJugadores.Size = new System.Drawing.Size(190, 55);
            this.btnGuardarListaDeJugadores.TabIndex = 2;
            this.btnGuardarListaDeJugadores.Text = "Guardar";
            this.btnGuardarListaDeJugadores.UseVisualStyleBackColor = true;
            this.btnGuardarListaDeJugadores.Click += new System.EventHandler(this.btnGuardarListaDeJugadores_Click);
            // 
            // VerCaracteristicaListaDeJugadores
            // 
            this.VerCaracteristicaListaDeJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.VerCaracteristicaListaDeJugadores.Location = new System.Drawing.Point(582, 282);
            this.VerCaracteristicaListaDeJugadores.Name = "VerCaracteristicaListaDeJugadores";
            this.VerCaracteristicaListaDeJugadores.Size = new System.Drawing.Size(190, 55);
            this.VerCaracteristicaListaDeJugadores.TabIndex = 3;
            this.VerCaracteristicaListaDeJugadores.Text = "Ver Características";
            this.VerCaracteristicaListaDeJugadores.UseVisualStyleBackColor = true;
            this.VerCaracteristicaListaDeJugadores.Click += new System.EventHandler(this.VerCaracteristicaListaDeJugadores_Click);
            // 
            // btnCancelarListaDeJugadores
            // 
            this.btnCancelarListaDeJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelarListaDeJugadores.Location = new System.Drawing.Point(582, 102);
            this.btnCancelarListaDeJugadores.Name = "btnCancelarListaDeJugadores";
            this.btnCancelarListaDeJugadores.Size = new System.Drawing.Size(190, 55);
            this.btnCancelarListaDeJugadores.TabIndex = 4;
            this.btnCancelarListaDeJugadores.Text = "Cancelar";
            this.btnCancelarListaDeJugadores.UseVisualStyleBackColor = true;
            this.btnCancelarListaDeJugadores.Click += new System.EventHandler(this.btnCancelarListaDeJugadores_Click);
            // 
            // ListaDeJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.btnCancelarListaDeJugadores);
            this.Controls.Add(this.VerCaracteristicaListaDeJugadores);
            this.Controls.Add(this.btnGuardarListaDeJugadores);
            this.Controls.Add(this.btnEditarListaDeJugadores);
            this.Controls.Add(this.dgvListaDeJugadores);
            this.Name = "ListaDeJugadores";
            this.Text = "Lista de Jugadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeJugadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDeJugadores;
        private System.Windows.Forms.Button btnEditarListaDeJugadores;
        private System.Windows.Forms.Button btnGuardarListaDeJugadores;
        private System.Windows.Forms.Button VerCaracteristicaListaDeJugadores;
        private System.Windows.Forms.Button btnCancelarListaDeJugadores;
    }
}