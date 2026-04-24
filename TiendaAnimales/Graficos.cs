using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaAnimales
{
    public partial class Graficos : Form
    {
        public Graficos()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn && btn.Name != "btnVolver")
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.FromArgb(0, 150, 136);
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.Width = 150;
                    btn.Height = 80;
                    btn.Cursor = Cursors.Hand;
                }
            }

            lblTitulo.Text = "📊 Panel de gráficos";
            lblTitulo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 121, 107);

            button1.Text = "🐾\nAnimales por especie";
            button2.Text = "📦\nProductos por stock";
            button3.Text = "👥\nClientes por ciudad";
            button6 .Text = "📧\nClientes por email";
            button5.Text = "💰\nPrecio medio\npor categoría";
            button4.Text = "🏠\nAdoptados / no adoptados";
            button9.Text = "📊\nEdad media\npor especie";
            button8.Text = "⚠️\nProductos con\npoco stock";
            button7.Text = "🔤\nClientes por inicial";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraficoAnimales graficoAnimales = new GraficoAnimales();
            graficoAnimales.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GraficosProductos graficosProductos = new GraficosProductos();
            graficosProductos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GraficosClientes graficosClientes= new GraficosClientes();
            graficosClientes.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GraficosAnimales2 graficosAnimales2 = new GraficosAnimales2();
            graficosAnimales2.Show();
        }
    }
}
