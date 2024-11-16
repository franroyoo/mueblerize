using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mueblerize.Modelo
{
    public class Mueble
    {
        public TipoMueble Tipo { get; set; }
        public TipoMadera Madera { get; set; }
        public decimal Precio { get; set; }
        public Mueble(TipoMueble tipo, TipoMadera madera)
        {
            Tipo = tipo;
            Madera = madera;
            Precio = 500;
        }
    }
}
