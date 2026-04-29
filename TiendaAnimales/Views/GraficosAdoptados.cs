using Microsoft.Reporting.WinForms;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TiendaAnimales.Entity;
using TiendaAnimales.Service;

namespace TiendaAnimales.Views
{
    public partial class GraficosAdoptados : Form
    {
        public GraficosAdoptados()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GraficosAdoptados_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                string rutaInforme = Path.Combine(Application.StartupPath, "Reports", "reporteGraficoAdoptados.rdlc");

                if (!File.Exists(rutaInforme))
                    throw new FileNotFoundException("No se encontro el informe.", rutaInforme);

                XmlDataService service = new XmlDataService();
                DatosTienda datos = service.CargarDatos(rutaXml);
                var resumen = datos.Animales
                    .GroupBy(a => a.DisponibleAdopcion ? "No adoptados" : "Adoptados")
                    .Select(g => new GraficoCantidadView { Etiqueta = g.Key, Cantidad = g.Count() })
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
