using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mueblerize.Modelo
{
    public class Venta
    {
        public Cliente Cliente {  get; set; }
        public DateTime Fecha { get; set; }
        public List<ItemInventario> ItemsVendidos { get; set; }

        public Venta(Cliente Cliente,List<ItemInventario> ItemsVendidos)
        {
            this.Cliente = Cliente;
            this.Fecha = DateTime.Now;
            this.ItemsVendidos = ItemsVendidos;
        }
    }
}
