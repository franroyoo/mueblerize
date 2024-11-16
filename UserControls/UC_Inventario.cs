using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mueblerize.UserControls
{
    public partial class UC_Inventario : UserControl
    {
        public UC_Inventario()
        {
            InitializeComponent();
        }

        private void buttonNuevoIngreso_Click(object sender, EventArgs e)
        {
            FormNuevoIngreso formNuevoIngreso = new FormNuevoIngreso();
            formNuevoIngreso.Show();
        }
    }
}
