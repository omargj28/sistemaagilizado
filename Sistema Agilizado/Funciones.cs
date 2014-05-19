using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Agilizado
{
    public static class Funciones
    {

        public static void LimpiarControles(System.Windows.Forms.Control.ControlCollection controlCollection)
        {
            foreach (Control objControl in controlCollection)
            {
                LimpiarControles(objControl);
            }
        }

        public static void LimpiarControles(Control controlCollection)
        {
            foreach (Control objControl in controlCollection.Controls)
            {
                if (objControl is TextBox)
                {
                    TextBox ctrl = (TextBox)objControl;
                    ctrl.Text = "";
                }

                else if (objControl is ListBox)
                {
                    //
                }
                else if (objControl is CheckBox)
                {
                    CheckBox ctrl = (CheckBox)objControl;
                    ctrl.Checked = false;
                }
                else if (objControl is ComboBox)
                {
                    ComboBox ctrl = (ComboBox)objControl;
                    if (ctrl.Items.Count > 0)
                    {
                        ctrl.SelectedIndex = 0;
                    }
                }
            }
        }

        public static void textValidatorNombres(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'z' || e.KeyChar == '\r' || e.KeyChar == '-' || e.KeyChar == '\b' || e.KeyChar == ' ' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten letras (A-Z), números, y guiones \"-\"");
                e.Handled = true;
            }
        }

        public static void CerrarVentanas(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count < 1)
            {
                Application.Exit();
            }
        }
    }
}