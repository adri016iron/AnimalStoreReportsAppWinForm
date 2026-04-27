using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void GraficosProductosStockBajo_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                string rutaInforme = Path.Combine(Application.StartupPath, "Reports", "reporteGraficoProductosStockBajo.rdlc");

                XmlDataService service = new XmlDataService();
                DatosTienda datos = service.CargarDatos(rutaXml);

                var productosStockBajo = datos.Productos
                    .Where(p => p.Stock < 5)
                    .ToList();

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = rutaInforme;
                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource source = new ReportDataSource(
                    "DataSetProducto",
                    productosStockBajo
                );

                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message);
            }
        }

        private void GraficosProductosStockBajo_Load_1(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
