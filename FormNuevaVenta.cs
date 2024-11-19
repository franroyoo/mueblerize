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
    public partial class FormNuevaVenta : Form
    {
        public UC_Inventario UC_Inventario { get; set; }
        public UC_Clientes UC_Clientes { get; set; }
        public UC_Ventas ReferenciaUC_Ventas { get; set; }
        public Inventario Inventario { get; set; }

        public Dictionary<TipoMueble, decimal> PreciosTipoMueble { get; set; }
        public Dictionary<TipoMadera, decimal> PreciosTipoMadera { get; set; }
        public List<ItemInventario> itemsSeleccionadosUsuario { get; set; } = new List<ItemInventario>();
        public FormNuevaVenta(UC_Inventario UC_Inventario, UC_Clientes UC_Clientes)
        {

            InitializeComponent();

            this.UC_Inventario = UC_Inventario;
            this.UC_Clientes = UC_Clientes;

            // Llenar los comboBox con los valores de cada Enum
            comboBoxTipoMuebleVenta.Items.AddRange(Enum.GetNames(typeof(TipoMueble)));
            comboBoxTipoMaderaVenta.Items.AddRange(Enum.GetNames(typeof(TipoMadera)));

            // Armar las columnas para mostrar Mueble
            dataGridViewMueblesVenta.Columns.Add("tipoMueble", "TIPO DE MUEBLE");
            dataGridViewMueblesVenta.Columns.Add("tipoMadera", "TIPO DE MADERA");
            dataGridViewMueblesVenta.Columns.Add("cantidad", "CANTIDAD");
            dataGridViewMueblesVenta.Columns.Add("precio", "PRECIO");

            // Armar las columnas para el boton eliminar

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "btnEliminar",
                HeaderText = "Eliminar",
                Text = "ELIMINAR",
                UseColumnTextForButtonValue = true
            };

            dataGridViewMueblesVenta.Columns.Add(btnEliminar);

            // Obtener informacion del UC_Inventario (Inventario)

            Inventario = UC_Inventario.inventario;

            // Obtener informacion del UC_Inventario (Precios actuales)

            PreciosTipoMueble = UC_Inventario.diccionarioPrecioTipoMueble;
            PreciosTipoMadera = UC_Inventario.diccionarioPrecioTipoMadera;

        }

        private void buttonAgregarItemVenta_Click(object sender, EventArgs e)
        {
            if (SonDatosValidos())
            {
                // Obtener las selecciones del usuario

                string tipoMuebleText = comboBoxTipoMuebleVenta.SelectedItem as string;
                string tipoMaderaText = comboBoxTipoMaderaVenta.SelectedItem as string;
                string cantidadItemText = textBoxCantidadItemVenta.Text;


                // Convertir a ENUM a partir de texto el tipo de mueble y el tipo de madera

                Enum.TryParse(tipoMuebleText, true, out TipoMueble tipoMueble);
                Enum.TryParse(tipoMaderaText, true, out TipoMadera tipoMadera);


                int cantidadItem = int.Parse(cantidadItemText);

                // Armar mueble a partir de esa informacion

                Mueble mueble = new Mueble(tipoMueble, tipoMadera);

                // Settear el precio del mueble
                mueble.Precio = PreciosTipoMueble[tipoMueble] + PreciosTipoMadera[tipoMadera];

                // Chequear que hay stock para ese mueble y esa cantidad

                if (Inventario.HayStock(mueble, cantidadItem))
                {
                    // Si el mueble no fue seleccionado anteriormente, entonces lo agrego a la lista de las selecciones del usuario
                    if (!FueMuebleSeleccionadoAnteriormente(mueble))
                    {

                        itemsSeleccionadosUsuario.Add(new ItemInventario(mueble, cantidadItem));


                        dataGridViewMueblesVenta.Rows.Add(mueble.Tipo.ToString(), mueble.Madera.ToString(), cantidadItem.ToString(), (mueble.Precio * cantidadItem).ToString());
                    }
                    else
                    {
                        MessageBox.Show("ERROR: El item ya fue agregado a la lista", "ITEM EXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("ERROR: No hay suficiente stock para el mueble seleccionado", "FALTA DE STOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

        }

        private bool FueMuebleSeleccionadoAnteriormente(Mueble mueble)
        {
            return itemsSeleccionadosUsuario.Find(item => item.Mueble.Tipo.Equals(mueble.Tipo) && item.Mueble.Madera.Equals(mueble.Madera)) != null;
        }

        private bool SonDatosValidos()
        {
            string mensajeError;

            try
            {

                if (comboBoxTipoMuebleVenta.SelectedItem == null) throw new Exception("ERROR: Debe indicar el tipo de mueble");
                if (comboBoxTipoMaderaVenta.SelectedItem == null) throw new Exception("ERROR: Debe indicar el tipo de madera");




                int cantidadItem = int.Parse(textBoxCantidadItemVenta.Text);

                // Validar que no se pueda pedir mas de 50 muebles de un tipo

                if (cantidadItem <= 0 || cantidadItem > 50) throw new Exception("ERROR: El rango numérico de la cantidad es inválido (1-50)");

                return true;
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException || ex is FormatException)
                {
                    mensajeError = "ERROR: Debe indicar un valor numérico válido";
                }
                else
                {
                    mensajeError = ex.Message;
                }

                MessageBox.Show(mensajeError, "ERROR DE VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void buttonRegistrarVenta_Click(object sender, EventArgs e)
        {



            try
            {
                if (itemsSeleccionadosUsuario.Count == 0) throw new Exception("ERROR: No se ha seleccionado ningun mueble para vender");
                if (!UC_Clientes.ExisteClienteEnListaConDNI(textBoxDniClienteVenta.Text)) throw new Exception("ERROR: El cliente no existe en el sistema, por favor registrelo primero");

                // Armar objeto Venta y ponerlo en el datagridview de ventas

                var cliente = UC_Clientes.clientes.Find(cliente => cliente.DNI.Equals(textBoxDniClienteVenta.Text));

                Venta venta = new Venta(cliente, itemsSeleccionadosUsuario);

                ReferenciaUC_Ventas.AgregarNuevaVentaDataGridView(venta);

                // Actualizar inventario para reflejar aquellos items vendidos

                UC_Inventario.ActualizarInventario(itemsSeleccionadosUsuario);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMueblesVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewMueblesVenta.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    var confirmarResultado = MessageBox.Show("¿Eliminar item?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmarResultado == DialogResult.Yes)
                    {
                        // Eliminar item de la lista 
                        itemsSeleccionadosUsuario.Remove(itemsSeleccionadosUsuario[e.RowIndex]);

                        // Eliminar item del DataGridView
                        dataGridViewMueblesVenta.Rows.RemoveAt(e.RowIndex);

                    }
                }
            }
        }
    }
}
