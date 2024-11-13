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
    public partial class UC_Clientes : UserControl
    {
        public List<Cliente> clientes = new List<Cliente>();
        public UC_Clientes()
        {
            InitializeComponent();

            Cliente clienteA = new Cliente("Juan", "Perez", "43932843", 25, "3644320869", "Las Heras 708", "randomMail@mail.com", 3824524, DateTime.Now);
            Cliente clienteB = new Cliente("Jorge", "Perez", "43932849", 25, "3644320869", "Las Heras 708", "randomMail@mail.com", 3824524, DateTime.Now);
            Cliente clienteC = new Cliente("Manolo", "Perez", "43932843", 25, "3644320869", "Las Heras 708", "randomMail@mail.com", 3824524, DateTime.Now);

            clientes.Add(clienteA);
            clientes.Add(clienteB);
            clientes.Add(clienteC);

            // Setteando el datasource para que utilice los atributos de la clase Cliente
            dataGridViewClientes.DataSource = clientes;
        }


        private void buttonNuevoCliente_Click(object sender, EventArgs e)
        {
            FormNuevoCliente formNuevoCliente = new FormNuevoCliente();
            formNuevoCliente.ReferenciaUC_Clientes = this;
            formNuevoCliente.Show();
        }

        public void AgregarClienteDataGridView(Cliente cliente)
        {
            clientes.Add(cliente);

            // Refrescar dataGridView setteando en null
            dataGridViewClientes.DataSource = null;

            // Volviendo a llenar el dataGridView para que aparezca nuevo cliente agregado
            dataGridViewClientes.DataSource = this.clientes;
        }
    }
}
