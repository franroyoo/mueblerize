using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mueblerize.Modelo
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        public Persona(string nombre, string apellido, string dNI, int edad, string telefono, string direccion, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            Edad = edad;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
        }

        public abstract string ObtenerDatos();
    }
}
