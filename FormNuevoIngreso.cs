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

namespace Mueblerize
{
    public partial class FormNuevoIngreso : Form
    {
        List<ItemInventario> itemsInventario = new List<ItemInventario> ();
        public FormNuevoIngreso()
        {
            InitializeComponent();

            // Llenar los comboBox con los valores de cada Enum
            comboBoxTipoMueble.Items.AddRange(Enum.GetNames(typeof(TipoMueble)));
            comboBoxTipoMadera.Items.AddRange(Enum.GetNames(typeof(TipoMadera)));

            // Armar las columnas para mostrar Mueble
            dataGridViewIngreso.Columns.Add("tipoMueble", "TIPO DE MUEBLE");
            dataGridViewIngreso.Columns.Add("tipoMadera", "TIPO DE MADERA");
            dataGridViewIngreso.Columns.Add("cantidad", "CANTIDAD");

            // Armar las columnas para los botones

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "btnEliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };

            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn
            {
                Name = "btnModificar",
                HeaderText = "Modificar",
                Text = "Modificar",
                UseColumnTextForButtonValue = true
            };

            dataGridViewIngreso.Columns.Add(btnEliminar);
            dataGridViewIngreso.Columns.Add(btnModificar);


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewIngreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Botón Agregar ITEM
        private void buttonAgregarIngresoForm_Click(object sender, EventArgs e)
        {
            if (SonDatosValidos())
            {
                // Agregar ITEM al DataGridView

                string tipoMuebleText = comboBoxTipoMueble.SelectedItem as string;
                string tipoMaderaText = comboBoxTipoMadera.SelectedItem as string;
                string cantidadItemText = textBoxCantidadItem.Text;


                // Convertir a ENUM a partir de texto

                Enum.TryParse(tipoMuebleText, true, out TipoMueble tipoMueble);
                Enum.TryParse(tipoMaderaText, true, out TipoMadera tipoMadera);

                
                int cantidadItem = int.Parse(cantidadItemText);
                ItemInventario itemInventario = new ItemInventario(new Mueble(tipoMueble, tipoMadera), cantidadItem);



                ItemInventario itemEncontrado = itemsInventario.Find(item => item.Mueble.Tipo.ToString().Equals(tipoMuebleText) && item.Mueble.Madera.ToString().Equals(tipoMaderaText));

                // Si el item encontrado es distinto de null significa que el item ya esta en la lista y solo queda actualizar su cantidad
                if (itemEncontrado != null)
                {
                    itemEncontrado.CantidadEnInventario += cantidadItem;

                    // TODO: Actualizar DataGridView donde Row(i) == item.GetIndex()
                    int index = itemsInventario.IndexOf(itemEncontrado);

                    dataGridViewIngreso.Rows[index].Cells[2].Value = itemEncontrado.CantidadEnInventario.ToString();
                    return;
                }

          
                // El item NO EXISTE TODAVIA en la lista y lo agrego
                itemsInventario.Add(itemInventario);
                dataGridViewIngreso.Rows.Add(tipoMuebleText, tipoMaderaText, cantidadItemText);

            }

        }

        private bool SonDatosValidos()
        {
            string mensajeError;

            try
            {

                if (comboBoxTipoMueble.SelectedItem == null) throw new Exception("ERROR: Debe indicar el tipo de mueble");
                if (comboBoxTipoMadera.SelectedItem == null) throw new Exception("ERROR: Debe indicar el tipo de madera");

                int cantidadItem = int.Parse(textBoxCantidadItem.Text);

                if (cantidadItem <= 0 || cantidadItem > 100) throw new Exception("ERROR: El rango numérico de la cantidad es inválido (1-100)");

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
    }
}
