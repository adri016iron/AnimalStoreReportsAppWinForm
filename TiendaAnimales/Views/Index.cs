using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TiendaAnimales.Entity;
using TiendaAnimales.Service;

namespace TiendaAnimales
{
    public partial class Index : Form
    {
        private Button botonActivo = null;

        public Index()
        {
            InitializeComponent();

            // Déjala comentada hasta que el recurso exista de verdad
            // picMascotas.Image = Properties.Resources.Cachorro_y_gatito_juntos_en_calma2;

            estiloBotones();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath, "Data", "DatosTienda.xml");
                string rutaInforme = Path.Combine(Application.StartupPath, "Reports", "tablaProductosIndex.rdlc");
                string rutaInformeAnimales = Path.Combine(Application.StartupPath, "Reports", "tablaAnimalesIndex.rdlc");
                string rutaInformeAdopcion = Path.Combine(Application.StartupPath, "Reports", "tablaAdopcionIndex.rdlc");
                string rutaInformeClientes = Path.Combine(Application.StartupPath, "Reports", "tablaClientesIndex.rdlc");

                XmlDataService service = new XmlDataService();
                DatosTienda datos = service.CargarDatos(rutaXml);

                if (!File.Exists(rutaInforme))
                    throw new FileNotFoundException("No se encontró el informe de productos", rutaInforme);

                if (!File.Exists(rutaInformeAnimales))
                    throw new FileNotFoundException("No se encontró el informe de animales", rutaInformeAnimales);

                reportViewer1.LocalReport.ReportPath = rutaInforme;
                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer4.LocalReport.ReportPath = rutaInformeClientes;
                reportViewer4.LocalReport.DataSources.Clear();

                reportViewer3.LocalReport.ReportPath = rutaInformeAdopcion;
                reportViewer3.LocalReport.DataSources.Clear();

                reportViewerAnimales.LocalReport.ReportPath = rutaInformeAnimales;
                reportViewerAnimales.LocalReport.DataSources.Clear();

                ReportDataSource source = new ReportDataSource("DataSetProducto", datos.Productos);
                ReportDataSource sourceAnimales = new ReportDataSource("DataSetAnimales", datos.Animales);
                ReportDataSource sourceAdopcion = new ReportDataSource("DataSetAdopcion", datos.Adopciones);
                ReportDataSource sourceCliente = new ReportDataSource("DataSetClientes", datos.Clientes);

                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewerAnimales.LocalReport.DataSources.Add(sourceAnimales);
                reportViewer3.LocalReport.DataSources.Add(sourceAdopcion);
                reportViewer4.LocalReport.DataSources.Add(sourceCliente);
                reportViewer1.RefreshReport();
                reportViewerAnimales.RefreshReport();
                reportViewer3.RefreshReport();
                reportViewer4.RefreshReport();
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

        private void estiloBotones()
        {
            this.BackColor = Color.WhiteSmoke;
            panelMenu.BackColor = Color.FromArgb(245, 245, 245);

            foreach (Control control in panelContenido.Controls)
            {
                if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.UseVisualStyleBackColor = false;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);

                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.FromArgb(40, 40, 40);
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;

                    btn.Padding = new Padding(8, 0, 8, 0);
                    btn.Margin = new Padding(8);
                    btn.Height = 45;
                    btn.Width = 160;
                    btn.Cursor = Cursors.Hand;
                    btn.AutoEllipsis = true;
                }
            }
        }

        private void ActivarBoton(Button btnSeleccionado)
        {
            if (botonActivo != null)
            {
                botonActivo.BackColor = Color.White;
                botonActivo.ForeColor = Color.FromArgb(40, 40, 40);
                botonActivo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            }

            botonActivo = btnSeleccionado;
            botonActivo.BackColor = Color.FromArgb(220, 235, 255);
            botonActivo.ForeColor = Color.FromArgb(0, 70, 140);
            botonActivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnInicio);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnProductos);
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnAnimales);
        }

        private void btnAdopcion_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnAdopcion);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnClientes);
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnGraficos);
        }

        private void btnTodosProductos_Click(object sender, EventArgs e)
        {
            ViewProductos view = new ViewProductos();
            view.Show();
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            ViewProductos view = new ViewProductos();
            view.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAnimales view = new ViewAnimales();
            view.Show();
        }

        private void btnAnimales_Click_1(object sender, EventArgs e)
        {
            ViewAnimales view = new ViewAnimales();
            view.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAdopciones view = new ViewAdopciones();
            view.Show();
        }

        private void btnAdopcion_Click_1(object sender, EventArgs e)
        {
            ViewAdopciones view = new ViewAdopciones();
            view.Show();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            ViewClientes view = new ViewClientes();
            view.Show();
        }

        private void btnProovedores_Click(object sender, EventArgs e)
        {
            ViewProovedores view = new ViewProovedores();
            view.Show();
        }

        private void btnGraficos_Click_1(object sender, EventArgs e)
        {
            Graficos view = new Graficos();
            view.Show();
        }
    }
}