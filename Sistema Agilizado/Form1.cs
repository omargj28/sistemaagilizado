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
    public partial class frmMain : Form
    {
        AdminDB db = new AdminDB();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            db.Conectar();
            datetimeFechaRegistroMain.Value = DateTime.Today;
            datetimeFechaEntregaMain.Value = DateTime.Today.AddDays(1);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombre = ActiveForm.Name;
            frmMain form = new frmMain();
            form.Show();
            Application.OpenForms[nombre].Close();
        }

        private void verTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombre = ActiveForm.Name;
            frmVerTodo verTodo = new frmVerTodo();
            verTodo.Show();
            Application.OpenForms[nombre].Close();
        }

        private void btnRegistrarMain_Click(object sender, EventArgs e)
        {
            DateTime fechaRegistro = datetimeFechaRegistroMain.Value;
            DateTime fechaEntrega = datetimeFechaEntregaMain.Value;
            try
            {
                db.insertaPedidos(txtNombreMain.Text, fechaRegistro, fechaEntrega, chkDiseño.Checked, chkTarjetas.Checked, chkPagina.Checked, chkFolletos.Checked, chkVolantes.Checked, chkImpresion.Checked, chkIFolletos.Checked, chkITarjetas.Checked, chkIVolantes.Checked);
                db.Desconectar();
                MessageBox.Show("Pedido agregado correctamente");
                nuevoToolStripMenuItem_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al momento de agregar: " + ex.Message);
            }
        }

        private void txtNombreMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.textValidatorNombres(sender, e);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Funciones.CerrarVentanas(null, null);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe();
            acerca.ShowDialog();
        }
    }
}
