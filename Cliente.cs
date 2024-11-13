using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mueblerize
{
    public class Cliente : Persona
    {
        public int NumeroCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Cliente(string nombre, string apellido, string dNI, int edad, string telefono, string direccion, string email, int NumeroCliente, DateTime FechaRegistro)
            : base(nombre,apellido,dNI,edad,telefono,direccion, email)
        {
            this.NumeroCliente = NumeroCliente;
            this.FechaRegistro = FechaRegistro;
        }
    }
}
