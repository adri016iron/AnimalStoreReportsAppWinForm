using Microsoft.Reporting.WinForms;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TiendaAnimales.Entity;
using TiendaAnimales.Service;

namespace TiendaAnimales.Views
{
    public partial class GraficosPrecioMedioCategoria : Form
    {
        public GraficosPrecioMedioCategoria()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GraficosPrecioMedioCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                string rutaInforme = Path.Combine(Application.StartupPath, "Reports", "reporteGraficoPrecioMedioCategoria.rdlc");

                if (!File.Exists(rutaInforme))
                    throw new FileNotFoundException("No se encontro el informe.", rutaInforme);

                XmlDataService service = new XmlDataService();
                DatosTienda datos = service.CargarDatos(rutaXml);
                var resumen = datos.Productos
                    .GroupBy(p => string.IsNullOrWhiteSpace(p.Categoria) ? "Sin categoria" : p.Categoria)
                    .Select(g => new GraficoDecimalView { Etiqueta = g.Key, Valor = g.Average(p => p.Precio) })
                    .OrderByDescending(x => x.Valor)
                    .ToList();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = rutaInforme;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetGraficoDecimal", resumen));
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
