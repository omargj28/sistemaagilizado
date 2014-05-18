namespace Sistema_Agilizado
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pbCal = new System.Windows.Forms.PictureBox();
            this.pbMonos = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(175, 126);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pbCal
            // 
            this.pbCal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCal.BackgroundImage")));
            this.pbCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCal.Location = new System.Drawing.Point(42, 22);
            this.pbCal.Name = "pbCal";
            this.pbCal.Size = new System.Drawing.Size(70, 70);
            this.pbCal.TabIndex = 1;
            this.pbCal.TabStop = false;
            this.pbCal.DoubleClick += new System.EventHandler(this.pbCal_DoubleClick);
            // 
            // pbMonos
            // 
            this.pbMonos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMonos.BackgroundImage")));
            this.pbMonos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMonos.Location = new System.Drawing.Point(42, 22);
            this.pbMonos.Name = "pbMonos";
            this.pbMonos.Size = new System.Drawing.Size(70, 70);
            this.pbMonos.TabIndex = 2;
            this.pbMonos.TabStop = false;
            this.pbMonos.Visible = false;
            this.pbMonos.DoubleClick += new System.EventHandler(this.pbMonos_DoubleClick);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(141, 22);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(244, 98);
            this.txtInfo.TabIndex = 3;
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 160);
            this.ControlBox = false;
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.pbCal);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbMonos);
            this.Name = "AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de...";
            this.Load += new System.EventHandler(this.AcercaDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pbCal;
        private System.Windows.Forms.PictureBox pbMonos;
        private System.Windows.Forms.TextBox txtInfo;
    }
}