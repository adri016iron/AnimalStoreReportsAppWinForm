using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAnimales.Entity
{
    internal class DatosTienda
    {
        public List<Proovedor> Proovedores { get; set; } = new List<Proovedor>();
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Animal> Animales { get; set; } = new List<Animal>();
        public List<Adopcion> Adopciones { get; set; } = new List<Adopcion>();


    }
}
