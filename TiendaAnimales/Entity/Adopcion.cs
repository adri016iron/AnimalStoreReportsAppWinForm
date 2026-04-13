using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAnimales.Entity
{
    internal class Adopcion
    {
        public Adopcion()
        {
        }

        public int Id { get; set; }
        public int IdAnimal { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaAdopcion { get; set; }
        public string Estado { get; set; }
        public double CosteTramite { get; set; }

        public Adopcion(int id, int idAnimal, int idCliente, DateTime fechaSolicitud, DateTime fechaAdopcion, string estado, double costeTramite)
        {
            Id = id;
            IdAnimal = idAnimal;
            IdCliente = idCliente;
            FechaSolicitud = fechaSolicitud;
            FechaAdopcion = fechaAdopcion;
            Estado = estado;
            CosteTramite = costeTramite;
        }
    }
}
