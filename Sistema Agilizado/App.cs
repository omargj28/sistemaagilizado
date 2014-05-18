using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Agilizado
{
    public class App : System.Windows.Forms.ApplicationContext
    {
        public App()
        {
            frmMain form = new frmMain();
            form.Show();
        }
    }
}
