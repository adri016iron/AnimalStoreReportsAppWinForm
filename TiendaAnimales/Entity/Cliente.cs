using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAnimales.Entity
{
    internal class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(int id, string nombre, string apellido, string email, string telefono, string ciudad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Ciudad = ciudad;
        }


        public int Id { get;  set; }
        public string Nombre { get;  set; }
        public string Apellido { get;  set; }
        public string Email { get;  set; }
        public string Telefono { get;  set; }
        public string Ciudad { get;  set; }
    }
}
