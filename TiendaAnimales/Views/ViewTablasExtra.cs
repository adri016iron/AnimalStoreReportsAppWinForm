using Microsoft.Reporting.WinForms;
using System;
using System.IO;
using System.Windows.Forms;
using TiendaAnimales.Entity;
using TiendaAnimales.Service;

namespace TiendaAnimales
{
    public partial class ViewTablasExtra : Form
    {
        public ViewTablasExtra()
        {
            InitializeComponent();
        }

        private void ViewTablasExtra_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                string rutaInventario = Path.Combine(Application.StartupPath, "Reports", "tablaInventarioCategoria.rdlc");
                string rutaPreparacion = Path.Combine(Application.StartupPath, "Reports", "tablaAnimalesPreparacion.rdlc");

                XmlDataService service = new XmlDataService();
                DatosTienda datos = service.CargarDatos(rutaXml);

                reportViewerInventario.ProcessingMode = ProcessingMode.Local;
                reportViewerInventario.LocalReport.ReportPath = rutaInventario;
                reportViewerInventario.LocalReport.DataSources.Clear();
                reportViewerInventario.LocalReport.DataSources.Add(new ReportDataSource("DataSetProducto", datos.Productos));
                reportViewerInventario.RefreshReport();

                reportViewerAnimales.ProcessingMode = ProcessingMode.Local;
                reportViewerAnimales.LocalReport.ReportPath = rutaPreparacion;
                reportViewerAnimales.LocalReport.DataSources.Clear();
                reportViewerAnimales.LocalReport.DataSources.Add(new ReportDataSource("DataSetAnimales", datos.Animales));
                reportViewerAnimales.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las tablas extra: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
