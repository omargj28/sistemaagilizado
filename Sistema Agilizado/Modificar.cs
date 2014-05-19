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
            IDPedido = int.Parse(Pedido.Rows[0]["IDPedido"].ToString());
            txtNombreMain.Text = Pedido.Rows[0]["Nombre"].ToString();
            datetimeFechaRegistroMain.Value = Convert.ToDateTime(Pedido.Rows[0]["Fecha_reg"].ToString());
            datetimeFechaEntregaMain.Value = Convert.ToDateTime(Pedido.Rows[0]["Fecha_entrega"].ToString());
            chkDiseño.Checked = (bool)Pedido.Rows[0]["Diseño"];
            chkTarjetas.Checked = (bool)Pedido.Rows[0]["Tarjetas"];
            chkPagina.Checked = (bool)Pedido.Rows[0]["Web"];
            chkFolletos.Checked = (bool)Pedido.Rows[0]["Folletos"];
            chkVolantes.Checked = (bool)Pedido.Rows[0]["Volantes"];
            chkImpresion.Checked = (bool)Pedido.Rows[0]["Impresion"];
            chkIFolletos.Checked = (bool)Pedido.Rows[0]["IFolletos"];
            chkITarjetas.Checked = (bool)Pedido.Rows[0]["ITarjetas"];
            chkIVolantes.Checked = (bool)Pedido.Rows[0]["IVolantes"];
        }

        private void btnRegistrarMain_Click(object sender, EventArgs e)
        {
            DateTime fechaRegistro = datetimeFechaRegistroMain.Value;
            DateTime fechaEntrega = datetimeFechaEntregaMain.Value;
            try
            {
                db.ActualizarPedidos(IDPedido, txtNombreMain.Text, fechaRegistro, fechaEntrega, chkDiseño.Checked, chkTarjetas.Checked, chkPagina.Checked, chkFolletos.Checked, chkVolantes.Checked, chkImpresion.Checked, chkIFolletos.Checked, chkITarjetas.Checked, chkIVolantes.Checked);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string nombre = ActiveForm.Name;
            frmVerTodo verTodo = new frmVerTodo();
            verTodo.Show();
            Application.OpenForms[nombre].Close();
        }
    }
}
