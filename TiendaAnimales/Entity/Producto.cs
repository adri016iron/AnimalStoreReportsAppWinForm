using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAnimales.Entity
{
    internal class Producto
    {
        public int Id { get;  set; }
        public string Marca { get;  set; }
        public string Nombre { get;  set; }
        public int ProovedorId { get;  set; }
        public decimal Precio { get;  set; }
        public int Stock { get;  set; }
        public DateTime FechaCaducidad { get;  set; }

        public Producto()
        {
        }

        public Producto(int id, string marca, string nombre, decimal precio, int stock, DateTime fechaCaducidad, int proovedorId)
        {
            Id = id;
            Marca = marca;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            FechaCaducidad = fechaCaducidad;
            ProovedorId = proovedorId;
        }
    }
}
