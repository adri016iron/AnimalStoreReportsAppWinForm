using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TiendaAnimales.Entity;
using TiendaAnimales.Service;

namespace TiendaAnimales
{
    public partial class ViewAdopciones : Form
    {
        private DatosTienda datos;
        private string rutaInformeAdopcion;
        private bool cargandoComboClientes = false;
        private bool cargandoComboAnimales = false;
        private List<AdopcionAnimalView> listaCompleta;

        public ViewAdopciones()
        {
            InitializeComponent();
        }

        private void ViewAdopciones_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                rutaInformeAdopcion = Path.Combine(Application.StartupPath, "Service", "tablaAdopcionIndex.rdlc");

                XmlDataService service = new XmlDataService();
                datos = service.CargarDatos(rutaXml);

                ConstruirListaCompleta();
                CargarClientesEnCombo();
                CargarAnimalesEnCombo();
                CargarInforme(listaCompleta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar el formulario: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CargarClientesEnCombo()
        {
            cargandoComboClientes = true;

            List<ClienteCombo> clientes = datos.Clientes
                .Select(c => new ClienteCombo
                {
                    Id = c.Id,
                    NombreCompleto = c.Nombre + " " + c.Apellido
                })
                .OrderBy(c => c.NombreCompleto)
                .ToList();

            clientes.Insert(0, new ClienteCombo
            {
                Id = 0,
                NombreCompleto = "Todos los clientes"
            });

            comboBox1.DataSource = null;
            comboBox1.DisplayMember = "NombreCompleto";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = clientes;
            comboBox1.SelectedIndex = 0;

            cargandoComboClientes = false;
        }

        private void CargarAnimalesEnCombo()
        {
            cargandoComboAnimales = true;

            List<AnimalCombo> animales = datos.Animales
                .Select(a => new AnimalCombo
                {
                    Id = a.Id,
                    Nombre = a.Nombre
                })
                .OrderBy(a => a.Nombre)
                .ToList();

            animales.Insert(0, new AnimalCombo
            {
                Id = 0,
                Nombre = "Todos los animales"
            });

            comboBox2.DataSource = null;
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "Id";
            comboBox2.DataSource = animales;
            comboBox2.SelectedIndex = 0;

            cargandoComboAnimales = false;
        }

        private void ConstruirListaCompleta()
        {
            listaCompleta = (
                from adopcion in datos.Adopciones
                join animal in datos.Animales on adopcion.IdAnimal equals animal.Id
                join cliente in datos.Clientes on adopcion.IdCliente equals cliente.Id
                select new AdopcionAnimalView
                {
                    Id = adopcion.Id,
                    IdAnimal = adopcion.IdAnimal,
                    IdCliente = adopcion.IdCliente,
                    Cliente = cliente.Nombre + " " + cliente.Apellido,
                    Animal = animal.Nombre,
                    Especie = animal.Especie,
                    FechaSolicitud = adopcion.FechaSolicitud,
                    FechaAdopcion = adopcion.FechaAdopcion,
                    Estado = adopcion.Estado,
                    CosteTramite = adopcion.CosteTramite
                }
            ).ToList();
        }

        private void CargarInforme(List<AdopcionAnimalView> lista)
        {
            reportViewer1.LocalReport.ReportPath = rutaInformeAdopcion;
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource source = new ReportDataSource("DataSetAdopcion", lista);
            reportViewer1.LocalReport.DataSources.Add(source);

            reportViewer1.RefreshReport();
        }

        private void AplicarFiltros()
        {
            try
            {
                if (listaCompleta == null)
                    return;

                int idCliente = 0;
                int idAnimal = 0;

                ClienteCombo clienteSeleccionado = comboBox1.SelectedItem as ClienteCombo;
                AnimalCombo animalSeleccionado = comboBox2.SelectedItem as AnimalCombo;

                if (clienteSeleccionado != null)
                    idCliente = clienteSeleccionado.Id;

                if (animalSeleccionado != null)
                    idAnimal = animalSeleccionado.Id;

                List<AdopcionAnimalView> listaFiltrada = listaCompleta
                    .Where(a =>
                        (idCliente == 0 || a.IdCliente == idCliente) &&
                        (idAnimal == 0 || a.IdAnimal == idAnimal)
                    )
                    .ToList();

                CargarInforme(listaFiltrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al filtrar las adopciones: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoComboClientes)
                return;

            AplicarFiltros();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoComboAnimales)
                return;

            AplicarFiltros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ClienteCombo
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
    }

    public class AnimalCombo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class AdopcionAnimalView
    {
        public int Id { get; set; }
        public int IdAnimal { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public string Animal { get; set; }
        public string Especie { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaAdopcion { get; set; }
        public string Estado { get; set; }
        public double CosteTramite { get; set; }
    }
}