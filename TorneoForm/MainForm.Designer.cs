namespace TorneoForm
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTorneoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónDelTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rondasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodasLasRondasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarRondaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarResultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnTablaDePosicion = new System.Windows.Forms.Button();
            this.btnCargarResultados = new System.Windows.Forms.Button();
            this.btnMostrarTodasLasRondas = new System.Windows.Forms.Button();
            this.btnRondaAnteriorMain = new System.Windows.Forms.Button();
            this.btnRondaSiguienteMain = new System.Windows.Forms.Button();
            this.lblNumeroRondaMain = new System.Windows.Forms.Label();
            this.btnIniciarTorneoMain = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTorneoToolStripMenuItem,
            this.torneoToolStripMenuItem,
            this.jugadoresToolStripMenuItem,
            this.rondasToolStripMenuItem,
            this.resultadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoTorneoToolStripMenuItem
            // 
            this.nuevoTorneoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTorneoToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.nuevoTorneoToolStripMenuItem.Name = "nuevoTorneoToolStripMenuItem";
            this.nuevoTorneoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.nuevoTorneoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoTorneoToolStripMenuItem1
            // 
            this.nuevoTorneoToolStripMenuItem1.Name = "nuevoTorneoToolStripMenuItem1";
            this.nuevoTorneoToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.nuevoTorneoToolStripMenuItem1.Text = "Nuevo Torneo...";
            this.nuevoTorneoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoTorneoToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // torneoToolStripMenuItem
            // 
            this.torneoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelTorneoToolStripMenuItem,
            this.configuraciónDelTorneoToolStripMenuItem,
            this.iniciarTorneoToolStripMenuItem});
            this.torneoToolStripMenuItem.Name = "torneoToolStripMenuItem";
            this.torneoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.torneoToolStripMenuItem.Text = "&Torneo";
            // 
            // datosDelTorneoToolStripMenuItem
            // 
            this.datosDelTorneoToolStripMenuItem.Name = "datosDelTorneoToolStripMenuItem";
            this.datosDelTorneoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.datosDelTorneoToolStripMenuItem.Text = "Datos del Torneo";
            this.datosDelTorneoToolStripMenuItem.Click += new System.EventHandler(this.datosDelTorneoToolStripMenuItem_Click);
            // 
            // configuraciónDelTorneoToolStripMenuItem
            // 
            this.configuraciónDelTorneoToolStripMenuItem.Name = "configuraciónDelTorneoToolStripMenuItem";
            this.configuraciónDelTorneoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.configuraciónDelTorneoToolStripMenuItem.Text = "Configuración del Torneo";
            this.configuraciónDelTorneoToolStripMenuItem.Click += new System.EventHandler(this.configuraciónDelTorneoToolStripMenuItem_Click);
            // 
            // iniciarTorneoToolStripMenuItem
            // 
            this.iniciarTorneoToolStripMenuItem.Name = "iniciarTorneoToolStripMenuItem";
            this.iniciarTorneoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.iniciarTorneoToolStripMenuItem.Text = "Iniciar Torneo";
            this.iniciarTorneoToolStripMenuItem.Click += new System.EventHandler(this.iniciarTorneoToolStripMenuItem_Click);
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarJugadoresToolStripMenuItem,
            this.listaDeJugadoresToolStripMenuItem,
            this.buscarJugadorToolStripMenuItem});
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.jugadoresToolStripMenuItem.Text = "&Jugadores";
            // 
            // agregarJugadoresToolStripMenuItem
            // 
            this.agregarJugadoresToolStripMenuItem.Name = "agregarJugadoresToolStripMenuItem";
            this.agregarJugadoresToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.agregarJugadoresToolStripMenuItem.Text = "Agregar Jugadores";
            this.agregarJugadoresToolStripMenuItem.Click += new System.EventHandler(this.agregarJugadoresToolStripMenuItem_Click);
            // 
            // listaDeJugadoresToolStripMenuItem
            // 
            this.listaDeJugadoresToolStripMenuItem.Name = "listaDeJugadoresToolStripMenuItem";
            this.listaDeJugadoresToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listaDeJugadoresToolStripMenuItem.Text = "Lista de Jugadores";
            this.listaDeJugadoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeJugadoresToolStripMenuItem_Click);
            // 
            // buscarJugadorToolStripMenuItem
            // 
            this.buscarJugadorToolStripMenuItem.Name = "buscarJugadorToolStripMenuItem";
            this.buscarJugadorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.buscarJugadorToolStripMenuItem.Text = "Buscar Jugador";
            this.buscarJugadorToolStripMenuItem.Click += new System.EventHandler(this.buscarJugadorToolStripMenuItem_Click);
            // 
            // rondasToolStripMenuItem
            // 
            this.rondasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodasLasRondasToolStripMenuItem,
            this.buscarRondaToolStripMenuItem});
            this.rondasToolStripMenuItem.Name = "rondasToolStripMenuItem";
            this.rondasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.rondasToolStripMenuItem.Text = "&Rondas";
            // 
            // mostrarTodasLasRondasToolStripMenuItem
            // 
            this.mostrarTodasLasRondasToolStripMenuItem.Name = "mostrarTodasLasRondasToolStripMenuItem";
            this.mostrarTodasLasRondasToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.mostrarTodasLasRondasToolStripMenuItem.Text = "Mostrar Todas las Rondas";
            this.mostrarTodasLasRondasToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodasLasRondasToolStripMenuItem_Click);
            // 
            // buscarRondaToolStripMenuItem
            // 
            this.buscarRondaToolStripMenuItem.Name = "buscarRondaToolStripMenuItem";
            this.buscarRondaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.buscarRondaToolStripMenuItem.Text = "Buscar Ronda";
            this.buscarRondaToolStripMenuItem.Click += new System.EventHandler(this.buscarRondaToolStripMenuItem_Click);
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarResultadoToolStripMenuItem,
            this.editarResultadosToolStripMenuItem});
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.resultadosToolStripMenuItem.Text = "R&esultados";
            // 
            // cargarResultadoToolStripMenuItem
            // 
            this.cargarResultadoToolStripMenuItem.Name = "cargarResultadoToolStripMenuItem";
            this.cargarResultadoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.cargarResultadoToolStripMenuItem.Text = "Cargar Resultados";
            this.cargarResultadoToolStripMenuItem.Click += new System.EventHandler(this.cargarResultadoToolStripMenuItem_Click);
            // 
            // editarResultadosToolStripMenuItem
            // 
            this.editarResultadosToolStripMenuItem.Name = "editarResultadosToolStripMenuItem";
            this.editarResultadosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editarResultadosToolStripMenuItem.Text = "Editar Resultados";
            this.editarResultadosToolStripMenuItem.Click += new System.EventHandler(this.editarResultadosToolStripMenuItem_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 65);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(620, 303);
            this.dgvMain.TabIndex = 2;
            this.dgvMain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellValueChanged);
            this.dgvMain.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvMain_CurrentCellDirtyStateChanged);
            // 
            // btnTablaDePosicion
            // 
            this.btnTablaDePosicion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTablaDePosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTablaDePosicion.Location = new System.Drawing.Point(652, 313);
            this.btnTablaDePosicion.Name = "btnTablaDePosicion";
            this.btnTablaDePosicion.Size = new System.Drawing.Size(190, 55);
            this.btnTablaDePosicion.TabIndex = 5;
            this.btnTablaDePosicion.Text = "Tabla de Posición";
            this.btnTablaDePosicion.UseVisualStyleBackColor = true;
            this.btnTablaDePosicion.Click += new System.EventHandler(this.btnTablaDePosicion_Click);
            // 
            // btnCargarResultados
            // 
            this.btnCargarResultados.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCargarResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCargarResultados.Location = new System.Drawing.Point(652, 65);
            this.btnCargarResultados.Name = "btnCargarResultados";
            this.btnCargarResultados.Size = new System.Drawing.Size(190, 55);
            this.btnCargarResultados.TabIndex = 3;
            this.btnCargarResultados.Text = "Cargar Resultados";
            this.btnCargarResultados.UseVisualStyleBackColor = true;
            this.btnCargarResultados.Click += new System.EventHandler(this.btnCargarResultados_Click);
            // 
            // btnMostrarTodasLasRondas
            // 
            this.btnMostrarTodasLasRondas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMostrarTodasLasRondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMostrarTodasLasRondas.Location = new System.Drawing.Point(652, 189);
            this.btnMostrarTodasLasRondas.Name = "btnMostrarTodasLasRondas";
            this.btnMostrarTodasLasRondas.Size = new System.Drawing.Size(190, 55);
            this.btnMostrarTodasLasRondas.TabIndex = 4;
            this.btnMostrarTodasLasRondas.Text = "Mostrar Todas las Rondas";
            this.btnMostrarTodasLasRondas.UseVisualStyleBackColor = true;
            this.btnMostrarTodasLasRondas.Click += new System.EventHandler(this.btnMostrarTodasLasRondas_Click);
            // 
            // btnRondaAnteriorMain
            // 
            this.btnRondaAnteriorMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRondaAnteriorMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRondaAnteriorMain.Location = new System.Drawing.Point(228, 374);
            this.btnRondaAnteriorMain.Name = "btnRondaAnteriorMain";
            this.btnRondaAnteriorMain.Size = new System.Drawing.Size(190, 55);
            this.btnRondaAnteriorMain.TabIndex = 7;
            this.btnRondaAnteriorMain.Text = "<<Ronda Anterior";
            this.btnRondaAnteriorMain.UseVisualStyleBackColor = true;
            this.btnRondaAnteriorMain.Click += new System.EventHandler(this.btnRondaAnteriorMain_Click);
            // 
            // btnRondaSiguienteMain
            // 
            this.btnRondaSiguienteMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRondaSiguienteMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRondaSiguienteMain.Location = new System.Drawing.Point(441, 374);
            this.btnRondaSiguienteMain.Name = "btnRondaSiguienteMain";
            this.btnRondaSiguienteMain.Size = new System.Drawing.Size(190, 55);
            this.btnRondaSiguienteMain.TabIndex = 8;
            this.btnRondaSiguienteMain.Text = "Ronda Siguiente>>";
            this.btnRondaSiguienteMain.UseVisualStyleBackColor = true;
            this.btnRondaSiguienteMain.Click += new System.EventHandler(this.btnRondaSiguienteMain_Click);
            // 
            // lblNumeroRondaMain
            // 
            this.lblNumeroRondaMain.AutoSize = true;
            this.lblNumeroRondaMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumeroRondaMain.Location = new System.Drawing.Point(12, 45);
            this.lblNumeroRondaMain.Name = "lblNumeroRondaMain";
            this.lblNumeroRondaMain.Size = new System.Drawing.Size(74, 17);
            this.lblNumeroRondaMain.TabIndex = 0;
            this.lblNumeroRondaMain.Text = "Ronda N°:";
            // 
            // btnIniciarTorneoMain
            // 
            this.btnIniciarTorneoMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIniciarTorneoMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIniciarTorneoMain.Location = new System.Drawing.Point(15, 374);
            this.btnIniciarTorneoMain.Name = "btnIniciarTorneoMain";
            this.btnIniciarTorneoMain.Size = new System.Drawing.Size(190, 55);
            this.btnIniciarTorneoMain.TabIndex = 6;
            this.btnIniciarTorneoMain.Text = "Iniciar Torneo";
            this.btnIniciarTorneoMain.UseVisualStyleBackColor = true;
            this.btnIniciarTorneoMain.Click += new System.EventHandler(this.btnIniciarTorneoMain_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 445);
            this.Controls.Add(this.btnIniciarTorneoMain);
            this.Controls.Add(this.lblNumeroRondaMain);
            this.Controls.Add(this.btnRondaSiguienteMain);
            this.Controls.Add(this.btnRondaAnteriorMain);
            this.Controls.Add(this.btnMostrarTodasLasRondas);
            this.Controls.Add(this.btnCargarResultados);
            this.Controls.Add(this.btnTablaDePosicion);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(885, 484);
            this.Name = "MainForm";
            this.Text = "{Nombre de la aplicación}";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoTorneoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTorneoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelTorneoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónDelTorneoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarJugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeJugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rondasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodasLasRondasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarRondaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarResultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarResultadosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnTablaDePosicion;
        private System.Windows.Forms.Button btnCargarResultados;
        private System.Windows.Forms.Button btnMostrarTodasLasRondas;
        private System.Windows.Forms.Button btnRondaAnteriorMain;
        private System.Windows.Forms.Button btnRondaSiguienteMain;
        private System.Windows.Forms.Label lblNumeroRondaMain;
        private System.Windows.Forms.ToolStripMenuItem iniciarTorneoToolStripMenuItem;
        private System.Windows.Forms.Button btnIniciarTorneoMain;
    }
}

