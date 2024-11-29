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
    public partial class FormModificarDetallesCliente : Form
    {
        public Cliente ClienteParaModificar { get; set; }
        public UC_Clientes ReferenciaUC_Cientes { get; set; }
        public UC_Ventas ReferenciaUC_Ventas { get; set; }
        public FormModificarDetallesCliente(Cliente clienteParaModificar, UC_Clientes ReferenciaUC_Clientes, UC_Ventas ReferenciaUC_Ventas)
        {

            InitializeComponent();

            ClienteParaModificar = clienteParaModificar;
            this.ReferenciaUC_Cientes = ReferenciaUC_Clientes;
            this.ReferenciaUC_Ventas = ReferenciaUC_Ventas;

            // Settear el label para mostrar los datos actuales del cliente

            labelObtenerDatosClienteAModificar.Text = ClienteParaModificar.ObtenerDatos();
        }

        private void buttonActualizarDatosCliente_Click(object sender, EventArgs e)
        {
            var nuevoNombre = textBoxModificarNombre.Text.Trim();
            var nuevoApellido = textBoxModificarApellido.Text.Trim();
            var nuevaDireccion = textBoxModificarDireccion.Text.Trim();
            var nuevoTelefono = textBoxModificarTelefono.Text.Trim();
            var nuevoEmail = textBoxModificarEmail.Text.Trim();

            // NOTA: Si el textbox esta vacio se supone que no se quiere cambiar el valor.

            try
            {

                if (nuevoNombre.Length > 0)
                {
                    // Un nuevo nombre fue ingresado por el usuario, si es valido lo modifico

                    if (EsNombreValido(nuevoNombre)) ClienteParaModificar.Nombre = nuevoNombre;
                }

                if (nuevoApellido.Length > 0)
                {
                    // Un nuevo apellido fue ingresado por el usuario, si es valido lo modifico
                    if (EsApellidoValido(nuevoApellido)) ClienteParaModificar.Apellido = nuevoApellido;
                }

                if (nuevaDireccion.Length > 0)
                {
                    // Una nueva direccion fue ingresada por el usuario, si es valida la modifico.

                    if (EsDireccionValida(nuevaDireccion)) ClienteParaModificar.Direccion = nuevaDireccion;
                }

                if (nuevoTelefono.Length > 0)
                {
                    // Un nuevo telefono fue ingresado por el usuario, si es valido lo modifico.

                    if (EsTelefonoValido(nuevoTelefono)) ClienteParaModificar.Telefono = nuevoTelefono;
                }

                if (nuevoEmail.Length > 0)
                {
                    // Un nuevo mail fue ingresado por el usuario, si es valido lo modifico.

                    if (EsEmailValido(nuevoEmail)) ClienteParaModificar.Email = nuevoEmail;
                }



                // Si los 5 campos estan vacíos y se apretó el botón de modificar datos, no hay nada para modificar y le aviso al usuario

                if (NoHayNuevosDatos(nuevoNombre, nuevoApellido, nuevaDireccion, nuevoTelefono, nuevoEmail)) throw new Exception("ERROR: No hay datos para actualizar");

                // El cliente ya tiene los nuevos datos setteados, reflejar cambios en DataGridView de UC_Clientes

                ReferenciaUC_Cientes.ActualizarClienteDataGridView(ClienteParaModificar);

                // El cliente ya tiene los datos nuevos setteados, reflejar cambios en DataGridView de UC_Ventas, en caso que haya una asociada.

                ReferenciaUC_Ventas.ActualizarDetallesClienteSiExisteVentaAsociada(ClienteParaModificar);

                this.Close();

                MessageBox.Show("Los datos del cliente han sido modificados correctamente", "CLIENTE MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private static bool NoHayNuevosDatos(string nuevoNombre, string nuevoApellido, string nuevaDireccion, string nuevoTelefono, string nuevoEmail)
        {
            return nuevoNombre.Length == 0 && nuevoApellido.Length == 0 && nuevaDireccion.Length == 0 && nuevoTelefono.Length == 0 && nuevoEmail.Length == 0;
        }

        private bool EsTelefonoValido(string telefono)
        {
            if (telefono.Length >= 10 && telefono.Length <= 15)
            {
                return true;
            }
            else
            {
                throw new Exception("ERROR: El nuevo telefono debe tener entre 10 y 15 caracteres");
            }
        }


        private bool EsNombreValido(string nombre)
        {
            if (nombre.Length >= 3 && nombre.Length <= 25 && !nombre.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                throw new Exception("ERROR: El nuevo nombre debe tener entre 3 y 25 caracteres");
            }
        }


        private bool EsApellidoValido(string nombre)
        {
            if (nombre.Length >= 3 && nombre.Length <= 25)
            {
                return true;
            }else
            {
                throw new Exception("ERROR: El nuevo apellido debe tener entre 3 y 25 caracteres");
            }
        }

        private bool EsDireccionValida(string direccion)
        {
            if (direccion.Length >= 7 && direccion.Length <= 25)
            {
                return true;
            }
            else
            {
                throw new Exception("ERROR: La nueva dirección debe tener entre 7 y 25 caracteres");
            }
        }

        private bool EsEmailValido(string email)
        {
            if ((email.EndsWith("@hotmail.com") || email.EndsWith("@gmail.com")) && email.Length >= 15)
            {
                return true;
            }
            else
            {
                throw new Exception("ERROR: El nuevo email debe ser tipo GMAIL o HOTMAIL");
            }
        }

        private void FormModificarDetallesCliente_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
