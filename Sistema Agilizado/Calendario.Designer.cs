namespace Sistema_Agilizado
{
    partial class Calendario
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
            this.mCalendario = new System.Windows.Forms.MonthCalendar();
            this.tvPedidos = new System.Windows.Forms.TreeView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkPrio3 = new System.Windows.Forms.CheckBox();
            this.chkPrio2 = new System.Windows.Forms.CheckBox();
            this.chkPrio1 = new System.Windows.Forms.CheckBox();
            this.chkPedidos = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mCalendario
            // 
            this.mCalendario.Location = new System.Drawing.Point(17, 18);
            this.mCalendario.Name = "mCalendario";
            this.mCalendario.ShowTodayCircle = false;
            this.mCalendario.TabIndex = 0;
            this.mCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mCalendario_DateSelected);
            // 
            // tvPedidos
            // 
            this.tvPedidos.Location = new System.Drawing.Point(257, 18);
            this.tvPedidos.Name = "tvPedidos";
            this.tvPedidos.Size = new System.Drawing.Size(347, 253);
            this.tvPedidos.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(529, 277);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkPrio3);
            this.panel1.Controls.Add(this.chkPrio2);
            this.panel1.Controls.Add(this.chkPrio1);
            this.panel1.Controls.Add(this.chkPedidos);
            this.panel1.Location = new System.Drawing.Point(17, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 78);
            this.panel1.TabIndex = 5;
            // 
            // chkPrio3
            // 
            this.chkPrio3.AutoSize = true;
            this.chkPrio3.Location = new System.Drawing.Point(9, 58);
            this.chkPrio3.Name = "chkPrio3";
            this.chkPrio3.Size = new System.Drawing.Size(91, 17);
            this.chkPrio3.TabIndex = 3;
            this.chkPrio3.Text = "Prioridad Baja";
            this.chkPrio3.UseVisualStyleBackColor = true;
            this.chkPrio3.CheckStateChanged += new System.EventHandler(this.chkPrio3_CheckStateChanged);
            // 
            // chkPrio2
            // 
            this.chkPrio2.AutoSize = true;
            this.chkPrio2.Location = new System.Drawing.Point(9, 40);
            this.chkPrio2.Name = "chkPrio2";
            this.chkPrio2.Size = new System.Drawing.Size(99, 17);
            this.chkPrio2.TabIndex = 2;
            this.chkPrio2.Text = "Prioridad Media";
            this.chkPrio2.UseVisualStyleBackColor = true;
            this.chkPrio2.CheckStateChanged += new System.EventHandler(this.chkPrio2_CheckStateChanged);
            // 
            // chkPrio1
            // 
            this.chkPrio1.AutoSize = true;
            this.chkPrio1.Location = new System.Drawing.Point(9, 21);
            this.chkPrio1.Name = "chkPrio1";
            this.chkPrio1.Size = new System.Drawing.Size(88, 17);
            this.chkPrio1.TabIndex = 1;
            this.chkPrio1.Text = "Prioridad Alta";
            this.chkPrio1.UseVisualStyleBackColor = true;
            this.chkPrio1.CheckStateChanged += new System.EventHandler(this.chkPrio1_CheckStateChanged);
            // 
            // chkPedidos
            // 
            this.chkPedidos.AutoSize = true;
            this.chkPedidos.Location = new System.Drawing.Point(9, 3);
            this.chkPedidos.Name = "chkPedidos";
            this.chkPedidos.Size = new System.Drawing.Size(114, 17);
            this.chkPedidos.TabIndex = 0;
            this.chkPedidos.Text = "Pedidos Anteriores";
            this.chkPedidos.UseVisualStyleBackColor = true;
            this.chkPedidos.CheckedChanged += new System.EventHandler(this.chkPedidos_CheckedChanged);
            this.chkPedidos.CheckStateChanged += new System.EventHandler(this.chkPedidos_CheckStateChanged);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 305);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tvPedidos);
            this.Controls.Add(this.mCalendario);
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calendario_FormClosed);
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCalendario;
        private System.Windows.Forms.TreeView tvPedidos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkPrio3;
        private System.Windows.Forms.CheckBox chkPrio2;
        private System.Windows.Forms.CheckBox chkPrio1;
        private System.Windows.Forms.CheckBox chkPedidos;
    }
}