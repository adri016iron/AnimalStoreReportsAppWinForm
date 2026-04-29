using Microsoft.Reporting.WinForms;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TiendaAnimales.Entity;
using TiendaAnimales.Service;

namespace TiendaAnimales.Views
{
    public partial class GraficosProductosStockBajo : Form
    {
        public GraficosProductosStockBajo()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GraficosProductosStockBajo_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                string rutaInforme = Path.Combine(Application.StartupPath, "Reports", "reporteGraficoProductosStockBajo.rdlc");

                if (!File.Exists(rutaInforme))
                    throw new FileNotFoundException("No se encontro el informe.", rutaInforme);

                XmlDataService service = new XmlDataService();
                DatosTienda datos = service.CargarDatos(rutaXml);
                var resumen = datos.Productos
                    .Where(p => p.Stock < 5)
                    .Select(p => new GraficoCantidadView { Etiqueta = p.Nombre, Cantidad = p.Stock })
                    .OrderBy(x => x.Cantidad)
                    .ToList();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = rutaInforme;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetGraficoCantidad", resumen));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar el grafico: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
