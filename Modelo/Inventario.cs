using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mueblerize.Modelo
{
    public class Inventario
    {
        public List<ItemInventario> items = new List<ItemInventario> { };

        public Inventario() { }

        public bool HayStock(Mueble mueble, int cantidad)
        {
            // Si existe el Mueble y la cantidad que yo deseo es menor a la que hay en el inventario, devuelve true. Si no, false.
            return items.Exists(item => item.Mueble.Tipo.Equals(mueble.Tipo) && item.Mueble.Madera.Equals(mueble.Madera) && cantidad < item.CantidadEnInventario);
        }
        
        // Actualizar stock restando la cantidad de la lista pasada como argumento
        public void ActualizarStock(List<ItemInventario> itemsParaActualizar)
        {
            foreach (var item in itemsParaActualizar)
            {
                var encontrado = EncontrarItemInventario(item);

                if (encontrado != null)
                {
                    encontrado.CantidadEnInventario -= item.CantidadEnInventario;
                }
            }
        }

        public ItemInventario EncontrarItemInventario(ItemInventario itemInventario)
        {
            
            // Retorna el objeto si o si ya que es certero que esté (verificado)

            return items.Find(item => item.Mueble.Tipo.Equals(itemInventario.Mueble.Tipo) && item.Mueble.Madera.Equals(itemInventario.Mueble.Madera));
        }
    }
}
