using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mueblerize.Modelo
{
    public class ItemInventario
    {
        public Mueble Mueble { get; set; }
        public int CantidadEnInventario { get; set; }
        public ItemInventario(Mueble mueble, int cantidadEnInventario)
        {
            Mueble = mueble;
            CantidadEnInventario = cantidadEnInventario;
        }
    }
}
