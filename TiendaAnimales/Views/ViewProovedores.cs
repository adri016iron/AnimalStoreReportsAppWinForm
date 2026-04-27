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
    public partial class ViewProovedores : Form
    {
        private List<ProovedorProductoView> listaProveedorProducto;
        private List<Proovedor> listaProovedores;

        public ViewProovedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewProovedores_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                string rutaInforme1 = Path.Combine(Application.StartupPath, "Reports", "tablaProovedores.rdlc");
                string rutaInforme2 = Path.Combine(Application.StartupPath, "Reports", "tablaProovedoresProductos.rdlc");

                if (!File.Exists(rutaXml))
                    throw new FileNotFoundException("No se encontró el archivo XML de datos.", rutaXml);

                if (!File.Exists(rutaInforme1))
                    throw new FileNotFoundException("No se encontró el informe de proveedores.", rutaInforme1);

                if (!File.Exists(rutaInforme2))
                    throw new FileNotFoundException("No se encontró el informe de proveedores y productos.", rutaInforme2);

                XmlDataService service = new XmlDataService();
                DatosTienda datos = service.CargarDatos(rutaXml);

                if (datos == null)
                    throw new Exception("No se pudieron cargar los datos de la tienda.");

                if (datos.Proovedores == null)
                    throw new Exception("La lista de proveedores es nula.");

                if (datos.Productos == null)
                    throw new Exception("La lista de productos es nula.");

                listaProovedores = datos.Proovedores;

                listaProveedorProducto = datos.Proovedores
                    .Select(pr => new ProovedorProductoView
                    {
                        ProovedorNombre = pr.Nombre,
                        ProovedorId = pr.Id,
                        Productos = string.Join(", ", datos.Productos
                            .Where(prod => prod.ProovedorId == pr.Id)
                            .Select(prod => string.Format("{0} ({1})", prod.Nombre, prod.Marca)))
                    })
                    .ToList();

                reportViewer1.LocalReport.ReportPath = rutaInforme1;
                reportViewer2.LocalReport.ReportPath = rutaInforme2;

                CargarReportes(listaProovedores, listaProveedorProducto);
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

        private void CargarReportes(List<Proovedor> proveedoresFiltrados, List<ProovedorProductoView> proveedorProductoFiltrados)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetProovedor", proveedoresFiltrados)
            );
            reportViewer1.RefreshReport();

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetProovedorProducto", proveedorProductoFiltrados)
            );
            reportViewer2.RefreshReport();
        }

        private void FiltrarPorNombre()
        {
            if (listaProovedores == null || listaProveedorProducto == null)
                return;

            string filtroProveedor = textBox1.Text.Trim().ToLower();
            string filtroProducto = textBox2.Text.Trim().ToLower();

            // Filtrar proveedores
            var proveedoresFiltrados = listaProovedores
                .Where(p =>
                    (string.IsNullOrEmpty(filtroProveedor) ||
                        (p.Nombre != null && p.Nombre.ToLower().Contains(filtroProveedor)))
                )
                .ToList();

            // Filtrar proveedor + productos
            var proveedorProductoFiltrados = listaProveedorProducto
                .Where(p =>
                    (string.IsNullOrEmpty(filtroProveedor) ||
                        (p.ProovedorNombre != null && p.ProovedorNombre.ToLower().Contains(filtroProveedor)))
                    &&
                    (string.IsNullOrEmpty(filtroProducto) ||
                        (p.Productos != null && p.Productos.ToLower().Contains(filtroProducto)))
                )
                .ToList();

            CargarReportes(proveedoresFiltrados, proveedorProductoFiltrados);
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            FiltrarPorNombre();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FiltrarPorNombre();
        }
    }
}