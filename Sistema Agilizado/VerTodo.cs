using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Agilizado
{
    public partial class frmVerTodo : Form
    {
        public frmVerTodo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aqui funcion para buscar por id y enviar a form modif antes de cerrar
            string nombre = ActiveForm.Name;
            frmMain form = new frmMain();
            form.Show();
            Application.OpenForms[nombre].Close();
        }

        private void buttonEliminarVerTodo_Click(object sender, EventArgs e)
        {
            //aqui funcion para eliminar un registro, luego recargar
        }

        private void buttonSalirVerTodo_Click(object sender, EventArgs e)
        {
            string nombre = ActiveForm.Name;
            frmMain form = new frmMain();
            form.Show();
            Application.OpenForms[nombre].Close();
        }
    }
}
