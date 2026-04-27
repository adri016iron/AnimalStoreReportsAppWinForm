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
    public partial class ViewClientes : Form
    {
        private List<Cliente> listaClientes;

        public ViewClientes()
        {
            InitializeComponent();
        }

        private void FiltrarClientes()
        {
            if (listaClientes == null)
                return;

            string filtro = textBox1.Text.Trim().ToLower();

            var clientesFiltrados = listaClientes
                .Where(c =>
                    string.IsNullOrEmpty(filtro) ||
                    (c.Nombre != null && c.Nombre.ToLower().Contains(filtro)) ||
                    (c.Apellido != null && c.Apellido.ToLower().Contains(filtro)) ||
                    (c.Email != null && c.Email.ToLower().Contains(filtro)) ||
                    (c.Telefono != null && c.Telefono.ToLower().Contains(filtro)) ||
                    (c.Ciudad != null && c.Ciudad.ToLower().Contains(filtro))
                )
                .ToList();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetClientes", clientesFiltrados)
            );

            reportViewer1.RefreshReport();
        }

        private void ViewClientes_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                string rutaInformeClientes = Path.Combine(Application.StartupPath, "Reports", "tablaClientesIndex.rdlc");

                XmlDataService service = new XmlDataService();
                DatosTienda datos = service.CargarDatos(rutaXml);

                // AQUÍ ESTABA EL FALLO
                listaClientes = datos.Clientes;

                reportViewer1.LocalReport.ReportPath = rutaInformeClientes;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSetClientes", listaClientes)
                );

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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}