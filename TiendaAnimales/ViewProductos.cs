using Microsoft.Reporting.WinForms;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TiendaAnimales.Entity;
using TiendaAnimales.Service;

namespace TiendaAnimales
{
    public partial class ViewProductos : Form
    {
        private DatosTienda datosCargados;
        private XmlDataService service;

        public ViewProductos()
        {
            InitializeComponent();
        }

        private void ViewProductos_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                string rutaInforme = Path.Combine(Application.StartupPath, "Service", "tablaProductosIndex.rdlc");

                service = new XmlDataService();
                datosCargados = service.CargarDatos(rutaXml);

                if (!File.Exists(rutaInforme))
                    throw new FileNotFoundException("No se encontró el informe de productos", rutaInforme);

                reportViewerG.ProcessingMode = ProcessingMode.Local;
                reportViewerG.LocalReport.ReportPath = rutaInforme;

                reportViewerFiltrado.ProcessingMode = ProcessingMode.Local;
                reportViewerFiltrado.LocalReport.ReportPath = rutaInforme;

                CargarComboProovedores();

                CargarReporteGeneral(datosCargados.Productos);
                CargarReporteFiltrado(datosCargados.Productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la vista: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CargarComboProovedores()
        {
            cmbProovedores.DataSource = null;

            var listaProovedores = datosCargados.Proovedores
                .Select(p => new ItemComboProveedor
                {
                    Id = p.Id,
                    Nombre = p.Nombre
                })
                .ToList();

            listaProovedores.Insert(0, new ItemComboProveedor
            {
                Id = 0,
                Nombre = "Todos"
            });

            cmbProovedores.DisplayMember = "Nombre";
            cmbProovedores.ValueMember = "Id";
            cmbProovedores.DataSource = listaProovedores;
            cmbProovedores.SelectedIndex = 0;
        }

        private void CargarReporteGeneral(object lista)
        {
            reportViewerG.LocalReport.DataSources.Clear();

            ReportDataSource source = new ReportDataSource("DataSetProducto", lista);
            reportViewerG.LocalReport.DataSources.Add(source);

            reportViewerG.RefreshReport();
        }

        private void CargarReporteFiltrado(object lista)
        {
            reportViewerFiltrado.LocalReport.DataSources.Clear();

            ReportDataSource source = new ReportDataSource("DataSetProducto", lista);
            reportViewerFiltrado.LocalReport.DataSources.Add(source);

            reportViewerFiltrado.RefreshReport();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Usted ya se encuentra en la pestaña de productos",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProovedores_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbProovedores.SelectedValue == null || datosCargados == null)
                return;

            int idProovedor;

            if (!int.TryParse(cmbProovedores.SelectedValue.ToString(), out idProovedor))
                return;

            if (idProovedor == 0)
            {
                CargarReporteFiltrado(datosCargados.Productos);
            }
            else
            {
                var productosFiltrados = datosCargados.Productos
                    .Where(p => p.ProovedorId == idProovedor)
                    .ToList();

                CargarReporteFiltrado(productosFiltrados);
            }
        }
    }

    public class ItemComboProveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}