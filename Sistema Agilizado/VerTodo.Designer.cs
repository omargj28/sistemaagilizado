namespace Sistema_Agilizado
{
    partial class frmVerTodo
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
            this.buttonModificarVerTodo = new System.Windows.Forms.Button();
            this.buttonEliminarVerTodo = new System.Windows.Forms.Button();
            this.buttonSalirVerTodo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonModificarVerTodo
            // 
            this.buttonModificarVerTodo.Location = new System.Drawing.Point(467, 444);
            this.buttonModificarVerTodo.Name = "buttonModificarVerTodo";
            this.buttonModificarVerTodo.Size = new System.Drawing.Size(75, 23);
            this.buttonModificarVerTodo.TabIndex = 0;
            this.buttonModificarVerTodo.Text = "Modificar";
            this.buttonModificarVerTodo.UseVisualStyleBackColor = true;
            this.buttonModificarVerTodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminarVerTodo
            // 
            this.buttonEliminarVerTodo.Location = new System.Drawing.Point(580, 444);
            this.buttonEliminarVerTodo.Name = "buttonEliminarVerTodo";
            this.buttonEliminarVerTodo.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarVerTodo.TabIndex = 1;
            this.buttonEliminarVerTodo.Text = "Eliminar";
            this.buttonEliminarVerTodo.UseVisualStyleBackColor = true;
            this.buttonEliminarVerTodo.Click += new System.EventHandler(this.buttonEliminarVerTodo_Click);
            // 
            // buttonSalirVerTodo
            // 
            this.buttonSalirVerTodo.Location = new System.Drawing.Point(689, 444);
            this.buttonSalirVerTodo.Name = "buttonSalirVerTodo";
            this.buttonSalirVerTodo.Size = new System.Drawing.Size(75, 23);
            this.buttonSalirVerTodo.TabIndex = 2;
            this.buttonSalirVerTodo.Text = "Salir";
            this.buttonSalirVerTodo.UseVisualStyleBackColor = true;
            this.buttonSalirVerTodo.Click += new System.EventHandler(this.buttonSalirVerTodo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 416);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmVerTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSalirVerTodo);
            this.Controls.Add(this.buttonEliminarVerTodo);
            this.Controls.Add(this.buttonModificarVerTodo);
            this.Name = "frmVerTodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerTodo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonModificarVerTodo;
        private System.Windows.Forms.Button buttonEliminarVerTodo;
        private System.Windows.Forms.Button buttonSalirVerTodo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}