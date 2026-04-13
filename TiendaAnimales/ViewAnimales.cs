using Microsoft.Reporting.WinForms;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TiendaAnimales.Entity;
using TiendaAnimales.Service;

namespace TiendaAnimales
{
    public partial class ViewAnimales : Form
    {
        private DatosTienda datosCargados;
        private XmlDataService service;

        public ViewAnimales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAnimales_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                string rutaInformeAnimales = Path.Combine(Application.StartupPath, "Service", "tablaAnimalesIndex.rdlc");

                service = new XmlDataService();
                datosCargados = service.CargarDatos(rutaXml);

                if (!File.Exists(rutaInformeAnimales))
                    throw new FileNotFoundException("No se encontró el informe de animales", rutaInformeAnimales);

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = rutaInformeAnimales;

                CargarComboEspecie();
                AplicarFiltros();
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

        private void CargarComboEspecie()
        {
            comboBox1.DataSource = null;

            var listaEspecies = datosCargados.Animales
                .Select(a => a.Especie)
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .Distinct()
                .OrderBy(e => e)
                .ToList();

            listaEspecies.Insert(0, "Todos");

            comboBox1.DataSource = listaEspecies;
            comboBox1.SelectedIndex = 0;
        }

        private void CargarReporte(object lista)
        {
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource sourceAnimales = new ReportDataSource("DataSetAnimales", lista);
            reportViewer1.LocalReport.DataSources.Add(sourceAnimales);

            reportViewer1.RefreshReport();
        }

        private void AplicarFiltros()
        {
            if (datosCargados == null || datosCargados.Animales == null)
                return;

            var animalesFiltrados = datosCargados.Animales.AsEnumerable();

            string especieSeleccionada = comboBox1.SelectedItem?.ToString();
            string textoBusqueda = textBox1.Text.Trim().ToLower();
            bool soloDisponibles = checkBox1.Checked;

            if (!string.IsNullOrWhiteSpace(especieSeleccionada) && especieSeleccionada != "Todos")
            {
                animalesFiltrados = animalesFiltrados.Where(a =>
                    !string.IsNullOrWhiteSpace(a.Especie) &&
                    a.Especie.Equals(especieSeleccionada, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(textoBusqueda))
            {
                animalesFiltrados = animalesFiltrados.Where(a =>
                    !string.IsNullOrWhiteSpace(a.Nombre) &&
                    a.Nombre.ToLower().Contains(textoBusqueda));
            }

            if (soloDisponibles)
            {
                animalesFiltrados = animalesFiltrados.Where(a => a.DisponibleAdopcion);
            }

            CargarReporte(animalesFiltrados.ToList());
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
    }
}