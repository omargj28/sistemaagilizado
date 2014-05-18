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
    public partial class frmModificar : Form
    {
        AdminDB db = new AdminDB();
        int IDPedido = 0;
        private DataTable pedido = new DataTable();

        public DataTable Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }

        public frmModificar()
        {
            InitializeComponent();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
            //guardar el id
            //IDPedido = 0;
            //llenar campos desde el DataTable
        }

        private void btnRegistrarMain_Click(object sender, EventArgs e)
        {
            DateTime fechaRegistro = datetimeFechaRegistroMain.Value;
            DateTime fechaEntrega = datetimeFechaEntregaMain.Value;
            try
            {
                db.actualizaPedidos(IDPedido, txtNombreMain.Text, fechaRegistro, fechaEntrega, chkDiseño.Checked, chkTarjetas.Checked, chkPagina.Checked, chkFolletos.Checked, chkVolantes.Checked, chkImpresion.Checked, chkIFolletos.Checked, chkITarjetas.Checked, chkIVolantes.Checked);
                db.Desconectar();
                string nombre = ActiveForm.Name;
                MessageBox.Show("Pedido modificado correctamente");
                frmVerTodo verTodo = new frmVerTodo();
                verTodo.Show();
                Application.OpenForms[nombre].Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al momento de modificar: " + ex.Message);
            }
        }

        private void txtNombreMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.textValidatorNombres(sender, e);
        }

        private void frmModificar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Funciones.CerrarVentanas(null, null);
        }
    }
}
