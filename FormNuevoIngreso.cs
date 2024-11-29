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
    public partial class FormNuevoIngreso : Form
    {
        public List<ItemInventario> itemsInventario = new List<ItemInventario>();
        public UC_Inventario ReferenciaUC_Inventario { get; set; }
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
                Text = "ELIMINAR",
                UseColumnTextForButtonValue = true
            };

            dataGridViewIngreso.Columns.Add(btnEliminar);

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewIngreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewIngreso.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    var confirmarResultado = MessageBox.Show("¿Eliminar item?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmarResultado == DialogResult.Yes)
                    {
                        // Eliminar item de la lista 
                        itemsInventario.Remove(itemsInventario[e.RowIndex]);

                        // Eliminar item del DataGridView
                        dataGridViewIngreso.Rows.RemoveAt(e.RowIndex);

                    }
                }
            }
        }

        // Botón Agregar ITEM
        private void buttonAgregarIngresoForm_Click(object sender, EventArgs e)
        {
            if (SonDatosValidos())
            {
                // Obtener las selecciones del usuario

                string tipoMuebleText = comboBoxTipoMueble.SelectedItem as string;
                string tipoMaderaText = comboBoxTipoMadera.SelectedItem as string;
                string cantidadItemText = textBoxCantidadItem.Text;


                // Convertir a ENUM a partir de texto el tipo de mueble y el tipo de madera

                Enum.TryParse(tipoMuebleText, true, out TipoMueble tipoMueble);
                Enum.TryParse(tipoMaderaText, true, out TipoMadera tipoMadera);


                int cantidadItem = int.Parse(cantidadItemText);

                // Crear el item de inventario
                ItemInventario itemInventario = new ItemInventario(new Mueble(tipoMueble, tipoMadera), cantidadItem);

                var itemEncontrado = itemsInventario.Find(item => item.Mueble.Tipo.ToString().Equals(tipoMuebleText) && item.Mueble.Madera.ToString().Equals(tipoMaderaText));

                // Si el item encontrado es distinto de null significa que el item ya esta en la lista y solo queda actualizar su cantidad
                if (itemEncontrado != null)
                {
                    // Si la cantidad a actualizar supera 200 entonces no agregarlo y mostrar error
                    if (itemEncontrado.CantidadEnInventario + cantidadItem > 200)
                    {
                        MessageBox.Show("ERROR: La cantidad resultante de este item para este ingreso resulta mayor a 200", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else
                    {
                        itemEncontrado.CantidadEnInventario += cantidadItem;

                        int index = itemsInventario.IndexOf(itemEncontrado);

                        dataGridViewIngreso.Rows[index].Cells[2].Value = itemEncontrado.CantidadEnInventario.ToString();
    
                    }

                }else
                {
                    // El item NO EXISTE TODAVIA en la lista y lo agrego
                    itemsInventario.Add(itemInventario);
                    dataGridViewIngreso.Rows.Add(tipoMuebleText, tipoMaderaText, cantidadItemText);
                }

            }

        }

        // Validacion
        private bool SonDatosValidos()
        {
            string mensajeError;

            try
            {

                if (comboBoxTipoMueble.SelectedItem == null) throw new Exception("ERROR: Debe indicar el tipo de mueble");
                if (comboBoxTipoMadera.SelectedItem == null) throw new Exception("ERROR: Debe indicar el tipo de madera");

                int cantidadItem = int.Parse(textBoxCantidadItem.Text);

                if (cantidadItem <= 0 || cantidadItem > 200) throw new Exception("ERROR: El rango numérico de la cantidad es inválido (1-200)");

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

        private void FormNuevoIngreso_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void buttonRegistrarIngreso_Click(object sender, EventArgs e)
        {

            // Si no hay items agregados, no hay ingreso

            if (itemsInventario.Count == 0)
            {
                MessageBox.Show("Ningun mueble fue agregado para ser ingresado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmarRegistrarIngreso = MessageBox.Show("¿Confirmar nuevo ingreso de muebles?", "Confirmar ingreso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmarRegistrarIngreso == DialogResult.Yes)
            {
                // Agregar la lista de ItemInventario a Inventario en el UC_Inventario

                ReferenciaUC_Inventario.AgregarNuevosMueblesAInventario(itemsInventario);

                // Ya hice el ingreso, simplemente elimino los items (ya no los necesito) y cierro el form
                itemsInventario.Clear();
                this.Close();
            }

                
        }

        private void FormNuevoIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {


            //var confirmarResultadoCerrarForm = MessageBox.Show("¿Desea cancelar el registro de ingreso? los datos ingresados se perderan.", "Cerrar ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (confirmarResultadoCerrarForm == DialogResult.Yes)
            //{
            //    // Vaciar la lista, se cancela el nuevo ingreso
            //    itemsInventario.Clear();
            //}
            //else e.Cancel = true;
        }
    }
}
