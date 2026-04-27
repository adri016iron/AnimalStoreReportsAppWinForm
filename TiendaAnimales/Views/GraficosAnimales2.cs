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

namespace TiendaAnimales
{
    public partial class GraficosAnimales2 : Form
    {
        private DatosTienda datosCargados;
        private XmlDataService service;
        public GraficosAnimales2()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GraficosAnimales2_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                string rutaInformeClientes = Path.Combine(Application.StartupPath, "Reports", "reporteGraficoAnimalEdad.rdlc");

                service = new XmlDataService();
                datosCargados = service.CargarDatos(rutaXml);

                if (!File.Exists(rutaInformeClientes))
                    throw new FileNotFoundException("No se encontró el informe de animales por edad", rutaInformeClientes);

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = rutaInformeClientes;

                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource source = new ReportDataSource(
                    "DataSet1",
                    datosCargados.Animales ?? new List<Animal>()
                );

                reportViewer1.LocalReport.DataSources.Add(source);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar el informe: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
