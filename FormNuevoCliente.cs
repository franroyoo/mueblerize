using Mueblerize.UserControls;
using System;
using System.Windows.Forms;

namespace Mueblerize
{
    public partial class FormNuevoCliente : Form
    {
        public UC_Clientes ReferenciaUC_Clientes { get; set; }
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        // Agregar cliente
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text.Trim();
            string apellido = textBoxApellido.Text.Trim();
            string dni = textBoxDNI.Text.Trim();
            string telefono = textBoxTelefono.Text.Trim();
            string direccion = textBoxDireccion.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string edadTexto = textBoxEdad.Text.Trim();

            if (SonDatosValidos(nombre, apellido, dni, edadTexto, telefono, direccion, email))
            {
                int edad = int.Parse(edadTexto);
                Cliente cliente = new Cliente(nombre, apellido, dni, edad, telefono, direccion, email, GenerarNumeroCliente(), DateTime.Now);

                // Comunicarse con la referencia al UserControl de Cliente
                ReferenciaUC_Clientes.AgregarClienteDataGridView(cliente);

                // Cerrar FormNuevoCliente
                this.Close();
            }
        }

        private int GenerarNumeroCliente()
        {
            Random random = new Random();
            return random.Next(1000, 10000);
        }

        private bool SonDatosValidos(string nombre, string apellido, string dni, string edadTexto, string telefono, string direccion, string email)
        {
            try
            {
                if (!EsNombreValido(nombre)) throw new Exception("Error en el campo NOMBRE: mínimo 3 caracteres y máximo 25");
                if (!EsApellidoValido(apellido)) throw new Exception("Error en el campo APELLIDO: mínimo 3 caracteres y máximo 25");
                if (!EsDniValido(dni)) throw new Exception("Error en el campo DNI: inserte DNI válido de 7 caracteres sin puntos");
                if (!EsEdadValida(edadTexto)) throw new Exception("Error en el campo EDAD: rango de edad no válido");
                if (!EsTelefonoValido(telefono)) throw new Exception("Error en el campo TELEFONO: mínimo 10 caracteres y máximo 15");
                if (!EsDireccionValida(direccion)) throw new Exception("Error en el campo DIRECCIÓN: mínimo 7 caracteres y máximo 25");
                if (!EsEmailValido(email)) throw new Exception("Error en el campo EMAIL: formato no válido");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR DE VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool EsNombreValido(string nombre) => nombre.Length >= 3 && nombre.Length <= 25;

        private bool EsApellidoValido(string nombre) => nombre.Length >= 3 && nombre.Length <=25;
        private bool EsDniValido(string dni) => dni.Length == 8 && dni.All(char.IsDigit);

        private bool EsEdadValida(string edadTexto)
        {
            if (int.TryParse(edadTexto, out int edad))
            {
                return edad >= 18 && edad <= 99;
            }
            else
            {
                throw new Exception("Error en el campo EDAD: debe ser un número válido");
            }
        }

        private bool EsTelefonoValido(string telefono) => telefono.Length >= 10 && telefono.Length <= 15;

        private bool EsDireccionValida(string direccion) => direccion.Length >= 7 && direccion.Length <= 25;

        private bool EsEmailValido(string email) => email.Contains('@') && email.Length >= 5;
    }
}
