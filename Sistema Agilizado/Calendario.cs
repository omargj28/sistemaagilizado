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
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            clbPrioridad.Items.Add("Pedidos anteriores");
            clbPrioridad.Items.Add("Prioridad Alta");
            clbPrioridad.Items.Add("Prioridad Media");
            clbPrioridad.Items.Add("Prioridad Baja");
            clbPrioridad.SetItemChecked(0, false);
            clbPrioridad.SetItemChecked(1, true);
            clbPrioridad.SetItemChecked(2, true);
            clbPrioridad.SetItemChecked(3, true);
            //DesplegarFechas(mCalendario.TodayDate.Month);
            DesplegarFechas();
        }

        //private void DesplegarFechas(int mes)
        //{
        //    pedidos = db.BuscarPedidosPorMes(mes);
        //    if (pedidos.Rows.Count > 0)
        //    {
        //        DateTime[] fechas = new DateTime[pedidos.Rows.Count];
        //        for (int i = 0; i < pedidos.Rows.Count; i++)
        //        {
        //            DataRow pedido = pedidos.Rows[i];
        //            DateTime fecha = Convert.ToDateTime(pedido["Fecha_entrega"].ToString());
        //            fechas[i] = fecha;
        //        }
        //        mCalendario.BoldedDates = fechas;
        //    }
        //}

        private void DesplegarFechas()
        {
            pedidos = db.BuscarPedidos();
            if (pedidos.Rows.Count > 0)
            {
                DateTime[] fechas = new DateTime[pedidos.Rows.Count];
                for (int i = 0; i < pedidos.Rows.Count; i++)
                {
                    DataRow pedido = pedidos.Rows[i];
                    DateTime fecha = Convert.ToDateTime(pedido["Fecha_entrega"].ToString());
                    
                    //si el boton pedidos anteriores esta seleccionado, no filtrar por fecha, pasar por filtro de prioridades

                    //

                    //si no esta seleccionado

                    //
                    if (ComprobarPedidoPendiente(fecha))
                    {
                        int prioridad = ComprobarPrioridad(pedido);
                        
                    }
                    else
                    {
                        //pos no lo muestres
                    }

                    fechas[i] = fecha;
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
            int prioridad = 0;
            prioridad += (int)pedido["Diseño"];
            prioridad += (int)pedido["Tarjetas"];
            prioridad += (int)pedido["Web"];
            prioridad += (int)pedido["Folletos"];
            prioridad += (int)pedido["Volantes"];
            prioridad += (int)pedido["Impresion"];
            prioridad += (int)pedido["IFolletos"];
            prioridad += (int)pedido["ITarjetas"];
            prioridad += (int)pedido["IVolantes"];
            if (prioridad > 6)
            { prioridad = 1; }
            else if (prioridad > 3)
            { prioridad = 2; }
            else
            { prioridad = 3; }
            return prioridad;
        }

        private void mCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            //al seleccionar fecha imprimir los datos del pedido en el treeview
            string dia = e.Start.ToShortDateString();
            tvPedidos.Nodes.Clear();
            for (int i = 0; i < pedidos.Rows.Count; i++)
            {
                DataRow pedido = pedidos.Rows[i];
                DateTime fecha = Convert.ToDateTime(pedido["Fecha_entrega"].ToString());
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

        private void mCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            //DesplegarFechas(e.Start.Month);
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
    }
}
