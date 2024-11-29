using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mueblerize.Modelo;

namespace Mueblerize.UserControls
{
    public partial class UC_Clientes : UserControl
    {
        public List<Cliente> clientes = new List<Cliente>();
        public UC_Ventas ReferenciaUC_Ventas { get; set; }
        public UC_Clientes()
        {
            InitializeComponent();

            // Settear la referencia al UC_Ventas, que se usará en caso de que se quiera modificar datos de un cliente


            // Crear clientes iniciales 

            Cliente clienteA = new Cliente("Juan", "Perez", "43932843", 25, "3645220869", "Avenida Siempre Viva 49", "randomMail@mail.com", 3824524, DateTime.Now);
            Cliente clienteB = new Cliente("Jorge", "Cuasimodo", "43932849", 25, "364420869", "Calle falsa 123", "randomMail@mail.com", 3824524, DateTime.Now);
            Cliente clienteC = new Cliente("Manolo", "Rodriguez", "43932845", 25, "3644320869", "Avendida San Martin 201", "randomMail@mail.com", 3824524, DateTime.Now);

            clientes.Add(clienteA);
            clientes.Add(clienteB);
            clientes.Add(clienteC);

            

            // Boton para eliminar un cliente

            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn
            {
                Name = "btnModificar",
                HeaderText = "MODIFICAR",
                Text = "MODIFICAR",
                UseColumnTextForButtonValue = true
            };

            dataGridViewClientes.Columns.Add(btnModificar);

            // Setteando el datasource para que utilice los atributos de la clase Cliente
            dataGridViewClientes.DataSource = clientes;
        }

        public bool ExisteClienteEnListaConDNI(string DNI)
        {
            return clientes.Exists(cliente => cliente.DNI.Equals(DNI));
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

        public void ActualizarClienteDataGridView(Cliente clienteConNuevosDatos)
        {
            var clienteConDatosParaReemplazar = clientes.Find(cliente => clienteConNuevosDatos.DNI.Equals(cliente.DNI));

            // Setteo en null el datagridview para poder reflejar los cambios 

            dataGridViewClientes.DataSource = null;

            // Hago finalmente el nuevo alojamiento de datos

            clienteConDatosParaReemplazar = clienteConNuevosDatos;

            // Vuelvo a llenar el datagridview con los datos de los clientes existentes

            dataGridViewClientes.DataSource = clientes;
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex >= 0 && dataGridViewClientes.Columns[e.ColumnIndex].Name == "btnModificar")
                {
                    // Obtengo el DNI para buscar la persona

                    var dniCliente = dataGridViewClientes.Rows[e.RowIndex].Cells["DNI"].Value;

                    // Buscar DNI de la persona

                    var clienteParaModificar = clientes.Find(cliente => cliente.DNI.Equals(dniCliente));

                    // Mostrar form para modificar detalles del cliente, pasando el cliente a modificar como argumento
                    FormModificarDetallesCliente formModificarDetallesCliente = new FormModificarDetallesCliente(clienteParaModificar, this, ReferenciaUC_Ventas);

                    formModificarDetallesCliente.Show();
                }
            }
        }
    }
}
