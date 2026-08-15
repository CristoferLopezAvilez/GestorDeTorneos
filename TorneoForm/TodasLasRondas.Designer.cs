namespace TorneoForm
{
    partial class TodasLasRondas
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
            this.dgvTodasLasRondas = new System.Windows.Forms.DataGridView();
            this.btnEditarTodasLasRondas = new System.Windows.Forms.Button();
            this.btnGuardarTodasLasRondas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodasLasRondas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTodasLasRondas
            // 
            this.dgvTodasLasRondas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodasLasRondas.Location = new System.Drawing.Point(12, 12);
            this.dgvTodasLasRondas.Name = "dgvTodasLasRondas";
            this.dgvTodasLasRondas.Size = new System.Drawing.Size(408, 288);
            this.dgvTodasLasRondas.TabIndex = 0;
            // 
            // btnEditarTodasLasRondas
            // 
            this.btnEditarTodasLasRondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditarTodasLasRondas.Location = new System.Drawing.Point(12, 306);
            this.btnEditarTodasLasRondas.Name = "btnEditarTodasLasRondas";
            this.btnEditarTodasLasRondas.Size = new System.Drawing.Size(190, 55);
            this.btnEditarTodasLasRondas.TabIndex = 1;
            this.btnEditarTodasLasRondas.Text = "Editar Resultados";
            this.btnEditarTodasLasRondas.UseVisualStyleBackColor = true;
            this.btnEditarTodasLasRondas.Click += new System.EventHandler(this.btnEditarTodasLasRondas_Click);
            // 
            // btnGuardarTodasLasRondas
            // 
            this.btnGuardarTodasLasRondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardarTodasLasRondas.Location = new System.Drawing.Point(230, 306);
            this.btnGuardarTodasLasRondas.Name = "btnGuardarTodasLasRondas";
            this.btnGuardarTodasLasRondas.Size = new System.Drawing.Size(190, 55);
            this.btnGuardarTodasLasRondas.TabIndex = 2;
            this.btnGuardarTodasLasRondas.Text = "Guardar Cambios";
            this.btnGuardarTodasLasRondas.UseVisualStyleBackColor = true;
            this.btnGuardarTodasLasRondas.Click += new System.EventHandler(this.btnGuardarTodasLasRondas_Click);
            // 
            // TodasLasRondas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 382);
            this.Controls.Add(this.btnGuardarTodasLasRondas);
            this.Controls.Add(this.btnEditarTodasLasRondas);
            this.Controls.Add(this.dgvTodasLasRondas);
            this.MaximumSize = new System.Drawing.Size(472, 421);
            this.MinimumSize = new System.Drawing.Size(472, 421);
            this.Name = "TodasLasRondas";
            this.Text = "Todas Las Rondas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodasLasRondas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTodasLasRondas;
        private System.Windows.Forms.Button btnEditarTodasLasRondas;
        private System.Windows.Forms.Button btnGuardarTodasLasRondas;
    }
}