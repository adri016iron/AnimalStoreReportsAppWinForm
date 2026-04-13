using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TiendaAnimales.Entity;

namespace TiendaAnimales.Service
{
    class XmlDataService
    {
        public DatosTienda CargarDatos(string rutaXml)
        {
            if (!File.Exists(rutaXml))
                throw new FileNotFoundException("No se encontró el archivo XML.", rutaXml);

            XDocument doc = XDocument.Load(rutaXml);
            DatosTienda datos = new DatosTienda();

            // Proveedores
            var proveedores = doc.Root?
                .Element("Proveedores")?
                .Elements("Proveedor");

            if (proveedores != null)
            {
                datos.Proovedores = proveedores.Select(p => new Proovedor
                {
                    Id = LeerInt(p, "Id"),
                    Nombre = LeerString(p, "Nombre"),
                    Telefono = LeerString(p, "Telefono"),
                    Email = LeerString(p, "Email"),
                    Ciudad = LeerString(p, "Ciudad")
                }).ToList();
            }

            // Productos
            var productos = doc.Root?
                .Element("Productos")?
                .Elements("Producto");

            if (productos != null)
            {
                datos.Productos = productos.Select(p => new Producto
                {
                    Id = LeerInt(p, "Id"),
                    Nombre = LeerString(p, "Nombre"),
                    Marca = LeerString(p, "Marca"),
                    Precio = LeerDecimal(p, "Precio"),
                    Stock = LeerInt(p, "Stock"),
                    FechaCaducidad = LeerDateTimeNullable(p, "FechaCaducidad") ?? DateTime.MinValue,
                    ProovedorId = LeerInt(p, "ProveedorId")
                }).ToList();
            }

            // Animales
            var animales = doc.Root?
                .Element("Animales")?
                .Elements("Animal");

            if (animales != null)
            {
                datos.Animales = animales.Select(a => new Animal
                {
                    Id = LeerInt(a, "Id"),
                    Nombre = LeerString(a, "Nombre"),
                    Especie = LeerString(a, "Especie"),
                    Edad = LeerInt(a, "EdadMeses"),
                    Sexo = LeerString(a, "Sexo"),
                    Peso = LeerDouble(a, "Peso"),
                    Vacunado = LeerBool(a, "Vacunado"),
                    Esterilizado = LeerBool(a, "Esterilizado"),
                    FechaIngreso = LeerDateTime(a, "FechaIngreso"),
                    NotasSalud = LeerString(a, "EstadoSalud"),
                    DisponibleAdopcion = LeerBool(a, "DisponibleAdopcion")
                }).ToList();
            }

            // Clientes
            var clientes = doc.Root?
                .Element("Clientes")?
                .Elements("Cliente");

            if (clientes != null)
            {
                datos.Clientes = clientes.Select(c => new Cliente
                {
                    Id = LeerInt(c, "Id"),
                    Nombre = LeerString(c, "Nombre"),
                    Apellido = LeerString(c, "Apellido"),
                    Telefono = LeerString(c, "Telefono"),
                    Email = LeerString(c, "Email"),
                    Ciudad = LeerString(c, "Ciudad"),
                }).ToList();
            }

            // Adopciones
            var adopciones = doc.Root?
                .Element("Adopciones")?
                .Elements("Adopcion");

            if (adopciones != null)
            {
                datos.Adopciones = adopciones.Select(a => new Adopcion
                {
                    Id = LeerInt(a, "Id"),
                    IdAnimal = LeerInt(a, "AnimalId"),
                    IdCliente = LeerInt(a, "ClienteId"),
                    FechaSolicitud = LeerDateTime(a, "FechaSolicitud"),
                    FechaAdopcion = LeerDateTimeNullable(a, "FechaAdopcion") ?? DateTime.MinValue,
                    Estado = LeerString(a, "Estado"),
                    CosteTramite = LeerDouble(a, "CosteTramite")
                }).ToList();
            }

            return datos;
        }

        private string LeerString(XElement parent, string nombre)
        {
            return parent.Element(nombre)?.Value?.Trim() ?? string.Empty;
        }

        private int LeerInt(XElement parent, string nombre)
        {
            int.TryParse(parent.Element(nombre)?.Value, out int valor);
            return valor;
        }

        private decimal LeerDecimal(XElement parent, string nombre)
        {
            decimal.TryParse(
                parent.Element(nombre)?.Value,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out decimal valor);

            return valor;
        }

        private double LeerDouble(XElement parent, string nombre)
        {
            double.TryParse(
                parent.Element(nombre)?.Value,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out double valor);
            return valor;
        }

        private bool LeerBool(XElement parent, string nombre)
        {
            bool.TryParse(parent.Element(nombre)?.Value, out bool valor);
            return valor;
        }

        private DateTime LeerDateTime(XElement parent, string nombre)
        {
            DateTime.TryParse(parent.Element(nombre)?.Value, out DateTime valor);
            return valor;
        }

        private DateTime? LeerDateTimeNullable(XElement parent, string nombre)
        {
            string texto = parent.Element(nombre)?.Value;

            if (string.IsNullOrWhiteSpace(texto))
                return null;

            if (DateTime.TryParse(texto, out DateTime valor))
                return valor;

            return null;
        }

    }
}
