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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonModificarVerTodo = new System.Windows.Forms.Button();
            this.buttonEliminarVerTodo = new System.Windows.Forms.Button();
            this.buttonSalirVerTodo = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
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
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 12);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(752, 416);
            this.dgvPedidos.TabIndex = 3;
            // 
            // frmVerTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 479);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.buttonSalirVerTodo);
            this.Controls.Add(this.buttonEliminarVerTodo);
            this.Controls.Add(this.buttonModificarVerTodo);
            this.Name = "frmVerTodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerTodo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVerTodo_FormClosed);
            this.Load += new System.EventHandler(this.frmVerTodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonModificarVerTodo;
        private System.Windows.Forms.Button buttonEliminarVerTodo;
        private System.Windows.Forms.Button buttonSalirVerTodo;
        private System.Windows.Forms.DataGridView dgvPedidos;
    }
}