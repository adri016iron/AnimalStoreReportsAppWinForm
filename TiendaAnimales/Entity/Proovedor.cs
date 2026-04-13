using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAnimales.Entity
{
    internal class Proovedor
    {
        public Proovedor()
        {
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Especialidad { get; set; }

        public Proovedor(int id, string nombre, string razonSocial, string email, string telefono, string ciudad, string especialidad)
        {
            Id = id;
            Nombre = nombre;
            RazonSocial = razonSocial;
            Email = email;
            Telefono = telefono;
            Ciudad = ciudad;
            Especialidad = especialidad;
        }
    }
}
