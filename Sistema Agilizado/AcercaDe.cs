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
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void pbCal_DoubleClick(object sender, EventArgs e)
        {
            pbCal.Visible = false;
            pbMonos.Visible = true;
            txtInfo.Text = "Hecho para Erika, con cariño: \n\r\n\r\nlos monos y el scrum master";
        }

        private void pbMonos_DoubleClick(object sender, EventArgs e)
        {
            pbCal.Visible = true;
            pbMonos.Visible = false;
            txtInfo.Text = "Desarrollado por: \n\r\n\n\r\nJorge Álvarez\n\r\nRubén Casillas\n\r\nOmar García\n\r\nIvan Márquez\n\r\nErika Rodríguez";
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {
            txtInfo.Text = "Desarrollado por: \n\r\n\n\r\nJorge Álvarez\n\r\nRubén Casillas\n\r\nOmar García\n\r\nIvan Márquez\n\r\nErika Rodríguez";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
