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
        private bool cargandoCombo = false;
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

                CargarClientesEnCombo();
                ConstruirListaCompleta();
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
            cargandoCombo = true;

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

            cargandoCombo = false;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cargandoCombo)
                    return;

                if (comboBox1.SelectedItem == null)
                    return;

                ClienteCombo clienteSeleccionado = comboBox1.SelectedItem as ClienteCombo;
                if (clienteSeleccionado == null)
                    return;

                List<AdopcionAnimalView> listaFiltrada;

                if (clienteSeleccionado.Id == 0)
                {
                    listaFiltrada = listaCompleta;
                }
                else
                {
                    listaFiltrada = listaCompleta
                        .Where(a => a.IdCliente == clienteSeleccionado.Id)
                        .ToList();
                }

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