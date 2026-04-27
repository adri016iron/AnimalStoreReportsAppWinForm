namespace TiendaAnimales
{
    partial class ViewProductos
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
            this.panelContenido = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProovedores = new System.Windows.Forms.ComboBox();
            this.reportViewerFiltrado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewerG = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.picMascotas = new System.Windows.Forms.PictureBox();
            this.lblPanel = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelContenido.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.textBox1);
            this.panelContenido.Controls.Add(this.label3);
            this.panelContenido.Controls.Add(this.label2);
            this.panelContenido.Controls.Add(this.cmbProovedores);
            this.panelContenido.Controls.Add(this.reportViewerFiltrado);
            this.panelContenido.Controls.Add(this.label1);
            this.panelContenido.Controls.Add(this.reportViewerG);
            this.panelContenido.Controls.Add(this.panelMenu);
            this.panelContenido.Controls.Add(this.lblTitulo);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1065, 629);
            this.panelContenido.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seleccione el proovedor";
            // 
            // cmbProovedores
            // 
            this.cmbProovedores.FormattingEnabled = true;
            this.cmbProovedores.Location = new System.Drawing.Point(753, 48);
            this.cmbProovedores.Name = "cmbProovedores";
            this.cmbProovedores.Size = new System.Drawing.Size(272, 21);
            this.cmbProovedores.TabIndex = 10;
            this.cmbProovedores.SelectedIndexChanged += new System.EventHandler(this.cmbProovedores_SelectedIndexChanged_1);
            // 
            // reportViewerFiltrado
            // 
            this.reportViewerFiltrado.LocalReport.ReportEmbeddedResource = "TiendaAnimales.Service.tablaProductosIndex.rdlc";
            this.reportViewerFiltrado.Location = new System.Drawing.Point(618, 85);
            this.reportViewerFiltrado.Name = "reportViewerFiltrado";
            this.reportViewerFiltrado.ServerReport.BearerToken = null;
            this.reportViewerFiltrado.Size = new System.Drawing.Size(435, 532);
            this.reportViewerFiltrado.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Productos filtrados por proovedor";
            // 
            // reportViewerG
            // 
            this.reportViewerG.LocalReport.ReportEmbeddedResource = "TiendaAnimales.Service.tablaProductosIndex.rdlc";
            this.reportViewerG.Location = new System.Drawing.Point(163, 85);
            this.reportViewerG.Name = "reportViewerG";
            this.reportViewerG.ServerReport.BearerToken = null;
            this.reportViewerG.Size = new System.Drawing.Size(416, 532);
            this.reportViewerG.TabIndex = 7;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(130, 629);
            this.panelMenu.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.picMascotas);
            this.panel1.Controls.Add(this.lblPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 629);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picMascotas
            // 
            this.picMascotas.BackColor = System.Drawing.Color.Transparent;
            this.picMascotas.Image = global::TiendaAnimales.Properties.Resources.Cachorro_y_gatito_juntos_en_calma2;
            this.picMascotas.Location = new System.Drawing.Point(0, 509);
            this.picMascotas.Name = "picMascotas";
            this.picMascotas.Size = new System.Drawing.Size(127, 120);
            this.picMascotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMascotas.TabIndex = 2;
            this.picMascotas.TabStop = false;
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
            this.lblTitulo.Location = new System.Drawing.Point(146, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(440, 31);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Productos a la venta en la tienda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filtrar por nombre de producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ViewProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 629);
            this.Controls.Add(this.panelContenido);
            this.Name = "ViewProductos";
            this.Text = "ViewProductos";
            this.Load += new System.EventHandler(this.ViewProductos_Load);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMascotas;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProovedores;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFiltrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}