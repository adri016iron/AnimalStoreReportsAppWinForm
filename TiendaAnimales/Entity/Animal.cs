using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAnimales.Entity
{
    internal class Animal
    {
        public Animal()
        {
        }

        public int Id { get;  set; }
        public string Nombre { get;  set; }
        public string Especie { get;  set; }
        public int Edad { get;  set; }
        public string Sexo { get;  set; }
        public double Peso { get;  set; }
        public bool Vacunado { get;  set; }
        public bool Esterilizado { get;  set; }
        public DateTime FechaIngreso { get;  set; }
        public string NotasSalud { get;  set; }
        public bool DisponibleAdopcion { get;  set; }

        public Animal(int id, string nombre, string especie, int edad, string sexo, double peso, bool vacunado, bool esterilizado, DateTime fechaIngreso, string notasSalud, bool disponibleAdopcion)
        {
            Id = id;
            Nombre = nombre;
            Especie = especie;
            Edad = edad;
            Sexo = sexo;
            Peso = peso;
            Vacunado = vacunado;
            Esterilizado = esterilizado;
            FechaIngreso = fechaIngreso;
            NotasSalud = notasSalud;
            DisponibleAdopcion = disponibleAdopcion;
        }
    }
}
