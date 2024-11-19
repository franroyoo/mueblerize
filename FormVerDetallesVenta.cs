using Mueblerize.Modelo;
using Mueblerize.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mueblerize
{
    public partial class FormVerDetallesVenta : Form
    {
        public Venta VentaParaMostrar { get; set; }
        public FormVerDetallesVenta(Venta Venta)
        {
            InitializeComponent();


            this.VentaParaMostrar = Venta;

            // Mostrar datos del cliente

            labelObtenerDatosCliente.Text = Venta.Cliente.ObtenerDatos();

            // Total recaudado en la venta

            decimal totalRecaudado = 0;

            // Armar datagridview

            dataGridViewMueblesVerDetalles.Columns.Add("TipoMueble", "TIPO DE MUEBLE");
            dataGridViewMueblesVerDetalles.Columns.Add("TipoMadera", "TIPO DE MADERA");
            dataGridViewMueblesVerDetalles.Columns.Add("CantidadVendida", "CANTIDAD VENDIDA");
            dataGridViewMueblesVerDetalles.Columns.Add("Precio", "PRECIO");

            // Por cada item (mueble y la cantidad asociada) agregar al datagridview

            foreach (var item in Venta.ItemsVendidos)
            {
                totalRecaudado += (item.Mueble.Precio * item.CantidadEnInventario);

                dataGridViewMueblesVerDetalles.Rows
                    .Add(item.Mueble.Tipo.ToString(), 
                    item.Mueble.Madera.ToString(), 
                    item.CantidadEnInventario,
                    (item.Mueble.Precio * item.CantidadEnInventario).ToString());
            }

            // Mostrar total recaudado en la venta

            labelTotalRecaudadoVenta.Text = $"TOTAL RECAUDADO: ${totalRecaudado.ToString()}";
        }


    }
}
