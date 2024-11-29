using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class Ticket
    {
        public List<IArticulo> articulos = new List<IArticulo>();

        public void Imprimir()
        {
            foreach(var articulos in articulos)
            {
                Console.WriteLine(articulos.Imprimir());
            }
        }
    }
}
