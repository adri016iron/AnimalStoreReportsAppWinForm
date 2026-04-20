namespace TiendaAnimales
{
    partial class ViewProovedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPanel = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.picMascotas = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMenu.Controls.Add(this.panelContenido);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(130, 570);
            this.panelMenu.TabIndex = 7;
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.picMascotas);
            this.panelContenido.Controls.Add(this.button1);
            this.panelContenido.Controls.Add(this.lblPanel);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(130, 570);
            this.panelContenido.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel.ForeColor = System.Drawing.Color.Black;
            this.lblPanel.Location = new System.Drawing.Point(12, 9);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(107, 20);
            this.lblPanel.TabIndex = 4;
            this.lblPanel.Text = "Tienda animal";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(148, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(558, 31);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Apartado de visualizacion de proovedores";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TiendaAnimales.Service.tablaProovedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(154, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(489, 457);
            this.reportViewer1.TabIndex = 9;
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "TiendaAnimales.Service.tablaProovedores.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(658, 101);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(489, 457);
            this.reportViewer2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Todos los proovedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Proovedores y sus productos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Filtrar por nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Filtrar por producto";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(752, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // picMascotas
            // 
            this.picMascotas.BackColor = System.Drawing.Color.Transparent;
            this.picMascotas.Image = global::TiendaAnimales.Properties.Resources.Cachorro_y_gatito_juntos_en_calma2;
            this.picMascotas.Location = new System.Drawing.Point(3, 447);
            this.picMascotas.Name = "picMascotas";
            this.picMascotas.Size = new System.Drawing.Size(127, 120);
            this.picMascotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMascotas.TabIndex = 17;
            this.picMascotas.TabStop = false;
            // 
            // ViewProovedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 570);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "ViewProovedores";
            this.Text = "ViewProovedores";
            this.Load += new System.EventHandler(this.ViewProovedores_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Label lblTitulo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox picMascotas;
    }
}