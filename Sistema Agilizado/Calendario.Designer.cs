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
            this.clbPrioridad = new System.Windows.Forms.CheckedListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mCalendario
            // 
            this.mCalendario.Location = new System.Drawing.Point(17, 18);
            this.mCalendario.Name = "mCalendario";
            this.mCalendario.ShowTodayCircle = false;
            this.mCalendario.TabIndex = 0;
            this.mCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalendario_DateChanged);
            this.mCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mCalendario_DateSelected);
            // 
            // tvPedidos
            // 
            this.tvPedidos.Location = new System.Drawing.Point(257, 18);
            this.tvPedidos.Name = "tvPedidos";
            this.tvPedidos.Size = new System.Drawing.Size(347, 253);
            this.tvPedidos.TabIndex = 1;
            // 
            // clbPrioridad
            // 
            this.clbPrioridad.FormattingEnabled = true;
            this.clbPrioridad.Location = new System.Drawing.Point(17, 192);
            this.clbPrioridad.Name = "clbPrioridad";
            this.clbPrioridad.Size = new System.Drawing.Size(227, 79);
            this.clbPrioridad.TabIndex = 2;
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
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 305);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.clbPrioridad);
            this.Controls.Add(this.tvPedidos);
            this.Controls.Add(this.mCalendario);
            this.Name = "Calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calendario_FormClosed);
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCalendario;
        private System.Windows.Forms.TreeView tvPedidos;
        private System.Windows.Forms.CheckedListBox clbPrioridad;
        private System.Windows.Forms.Button btnCerrar;
    }
}