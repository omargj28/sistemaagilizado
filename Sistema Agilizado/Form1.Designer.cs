namespace Sistema_Agilizado
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoMain = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaMain = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkImpresion = new System.Windows.Forms.CheckBox();
            this.chkDiseño = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkIVolantes = new System.Windows.Forms.CheckBox();
            this.chkITarjetas = new System.Windows.Forms.CheckBox();
            this.chkIFolletos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTarjetas = new System.Windows.Forms.CheckBox();
            this.chkVolantes = new System.Windows.Forms.CheckBox();
            this.chkFolletos = new System.Windows.Forms.CheckBox();
            this.chkPagina = new System.Windows.Forms.CheckBox();
            this.btnRegistrarMain = new System.Windows.Forms.Button();
            this.datetimeFechaEntregaMain = new System.Windows.Forms.DateTimePicker();
            this.datetimeFechaRegistroMain = new System.Windows.Forms.DateTimePicker();
            this.txtNombreMain = new System.Windows.Forms.TextBox();
            this.labelServiciosMain = new System.Windows.Forms.Label();
            this.labelFechaEntregaMain = new System.Windows.Forms.Label();
            this.labelFechaRegistroMain = new System.Windows.Forms.Label();
            this.labelNombreMain = new System.Windows.Forms.Label();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoMain,
            this.AyudaMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArchivoMain
            // 
            this.ArchivoMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.verTodoToolStripMenuItem});
            this.ArchivoMain.Name = "ArchivoMain";
            this.ArchivoMain.Size = new System.Drawing.Size(60, 20);
            this.ArchivoMain.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // verTodoToolStripMenuItem
            // 
            this.verTodoToolStripMenuItem.Name = "verTodoToolStripMenuItem";
            this.verTodoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verTodoToolStripMenuItem.Text = "Ver Todo";
            this.verTodoToolStripMenuItem.Click += new System.EventHandler(this.verTodoToolStripMenuItem_Click);
            // 
            // AyudaMain
            // 
            this.AyudaMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.AyudaMain.Name = "AyudaMain";
            this.AyudaMain.Size = new System.Drawing.Size(53, 20);
            this.AyudaMain.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkImpresion);
            this.panel1.Controls.Add(this.chkDiseño);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnRegistrarMain);
            this.panel1.Controls.Add(this.datetimeFechaEntregaMain);
            this.panel1.Controls.Add(this.datetimeFechaRegistroMain);
            this.panel1.Controls.Add(this.txtNombreMain);
            this.panel1.Controls.Add(this.labelServiciosMain);
            this.panel1.Controls.Add(this.labelFechaEntregaMain);
            this.panel1.Controls.Add(this.labelFechaRegistroMain);
            this.panel1.Controls.Add(this.labelNombreMain);
            this.panel1.Location = new System.Drawing.Point(49, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 318);
            this.panel1.TabIndex = 1;
            // 
            // chkImpresion
            // 
            this.chkImpresion.AutoSize = true;
            this.chkImpresion.Location = new System.Drawing.Point(269, 142);
            this.chkImpresion.Name = "chkImpresion";
            this.chkImpresion.Size = new System.Drawing.Size(71, 17);
            this.chkImpresion.TabIndex = 20;
            this.chkImpresion.Text = "Impresión";
            this.chkImpresion.UseVisualStyleBackColor = true;
            // 
            // chkDiseño
            // 
            this.chkDiseño.AutoSize = true;
            this.chkDiseño.Location = new System.Drawing.Point(126, 142);
            this.chkDiseño.Name = "chkDiseño";
            this.chkDiseño.Size = new System.Drawing.Size(59, 17);
            this.chkDiseño.TabIndex = 19;
            this.chkDiseño.Text = "Diseño";
            this.chkDiseño.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkIVolantes);
            this.groupBox2.Controls.Add(this.chkITarjetas);
            this.groupBox2.Controls.Add(this.chkIFolletos);
            this.groupBox2.Location = new System.Drawing.Point(243, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 150);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // chkIVolantes
            // 
            this.chkIVolantes.AutoSize = true;
            this.chkIVolantes.Location = new System.Drawing.Point(26, 92);
            this.chkIVolantes.Name = "chkIVolantes";
            this.chkIVolantes.Size = new System.Drawing.Size(67, 17);
            this.chkIVolantes.TabIndex = 19;
            this.chkIVolantes.Text = "Volantes";
            this.chkIVolantes.UseVisualStyleBackColor = true;
            // 
            // chkITarjetas
            // 
            this.chkITarjetas.AutoSize = true;
            this.chkITarjetas.Location = new System.Drawing.Point(26, 56);
            this.chkITarjetas.Name = "chkITarjetas";
            this.chkITarjetas.Size = new System.Drawing.Size(64, 17);
            this.chkITarjetas.TabIndex = 18;
            this.chkITarjetas.Text = "Tarjetas";
            this.chkITarjetas.UseVisualStyleBackColor = true;
            // 
            // chkIFolletos
            // 
            this.chkIFolletos.AutoSize = true;
            this.chkIFolletos.Location = new System.Drawing.Point(26, 22);
            this.chkIFolletos.Name = "chkIFolletos";
            this.chkIFolletos.Size = new System.Drawing.Size(62, 17);
            this.chkIFolletos.TabIndex = 17;
            this.chkIFolletos.Text = "Folletos";
            this.chkIFolletos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTarjetas);
            this.groupBox1.Controls.Add(this.chkVolantes);
            this.groupBox1.Controls.Add(this.chkFolletos);
            this.groupBox1.Controls.Add(this.chkPagina);
            this.groupBox1.Location = new System.Drawing.Point(107, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 150);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // chkTarjetas
            // 
            this.chkTarjetas.AutoSize = true;
            this.chkTarjetas.Location = new System.Drawing.Point(19, 22);
            this.chkTarjetas.Name = "chkTarjetas";
            this.chkTarjetas.Size = new System.Drawing.Size(64, 17);
            this.chkTarjetas.TabIndex = 14;
            this.chkTarjetas.Text = "Tarjetas";
            this.chkTarjetas.UseVisualStyleBackColor = true;
            // 
            // chkVolantes
            // 
            this.chkVolantes.AutoSize = true;
            this.chkVolantes.Location = new System.Drawing.Point(19, 125);
            this.chkVolantes.Name = "chkVolantes";
            this.chkVolantes.Size = new System.Drawing.Size(67, 17);
            this.chkVolantes.TabIndex = 17;
            this.chkVolantes.Text = "Volantes";
            this.chkVolantes.UseVisualStyleBackColor = true;
            // 
            // chkFolletos
            // 
            this.chkFolletos.AutoSize = true;
            this.chkFolletos.Location = new System.Drawing.Point(19, 92);
            this.chkFolletos.Name = "chkFolletos";
            this.chkFolletos.Size = new System.Drawing.Size(62, 17);
            this.chkFolletos.TabIndex = 16;
            this.chkFolletos.Text = "Folletos";
            this.chkFolletos.UseVisualStyleBackColor = true;
            // 
            // chkPagina
            // 
            this.chkPagina.AutoSize = true;
            this.chkPagina.Location = new System.Drawing.Point(19, 56);
            this.chkPagina.Name = "chkPagina";
            this.chkPagina.Size = new System.Drawing.Size(85, 17);
            this.chkPagina.TabIndex = 15;
            this.chkPagina.Text = "Página Web";
            this.chkPagina.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMain
            // 
            this.btnRegistrarMain.Location = new System.Drawing.Point(376, 286);
            this.btnRegistrarMain.Name = "btnRegistrarMain";
            this.btnRegistrarMain.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarMain.TabIndex = 16;
            this.btnRegistrarMain.Text = "Registrar";
            this.btnRegistrarMain.UseVisualStyleBackColor = true;
            this.btnRegistrarMain.Click += new System.EventHandler(this.btnRegistrarMain_Click);
            // 
            // datetimeFechaEntregaMain
            // 
            this.datetimeFechaEntregaMain.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.datetimeFechaEntregaMain.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeFechaEntregaMain.Location = new System.Drawing.Point(106, 109);
            this.datetimeFechaEntregaMain.Name = "datetimeFechaEntregaMain";
            this.datetimeFechaEntregaMain.Size = new System.Drawing.Size(345, 20);
            this.datetimeFechaEntregaMain.TabIndex = 6;
            // 
            // datetimeFechaRegistroMain
            // 
            this.datetimeFechaRegistroMain.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.datetimeFechaRegistroMain.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeFechaRegistroMain.Location = new System.Drawing.Point(106, 69);
            this.datetimeFechaRegistroMain.Name = "datetimeFechaRegistroMain";
            this.datetimeFechaRegistroMain.Size = new System.Drawing.Size(345, 20);
            this.datetimeFechaRegistroMain.TabIndex = 5;
            // 
            // txtNombreMain
            // 
            this.txtNombreMain.Location = new System.Drawing.Point(106, 31);
            this.txtNombreMain.MaxLength = 50;
            this.txtNombreMain.Name = "txtNombreMain";
            this.txtNombreMain.Size = new System.Drawing.Size(345, 20);
            this.txtNombreMain.TabIndex = 4;
            this.txtNombreMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMain_KeyPress);
            // 
            // labelServiciosMain
            // 
            this.labelServiciosMain.AutoSize = true;
            this.labelServiciosMain.Location = new System.Drawing.Point(49, 153);
            this.labelServiciosMain.Name = "labelServiciosMain";
            this.labelServiciosMain.Size = new System.Drawing.Size(53, 13);
            this.labelServiciosMain.TabIndex = 3;
            this.labelServiciosMain.Text = "Servicios:";
            // 
            // labelFechaEntregaMain
            // 
            this.labelFechaEntregaMain.AutoSize = true;
            this.labelFechaEntregaMain.Location = new System.Drawing.Point(8, 110);
            this.labelFechaEntregaMain.Name = "labelFechaEntregaMain";
            this.labelFechaEntregaMain.Size = new System.Drawing.Size(95, 13);
            this.labelFechaEntregaMain.TabIndex = 2;
            this.labelFechaEntregaMain.Text = "Fecha de Entrega:";
            // 
            // labelFechaRegistroMain
            // 
            this.labelFechaRegistroMain.AutoSize = true;
            this.labelFechaRegistroMain.Location = new System.Drawing.Point(6, 70);
            this.labelFechaRegistroMain.Name = "labelFechaRegistroMain";
            this.labelFechaRegistroMain.Size = new System.Drawing.Size(97, 13);
            this.labelFechaRegistroMain.TabIndex = 1;
            this.labelFechaRegistroMain.Text = "Fecha de Registro:";
            // 
            // labelNombreMain
            // 
            this.labelNombreMain.AutoSize = true;
            this.labelNombreMain.Location = new System.Drawing.Point(55, 32);
            this.labelNombreMain.Name = "labelNombreMain";
            this.labelNombreMain.Size = new System.Drawing.Size(47, 13);
            this.labelNombreMain.TabIndex = 0;
            this.labelNombreMain.Text = "Nombre:";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planificador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ArchivoMain;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelServiciosMain;
        private System.Windows.Forms.Label labelFechaEntregaMain;
        private System.Windows.Forms.Label labelFechaRegistroMain;
        private System.Windows.Forms.Label labelNombreMain;
        private System.Windows.Forms.DateTimePicker datetimeFechaEntregaMain;
        private System.Windows.Forms.DateTimePicker datetimeFechaRegistroMain;
        private System.Windows.Forms.TextBox txtNombreMain;
        private System.Windows.Forms.ToolStripMenuItem AyudaMain;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnRegistrarMain;
        private System.Windows.Forms.CheckBox chkImpresion;
        private System.Windows.Forms.CheckBox chkDiseño;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkIVolantes;
        private System.Windows.Forms.CheckBox chkITarjetas;
        private System.Windows.Forms.CheckBox chkIFolletos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkVolantes;
        private System.Windows.Forms.CheckBox chkFolletos;
        private System.Windows.Forms.CheckBox chkPagina;
        private System.Windows.Forms.CheckBox chkTarjetas;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
    }
}

