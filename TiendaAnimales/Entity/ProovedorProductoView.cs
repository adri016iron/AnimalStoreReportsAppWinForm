using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAnimales.Entity
{
    public class ProovedorProductoView
    {
        // Propiedades usadas por el informe (nombres deben coincidir con los campos del .rdlc)
        public string ProovedorNombre { get; set; }
        public int ProovedorId { get; set; }
        // Lista de productos concatenada (ej: "Producto A (Marca), Producto B (Marca)")
        public string Productos { get; set; }

        // Propiedades adicionales por compatibilidad si se requieren en otros informes
        public string NombreProducto { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }


    }
}
