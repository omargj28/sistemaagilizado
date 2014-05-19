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
        AdminDB db = new AdminDB();
        public frmVerTodo()
        {
            InitializeComponent();
        }

        private void frmVerTodo_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = db.BuscarPedidos();
                dgvPedidos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al momento de cargar pedidos: " + ex.Message);
            }
            finally
            {
                if (dgvPedidos.Rows.Count != 0)
                { buttonModificarVerTodo.Enabled = true; buttonEliminarVerTodo.Enabled = true; }
                else { buttonModificarVerTodo.Enabled = false; buttonEliminarVerTodo.Enabled = false; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IDPedido = int.Parse(dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells["IDPedido"].Value.ToString());
            DataTable dt = db.BuscarPedidos(IDPedido);
            string nombre = ActiveForm.Name;
            frmModificar form = new frmModificar();
            form.Pedido = dt;
            form.Show();
            Application.OpenForms[nombre].Close();
        }

        private void buttonEliminarVerTodo_Click(object sender, EventArgs e)
        {
            string pedido = dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells["IDPedido"].Value.ToString();
            DialogResult resultado = MessageBox.Show("¿Eliminar pedido " + pedido + "?", "Eliminar", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                int IDPedido = int.Parse(pedido);
                try
                {
                    db.EliminarPedidos(IDPedido);
                    MessageBox.Show("Pedido eliminado correctamente");
                    frmVerTodo_Load(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al momento de eliminar pedido: " + ex.Message);
                }
            }
        }

        private void buttonSalirVerTodo_Click(object sender, EventArgs e)
        {
            string nombre = ActiveForm.Name;
            frmMain form = new frmMain();
            form.Show();
            Application.OpenForms[nombre].Close();
        }

        private void frmVerTodo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Funciones.CerrarVentanas(null, null);
        }
    }
}
