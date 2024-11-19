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
    public partial class UC_Inventario : UserControl
    {
        public Dictionary<TipoMueble, decimal> diccionarioPrecioTipoMueble = new Dictionary<TipoMueble, decimal>();
        public Dictionary<TipoMadera, decimal> diccionarioPrecioTipoMadera = new Dictionary<TipoMadera, decimal>();

        public Inventario inventario = new Inventario();

        public UC_Inventario()
        {
            InitializeComponent();

            // Armar las columnas para mostrar Mueble
            dataGridViewMuebles.Columns.Add("tipoMueble", "TIPO DE MUEBLE");
            dataGridViewMuebles.Columns.Add("tipoMadera", "TIPO DE MADERA");
            dataGridViewMuebles.Columns.Add("cantidad", "CANTIDAD");

            // Armar las columnas para los botones

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "btnEliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };

            dataGridViewMuebles.Columns.Add(btnEliminar);

            // Definiendo los precios base de los tipos de mueble
            diccionarioPrecioTipoMueble.Add(TipoMueble.Cama, 250);
            diccionarioPrecioTipoMueble.Add(TipoMueble.Mesa, 250);
            diccionarioPrecioTipoMueble.Add(TipoMueble.Silla, 250);
            diccionarioPrecioTipoMueble.Add(TipoMueble.Estante, 250);

            // Definiendo los precios base de lso tipos de madera
            diccionarioPrecioTipoMadera.Add(TipoMadera.Roble, 300);
            diccionarioPrecioTipoMadera.Add(TipoMadera.Abeto, 400);
            diccionarioPrecioTipoMadera.Add(TipoMadera.Algarrobo, 500);
            diccionarioPrecioTipoMadera.Add(TipoMadera.Pino, 600);


        }

        private void buttonNuevoIngreso_Click(object sender, EventArgs e)
        {
            FormNuevoIngreso formNuevoIngreso = new FormNuevoIngreso();
            formNuevoIngreso.ReferenciaUC_Inventario = this;
            formNuevoIngreso.Show();
        }

        public void AgregarNuevosMueblesAInventario(List<ItemInventario> itemsInventario)
        {

            foreach (var itemIngreso in itemsInventario)
            {
                var encontrado = inventario.items.Find(item => item.Mueble.Tipo.Equals(itemIngreso.Mueble.Tipo) && item.Mueble.Madera.Equals(itemIngreso.Mueble.Madera));

                if (encontrado != null)
                {
                    // Si encontrado tiene un valor significa que el item ya existe y hay que actualizar su cantidad

                    encontrado.CantidadEnInventario += itemIngreso.CantidadEnInventario;

                    int index = inventario.items.IndexOf(encontrado);

                    dataGridViewMuebles.Rows[index].Cells[2].Value = encontrado.CantidadEnInventario.ToString();

                }
                else
                {
                    // El item es nuevo 
                    inventario.items.Add(itemIngreso);
                    dataGridViewMuebles.Rows.Add(itemIngreso.Mueble.Tipo.ToString(), itemIngreso.Mueble.Madera.ToString(), itemIngreso.CantidadEnInventario.ToString());
                }
            }
        }

        private void dataGridViewMuebles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (dataGridViewMuebles.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    var confirmarResultado = MessageBox.Show("¿Eliminar item?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmarResultado == DialogResult.Yes)
                    {
                        // Eliminar item de la lista 
                        inventario.items.Remove(inventario.items[e.RowIndex]);

                        // Eliminar item del DataGridView
                        dataGridViewMuebles.Rows.RemoveAt(e.RowIndex);

                    }
                }
            }
        }

        // Modificar precios
        private void buttonModificarDatosMueble_Click(object sender, EventArgs e)
        {
            FormModificarPrecios formModificarPrecios = new FormModificarPrecios(this);
            formModificarPrecios.ReferenciaUC_Inventario = this;
            formModificarPrecios.Show();
        }

        public void ActualizarInventario(List<ItemInventario> itemsParaActualizar)
        {
            // Llamar a metodo de la clase Inventario para actualizar el inventario
            inventario.ActualizarStock(itemsParaActualizar);

            dataGridViewMuebles.Rows.Clear();

           foreach (var item in inventario.items)
            {
                dataGridViewMuebles.Rows.Add(item.Mueble.Tipo.ToString(), item.Mueble.Madera.ToString(), item.CantidadEnInventario.ToString());
            }
        }
    }
}
