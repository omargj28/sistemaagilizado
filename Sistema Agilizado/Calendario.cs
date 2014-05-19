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
    public partial class Calendario : Form
    {
        AdminDB db = new AdminDB();
        DataTable pedidos;
        bool checar = false;
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            chkPrio1.Checked = true;
            chkPrio2.Checked = true;
            chkPrio3.Checked = true;
            ObtenerPedidos(); 
            checar = true;
            DesplegarFechas();
            ComprobarPedidosProx();
        }

        private void ObtenerPedidos()
        {
            try
            {
                pedidos = db.BuscarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al momento de obtener los pedidos: " + ex.Message);
            }
        }

        private void DesplegarFechas()
        {
            if (pedidos.Rows.Count > 0)
            {
                DateTime[] fechas = new DateTime[pedidos.Rows.Count];
                mCalendario.BoldedDates = null;
                for (int i = 0; i < pedidos.Rows.Count; i++)
                {
                    DataRow pedido = pedidos.Rows[i];
                    DateTime fecha = Convert.ToDateTime(pedido["Fecha_entrega"].ToString());
                    
                    if (chkPedidos.Checked)
                    {
                        int elementoPrioridad = ComprobarPrioridad(pedido);
                        switch (elementoPrioridad)
                        {
                            case 1:
                                if (chkPrio1.Checked)
                                { fechas[i] = fecha; }
                                break;
                            case 2:
                                if (chkPrio2.Checked)
                                { fechas[i] = fecha; }
                                break;
                            case 3:
                                if (chkPrio3.Checked)
                                { fechas[i] = fecha; }
                                break;
                        }
                    }
                    else
                    {
                        if (ComprobarPedidoPendiente(fecha))
                        {
                            int elementoPrioridad = ComprobarPrioridad(pedido);
                            switch (elementoPrioridad)
                            {
                                case 1:
                                    if (chkPrio1.Checked)
                                    { fechas[i] = fecha; }
                                    break;
                                case 2:
                                    if (chkPrio2.Checked)
                                    { fechas[i] = fecha; }
                                    break;
                                case 3:
                                    if (chkPrio3.Checked)
                                    { fechas[i] = fecha; }
                                    break;
                            }
                        }
                    }
                }
                mCalendario.BoldedDates = fechas;
            }
        }

        private Boolean ComprobarPedidoPendiente(DateTime fecha)
        {
            if (fecha < mCalendario.TodayDate) { return false; }
            else { return true; }
        }

        private int ComprobarPrioridad(DataRow pedido)
        {
            int Diseño = (bool)pedido["Diseño"] == true ? 1 : 0;
            int Tarjetas = (bool)pedido["Tarjetas"] == true ? 1 : 0;
            int Web = (bool)pedido["Web"] == true ? 1 : 0;
            int Folletos = (bool)pedido["Folletos"] == true ? 1 : 0;
            int Volantes = (bool)pedido["Volantes"] == true ? 1 : 0;
            int Impresion = (bool)pedido["Impresion"] == true ? 1 : 0;
            int IFolletos = (bool)pedido["IFolletos"] == true ? 1 : 0;
            int ITarjetas = (bool)pedido["ITarjetas"] == true ? 1 : 0;
            int IVolantes = (bool)pedido["IVolantes"] == true ? 1 : 0;

            int prioridad = Diseño + Tarjetas + Web + Folletos + Volantes + Impresion + IFolletos + ITarjetas + IVolantes;

            if (prioridad > 6)
            { return 1; }
            else if (prioridad > 3)
            { return 2; }
            else
            { return 3; }
        }

        private void mCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            string dia = e.Start.ToShortDateString();
            tvPedidos.Nodes.Clear();
            for (int i = 0; i < pedidos.Rows.Count; i++)
            {
                DataRow pedido = pedidos.Rows[i];
                DateTime fecha = mCalendario.BoldedDates[i];
                string diaCal = fecha.ToShortDateString();
                if (dia == diaCal)
                {
                    string nombre = pedido["Nombre"].ToString();
                    tvPedidos.Nodes.Add(nombre, nombre);

                    string Diseño = (bool)pedido["Diseño"] == true ? "Sí" : "No";
                    string Tarjetas = (bool)pedido["Tarjetas"] == true ? "Sí" : "No";
                    string Web = (bool)pedido["Web"] == true ? "Sí" : "No";
                    string Folletos = (bool)pedido["Folletos"] == true ? "Sí" : "No";
                    string Volantes = (bool)pedido["Volantes"] == true ? "Sí" : "No";
                    string Impresion = (bool)pedido["Impresion"] == true ? "Sí" : "No";
                    string IFolletos = (bool)pedido["IFolletos"] == true ? "Sí" : "No";
                    string ITarjetas = (bool)pedido["ITarjetas"] == true ? "Sí" : "No";
                    string IVolantes = (bool)pedido["IVolantes"] == true ? "Sí" : "No";

                    tvPedidos.Nodes[nombre].Nodes.Add("Fecha de registro: " + (pedido["Fecha_reg"].ToString()));
                    tvPedidos.Nodes[nombre].Nodes.Add("Fecha de entrega: " + (pedido["Fecha_entrega"].ToString()));
                    tvPedidos.Nodes[nombre].Nodes.Add("Diseño: " + Diseño);
                    tvPedidos.Nodes[nombre].Nodes.Add("Tarjetas: " + Tarjetas);
                    tvPedidos.Nodes[nombre].Nodes.Add("Web: " + Web);
                    tvPedidos.Nodes[nombre].Nodes.Add("Folletos: " + Folletos);
                    tvPedidos.Nodes[nombre].Nodes.Add("Volantes: " + Volantes);
                    tvPedidos.Nodes[nombre].Nodes.Add("Impresión: " + Impresion);
                    tvPedidos.Nodes[nombre].Nodes.Add("Impresión folletos: " + IFolletos);
                    tvPedidos.Nodes[nombre].Nodes.Add("Impresión tarjetas:" + ITarjetas);
                    tvPedidos.Nodes[nombre].Nodes.Add("Impresión volantes:" + IVolantes);
                }
            }
        }

        private void ComprobarPedidosProx()
        {
            DateTime despues = mCalendario.TodayDate.AddSeconds(259199);
            for (int i = 0; i < mCalendario.BoldedDates.Length; i++)
            {
                if (mCalendario.BoldedDates[i] > mCalendario.TodayDate && mCalendario.BoldedDates[i] < despues || mCalendario.BoldedDates[i] == mCalendario.TodayDate)
                {
                    MessageBox.Show("Hay pedidos próximos a entregar, favor de verificar en calendario");
                    break;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            string nombre = ActiveForm.Name;
            frmMain form = new frmMain();
            form.Show();
            Application.OpenForms[nombre].Close();
        }

        private void Calendario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Funciones.CerrarVentanas(null, null);
        }

        private void chkPedidos_CheckedChanged(object sender, EventArgs e)
        {
            if (checar)
            {
                tvPedidos.Nodes.Clear();
                DesplegarFechas();
            }
        }

        private void chkPedidos_CheckStateChanged(object sender, EventArgs e)
        {
            chkPedidos_CheckedChanged(null, null);
        }

        private void chkPrio1_CheckStateChanged(object sender, EventArgs e)
        {
            chkPedidos_CheckedChanged(null, null);
        }

        private void chkPrio2_CheckStateChanged(object sender, EventArgs e)
        {
            chkPedidos_CheckedChanged(null, null);
        }

        private void chkPrio3_CheckStateChanged(object sender, EventArgs e)
        {
            chkPedidos_CheckedChanged(null, null);
        }
    }
}
