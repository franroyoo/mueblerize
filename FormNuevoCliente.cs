using Mueblerize.Modelo;
using Mueblerize.UserControls;
using System;
using System.Windows.Forms;

namespace Mueblerize
{
    public partial class FormNuevoCliente : Form
    {
        // ReferenciaUC_Clientes es necesario porque necesito pasar información del Form al UserControl
        public UC_Clientes ReferenciaUC_Clientes { get; set; }
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        // Boton "AGREGAR CLIENTE"
        private void button1_Click(object sender, EventArgs e)
        {
            // Sacando los espacios en blanco
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

                // Comunicarse con la referencia al UserControl de Cliente y chequear si el cliente ya existe en la lista (DNI debe ser único)

                if (ReferenciaUC_Clientes.ExisteClienteEnListaConDNI(dni))
                {
                    MessageBox.Show($"El cliente ya se encuentra registrado en el sistema", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    // Creo el nuevo cliente a agregar

                    Cliente cliente = new Cliente(nombre, apellido, dni, edad, telefono, direccion, email, GenerarNumeroCliente(), DateTime.Now);

                    // Comunicarse con la referencia al UserControl de Cliente (pasar el nuevo cliente instanciado al DataGridView)

                    ReferenciaUC_Clientes.AgregarClienteDataGridView(cliente);

                    // Cerrar FormNuevoCliente

                    this.Close();
                }
            }
        }

        private int GenerarNumeroCliente()
        {
            Random random = new Random();
            return random.Next(1000, 100000);
        }

        // Función para chequear que los datos sean VÁLIDOS
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
                if (!EsEmailValido(email)) throw new Exception("Error en el campo EMAIL: email debe ser de tipo GMAIL o HOTMAIL");

                this.Close();

                MessageBox.Show("El cliente ha sido agregado correctamente.", "CLIENTE REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR DE VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Condiciones para que los campos sean VÁLIDOS
        private bool EsNombreValido(string nombre) => nombre.Length >= 3 && nombre.Length <= 25 && !nombre.Any(char.IsDigit);

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
                throw new Exception("Error en el campo EDAD: debe ser una edad válida (18 a 99 años)");
            }
        }

        private bool EsTelefonoValido(string telefono) => telefono.Length >= 10 && telefono.Length <= 15;

        private bool EsDireccionValida(string direccion) => direccion.Length >= 7 && direccion.Length <= 25;

        private bool EsEmailValido(string email) => (email.EndsWith("@hotmail.com") || email.EndsWith("@gmail.com")) && email.Length >= 15;
    }
}
