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
    public partial class FormModificarPrecios : Form
    {
        public UC_Inventario ReferenciaUC_Inventario {get; set;} 
        public FormModificarPrecios(UC_Inventario ReferenciaUC_Inventario)
        {
            InitializeComponent();

            // Obtener los diccionarios para los precios
            var diccionarioPrecioTipoMuebleRef = ReferenciaUC_Inventario.diccionarioPrecioTipoMueble;
            var diccionarioPrecioTipoMaderaRef = ReferenciaUC_Inventario.diccionarioPrecioTipoMadera;


            // Poner el valor de los textboxs correspondientes para mostrarse en pantalla los precios actuales

            // cama, mesa, silla, estante
            textBoxPrecioCama.Text = diccionarioPrecioTipoMuebleRef[TipoMueble.Cama].ToString();
            textBoxPrecioMesa.Text = diccionarioPrecioTipoMuebleRef[TipoMueble.Mesa].ToString();
            textBoxPrecioSilla.Text = diccionarioPrecioTipoMuebleRef[TipoMueble.Silla].ToString();
            textBoxPrecioEstante.Text = diccionarioPrecioTipoMuebleRef[TipoMueble.Estante].ToString();

            // roble, abeto, algarrobo, pino
            textBoxPrecioRoble.Text = diccionarioPrecioTipoMaderaRef[TipoMadera.Roble].ToString();
            textBoxPrecioAbeto.Text = diccionarioPrecioTipoMaderaRef[TipoMadera.Abeto].ToString();
            textBoxPrecioAlgarrobo.Text = diccionarioPrecioTipoMaderaRef[TipoMadera.Algarrobo].ToString();
            textBoxPrecioPino.Text = diccionarioPrecioTipoMaderaRef[TipoMadera.Pino].ToString();

        }

        private void buttonActualizarPrecios_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar y actualizar los precios de los muebles
                ReferenciaUC_Inventario.diccionarioPrecioTipoMueble[TipoMueble.Cama] = ValidarYConvertirPrecio(textBoxPrecioCama.Text, TipoMueble.Cama);
                ReferenciaUC_Inventario.diccionarioPrecioTipoMueble[TipoMueble.Mesa] = ValidarYConvertirPrecio(textBoxPrecioMesa.Text, TipoMueble.Mesa);
                ReferenciaUC_Inventario.diccionarioPrecioTipoMueble[TipoMueble.Silla] = ValidarYConvertirPrecio(textBoxPrecioSilla.Text, TipoMueble.Silla);
                ReferenciaUC_Inventario.diccionarioPrecioTipoMueble[TipoMueble.Estante] = ValidarYConvertirPrecio(textBoxPrecioEstante.Text, TipoMueble.Estante);

                // Validar y actualizar los precios de las maderas
                ReferenciaUC_Inventario.diccionarioPrecioTipoMadera[TipoMadera.Roble] = ValidarYConvertirPrecio(textBoxPrecioRoble.Text, TipoMadera.Roble);
                ReferenciaUC_Inventario.diccionarioPrecioTipoMadera[TipoMadera.Abeto] = ValidarYConvertirPrecio(textBoxPrecioAbeto.Text, TipoMadera.Abeto);
                ReferenciaUC_Inventario.diccionarioPrecioTipoMadera[TipoMadera.Algarrobo] = ValidarYConvertirPrecio(textBoxPrecioAlgarrobo.Text, TipoMadera.Algarrobo);
                ReferenciaUC_Inventario.diccionarioPrecioTipoMadera[TipoMadera.Pino] = ValidarYConvertirPrecio(textBoxPrecioPino.Text, TipoMadera.Pino);

                MessageBox.Show("Los precios han sido actualizados correctamente.", "Actualización de precios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ValidarYConvertirPrecio(string textoPrecio, Enum tipo)
        {
            if (decimal.TryParse(textoPrecio, out decimal precio) && precio >= 0 && precio < 100000)
            {
                return precio;
            }
            else
            {
                throw new ArgumentException($"El precio ingresado para {tipo} no es válido.");
            }
        }

    }
}
