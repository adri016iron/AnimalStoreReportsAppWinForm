using System;

namespace TiendaAnimales.Entity
{
    internal class Producto
    {
        public Producto()
        {
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public int Stock { get; set; }
        public int ProovedorId { get; set; }

        public Producto(int id, string nombre, string marca, string categoria, decimal precio, int stock, int idProveedor, DateTime fechaCaducidad)
        {
            Id = id;
            Nombre = nombre;
            Marca = marca;
            Categoria = categoria;
            Precio = precio;
            Stock = stock;
            FechaCaducidad = fechaCaducidad;
            ProovedorId = idProveedor;
        }
    }
}
