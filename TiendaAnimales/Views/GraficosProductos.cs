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
    public partial class GraficosProductos : Form
    {
        private DatosTienda datosCargados;
        private XmlDataService service;

        private List<Producto> listaProductos = new List<Producto>();
        private int paginaActual = 0;
        private int tamPagina = 5;

        private string rutaInformeProductos;

        public GraficosProductos()
        {
            InitializeComponent();
        }

        private void GraficosProductos_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                rutaInformeProductos = Path.Combine(Application.StartupPath, "Reports", "reportGraficosProductos.rdlc");

                service = new XmlDataService();
                datosCargados = service.CargarDatos(rutaXml);

                if (!File.Exists(rutaInformeProductos))
                    throw new FileNotFoundException("No se encontró el informe de productos", rutaInformeProductos);

                listaProductos = (datosCargados.Productos ?? new List<Producto>())
                    .OrderByDescending(p => p.Stock)
                    .ToList();

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = rutaInformeProductos;

                MostrarPagina();
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
        }

        private void MostrarPagina()
        {
            var productosPagina = listaProductos
                .Skip(paginaActual * tamPagina)
                .Take(tamPagina)
                .ToList();

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource source = new ReportDataSource(
                "DataSetProducto",
                productosPagina
            );

            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();

            btnAnterior.Enabled = paginaActual > 0;
            btnSiguiente.Enabled = (paginaActual + 1) * tamPagina < listaProductos.Count;
        }


        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if ((paginaActual + 1) * tamPagina < listaProductos.Count)
            {
                paginaActual++;
                MostrarPagina();
            }
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (paginaActual > 0)
            {
                paginaActual--;
                MostrarPagina();
            }
        }
    }
}