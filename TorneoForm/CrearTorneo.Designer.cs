namespace TorneoForm
{
    partial class CrearTorneo
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
            this.lblDatosDelTorneo = new System.Windows.Forms.Label();
            this.lblConfiguracionDelTorneo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombreTorneo = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinalizacion = new System.Windows.Forms.Label();
            this.lblRitmoTorneo = new System.Windows.Forms.Label();
            this.lblLugarTorneo = new System.Windows.Forms.Label();
            this.lblFederacionClub = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblSistemaTorneo = new System.Windows.Forms.Label();
            this.rbtnSistemaRoundRobin = new System.Windows.Forms.RadioButton();
            this.rbtnSistemaSuizo = new System.Windows.Forms.RadioButton();
            this.cbxRitmoTorneo = new System.Windows.Forms.ComboBox();
            this.txtNombreTorneo = new System.Windows.Forms.TextBox();
            this.txtLugarTorneo = new System.Windows.Forms.TextBox();
            this.txtFederacionClub = new System.Windows.Forms.TextBox();
            this.dtpFechaInicioTorneo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinalizacionTorneo = new System.Windows.Forms.DateTimePicker();
            this.lblEspecificacionesRitmo = new System.Windows.Forms.Label();
            this.txtEspecificacionesRitmo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDatosDelTorneo
            // 
            this.lblDatosDelTorneo.AutoSize = true;
            this.lblDatosDelTorneo.Location = new System.Drawing.Point(15, 9);
            this.lblDatosDelTorneo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDatosDelTorneo.Name = "lblDatosDelTorneo";
            this.lblDatosDelTorneo.Size = new System.Drawing.Size(155, 24);
            this.lblDatosDelTorneo.TabIndex = 0;
            this.lblDatosDelTorneo.Text = "Datos del Torneo";
            // 
            // lblConfiguracionDelTorneo
            // 
            this.lblConfiguracionDelTorneo.AutoSize = true;
            this.lblConfiguracionDelTorneo.Location = new System.Drawing.Point(15, 246);
            this.lblConfiguracionDelTorneo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblConfiguracionDelTorneo.Name = "lblConfiguracionDelTorneo";
            this.lblConfiguracionDelTorneo.Size = new System.Drawing.Size(225, 24);
            this.lblConfiguracionDelTorneo.TabIndex = 1;
            this.lblConfiguracionDelTorneo.Text = "Configuración del Torneo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(595, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.Location = new System.Drawing.Point(763, 410);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombreTorneo
            // 
            this.lblNombreTorneo.AutoSize = true;
            this.lblNombreTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombreTorneo.Location = new System.Drawing.Point(17, 57);
            this.lblNombreTorneo.Name = "lblNombreTorneo";
            this.lblNombreTorneo.Size = new System.Drawing.Size(62, 17);
            this.lblNombreTorneo.TabIndex = 4;
            this.lblNombreTorneo.Text = "Nombre:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFechaInicio.Location = new System.Drawing.Point(17, 91);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(107, 17);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // lblFechaFinalizacion
            // 
            this.lblFechaFinalizacion.AutoSize = true;
            this.lblFechaFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFechaFinalizacion.Location = new System.Drawing.Point(406, 91);
            this.lblFechaFinalizacion.Name = "lblFechaFinalizacion";
            this.lblFechaFinalizacion.Size = new System.Drawing.Size(149, 17);
            this.lblFechaFinalizacion.TabIndex = 6;
            this.lblFechaFinalizacion.Text = "Fecha de Finalización:";
            // 
            // lblRitmoTorneo
            // 
            this.lblRitmoTorneo.AutoSize = true;
            this.lblRitmoTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRitmoTorneo.Location = new System.Drawing.Point(17, 211);
            this.lblRitmoTorneo.Name = "lblRitmoTorneo";
            this.lblRitmoTorneo.Size = new System.Drawing.Size(121, 17);
            this.lblRitmoTorneo.TabIndex = 7;
            this.lblRitmoTorneo.Text = "Ritmo del Torneo:";
            // 
            // lblLugarTorneo
            // 
            this.lblLugarTorneo.AutoSize = true;
            this.lblLugarTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLugarTorneo.Location = new System.Drawing.Point(17, 131);
            this.lblLugarTorneo.Name = "lblLugarTorneo";
            this.lblLugarTorneo.Size = new System.Drawing.Size(49, 17);
            this.lblLugarTorneo.TabIndex = 8;
            this.lblLugarTorneo.Text = "Lugar:";
            // 
            // lblFederacionClub
            // 
            this.lblFederacionClub.AutoSize = true;
            this.lblFederacionClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFederacionClub.Location = new System.Drawing.Point(17, 171);
            this.lblFederacionClub.Name = "lblFederacionClub";
            this.lblFederacionClub.Size = new System.Drawing.Size(115, 17);
            this.lblFederacionClub.TabIndex = 9;
            this.lblFederacionClub.Text = "Federación/Club:";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCategorias.Location = new System.Drawing.Point(15, 282);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(80, 17);
            this.lblCategorias.TabIndex = 10;
            this.lblCategorias.Text = "Categorías:";
            // 
            // lblSistemaTorneo
            // 
            this.lblSistemaTorneo.AutoSize = true;
            this.lblSistemaTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSistemaTorneo.Location = new System.Drawing.Point(15, 311);
            this.lblSistemaTorneo.Name = "lblSistemaTorneo";
            this.lblSistemaTorneo.Size = new System.Drawing.Size(62, 17);
            this.lblSistemaTorneo.TabIndex = 11;
            this.lblSistemaTorneo.Text = "Sistema:";
            // 
            // rbtnSistemaRoundRobin
            // 
            this.rbtnSistemaRoundRobin.AutoSize = true;
            this.rbtnSistemaRoundRobin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtnSistemaRoundRobin.Location = new System.Drawing.Point(71, 340);
            this.rbtnSistemaRoundRobin.Name = "rbtnSistemaRoundRobin";
            this.rbtnSistemaRoundRobin.Size = new System.Drawing.Size(109, 21);
            this.rbtnSistemaRoundRobin.TabIndex = 14;
            this.rbtnSistemaRoundRobin.TabStop = true;
            this.rbtnSistemaRoundRobin.Text = "Round Robin";
            this.rbtnSistemaRoundRobin.UseVisualStyleBackColor = true;
            // 
            // rbtnSistemaSuizo
            // 
            this.rbtnSistemaSuizo.AutoSize = true;
            this.rbtnSistemaSuizo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtnSistemaSuizo.Location = new System.Drawing.Point(71, 373);
            this.rbtnSistemaSuizo.Name = "rbtnSistemaSuizo";
            this.rbtnSistemaSuizo.Size = new System.Drawing.Size(61, 21);
            this.rbtnSistemaSuizo.TabIndex = 15;
            this.rbtnSistemaSuizo.TabStop = true;
            this.rbtnSistemaSuizo.Text = "Suizo";
            this.rbtnSistemaSuizo.UseVisualStyleBackColor = true;
            // 
            // cbxRitmoTorneo
            // 
            this.cbxRitmoTorneo.DisplayMember = "ninguno";
            this.cbxRitmoTorneo.FormattingEnabled = true;
            this.cbxRitmoTorneo.Location = new System.Drawing.Point(137, 196);
            this.cbxRitmoTorneo.Name = "cbxRitmoTorneo";
            this.cbxRitmoTorneo.Size = new System.Drawing.Size(248, 32);
            this.cbxRitmoTorneo.TabIndex = 16;
            // 
            // txtNombreTorneo
            // 
            this.txtNombreTorneo.Location = new System.Drawing.Point(137, 45);
            this.txtNombreTorneo.Name = "txtNombreTorneo";
            this.txtNombreTorneo.Size = new System.Drawing.Size(701, 29);
            this.txtNombreTorneo.TabIndex = 17;
            // 
            // txtLugarTorneo
            // 
            this.txtLugarTorneo.Location = new System.Drawing.Point(137, 119);
            this.txtLugarTorneo.Name = "txtLugarTorneo";
            this.txtLugarTorneo.Size = new System.Drawing.Size(701, 29);
            this.txtLugarTorneo.TabIndex = 18;
            // 
            // txtFederacionClub
            // 
            this.txtFederacionClub.Location = new System.Drawing.Point(137, 159);
            this.txtFederacionClub.Name = "txtFederacionClub";
            this.txtFederacionClub.Size = new System.Drawing.Size(701, 29);
            this.txtFederacionClub.TabIndex = 19;
            // 
            // dtpFechaInicioTorneo
            // 
            this.dtpFechaInicioTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFechaInicioTorneo.Location = new System.Drawing.Point(137, 85);
            this.dtpFechaInicioTorneo.Name = "dtpFechaInicioTorneo";
            this.dtpFechaInicioTorneo.Size = new System.Drawing.Size(248, 23);
            this.dtpFechaInicioTorneo.TabIndex = 20;
            // 
            // dtpFechaFinalizacionTorneo
            // 
            this.dtpFechaFinalizacionTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFechaFinalizacionTorneo.Location = new System.Drawing.Point(595, 85);
            this.dtpFechaFinalizacionTorneo.Name = "dtpFechaFinalizacionTorneo";
            this.dtpFechaFinalizacionTorneo.Size = new System.Drawing.Size(243, 23);
            this.dtpFechaFinalizacionTorneo.TabIndex = 21;
            // 
            // lblEspecificacionesRitmo
            // 
            this.lblEspecificacionesRitmo.AutoSize = true;
            this.lblEspecificacionesRitmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEspecificacionesRitmo.Location = new System.Drawing.Point(406, 211);
            this.lblEspecificacionesRitmo.Name = "lblEspecificacionesRitmo";
            this.lblEspecificacionesRitmo.Size = new System.Drawing.Size(187, 17);
            this.lblEspecificacionesRitmo.TabIndex = 22;
            this.lblEspecificacionesRitmo.Text = "Especificaciones (Ej.: 10 +3)";
            // 
            // txtEspecificacionesRitmo
            // 
            this.txtEspecificacionesRitmo.Location = new System.Drawing.Point(595, 199);
            this.txtEspecificacionesRitmo.Name = "txtEspecificacionesRitmo";
            this.txtEspecificacionesRitmo.Size = new System.Drawing.Size(243, 29);
            this.txtEspecificacionesRitmo.TabIndex = 23;
            // 
            // CrearTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 445);
            this.Controls.Add(this.txtEspecificacionesRitmo);
            this.Controls.Add(this.lblEspecificacionesRitmo);
            this.Controls.Add(this.dtpFechaFinalizacionTorneo);
            this.Controls.Add(this.dtpFechaInicioTorneo);
            this.Controls.Add(this.txtFederacionClub);
            this.Controls.Add(this.txtLugarTorneo);
            this.Controls.Add(this.txtNombreTorneo);
            this.Controls.Add(this.cbxRitmoTorneo);
            this.Controls.Add(this.rbtnSistemaSuizo);
            this.Controls.Add(this.rbtnSistemaRoundRobin);
            this.Controls.Add(this.lblSistemaTorneo);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.lblFederacionClub);
            this.Controls.Add(this.lblLugarTorneo);
            this.Controls.Add(this.lblRitmoTorneo);
            this.Controls.Add(this.lblFechaFinalizacion);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblNombreTorneo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblConfiguracionDelTorneo);
            this.Controls.Add(this.lblDatosDelTorneo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(885, 484);
            this.MinimumSize = new System.Drawing.Size(885, 484);
            this.Name = "CrearTorneo";
            this.Text = "Crear Torneo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosDelTorneo;
        private System.Windows.Forms.Label lblConfiguracionDelTorneo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombreTorneo;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFinalizacion;
        private System.Windows.Forms.Label lblRitmoTorneo;
        private System.Windows.Forms.Label lblLugarTorneo;
        private System.Windows.Forms.Label lblFederacionClub;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblSistemaTorneo;
        private System.Windows.Forms.RadioButton rbtnSistemaRoundRobin;
        private System.Windows.Forms.RadioButton rbtnSistemaSuizo;
        private System.Windows.Forms.ComboBox cbxRitmoTorneo;
        private System.Windows.Forms.TextBox txtNombreTorneo;
        private System.Windows.Forms.TextBox txtLugarTorneo;
        private System.Windows.Forms.TextBox txtFederacionClub;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioTorneo;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalizacionTorneo;
        private System.Windows.Forms.Label lblEspecificacionesRitmo;
        private System.Windows.Forms.TextBox txtEspecificacionesRitmo;
    }
}