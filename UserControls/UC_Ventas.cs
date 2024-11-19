using Mueblerize.Modelo;
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
    public partial class UC_Ventas : UserControl
    {
        public UC_Inventario UC_Inventario { get; set; }
        public UC_Clientes UC_Clientes { get; set; }

        public List<Venta> Ventas { get; set; } = new List<Venta>();
        public UC_Ventas(UC_Inventario UC_Inventario, UC_Clientes UC_Clientes)
        {

            InitializeComponent();

            this.UC_Inventario = UC_Inventario;
            this.UC_Clientes = UC_Clientes;

            // Armar datagridview

            dataGridViewVentas.Columns.Add("NombreCliente", "NOMBRE DE CLIENTE");
            dataGridViewVentas.Columns.Add("ApellidoCliente", "APELLIDO DE CLIENTE");
            dataGridViewVentas.Columns.Add("DniCliente", "DNI DE CLIENTE");
            dataGridViewVentas.Columns.Add("FechaVenta", "FECHA VENTA");

            // Armar boton "Ver detalles" para datagridview

            DataGridViewButtonColumn btnVerDetalles = new DataGridViewButtonColumn
            {
                Name = "btnVerDetalles",
                HeaderText = "Ver detalles",
                Text = "VER DETALLES",
                UseColumnTextForButtonValue = true
            };

            dataGridViewVentas.Columns.Add(btnVerDetalles);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void AgregarNuevaVentaDataGridView(Venta venta)
        {
            dataGridViewVentas.Rows.Add(venta.Cliente.Nombre, venta.Cliente.Apellido, venta.Cliente.DNI, venta.Fecha);

            // Agregar venta a la lista de ventas

            this.Ventas.Add(venta);
        }

        private void buttonNuevaVenta_Click(object sender, EventArgs e)
        {
            FormNuevaVenta formNuevaVenta = new FormNuevaVenta(UC_Inventario, UC_Clientes);
            formNuevaVenta.ReferenciaUC_Ventas = this;
            formNuevaVenta.Show();
        }

        // Evento que se dispara para "Ver detalles"
        private void dataGridViewVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewVentas.Columns[e.ColumnIndex].Name == "btnVerDetalles")
                {
                    // Obtengo la fecha de venta (unica para cada venta)
                    var fechaVenta = dataGridViewVentas.Rows[e.RowIndex].Cells["FechaVenta"].Value;

                    // Buscar venta que corresponda con esa fecha en mi lista de ventas

                    var ventaParaMostrarDetalles = Ventas.Find(venta => venta.Fecha.Equals(fechaVenta));

                    // Crear el form para ver los detalles de la venta y pasarle al constructor una referencia a este UserControl (UC_Ventas)
                    FormVerDetallesVenta formVerDetallesVenta = new FormVerDetallesVenta(ventaParaMostrarDetalles);
                    formVerDetallesVenta.Show();
                }
            }
        }
    }
}
