namespace TiendaAnimales
{
    partial class ViewTablasExtra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblPanel = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblPreparacion = new System.Windows.Forms.Label();
            this.reportViewerInventario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerAnimales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelMenu.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMenu.Controls.Add(this.panelContenido);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(130, 620);
            this.panelMenu.TabIndex = 0;
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.btnVolver);
            this.panelContenido.Controls.Add(this.lblPanel);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(130, 620);
            this.panelContenido.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(14, 52);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(103, 29);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel.Location = new System.Drawing.Point(12, 9);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(107, 20);
            this.lblPanel.TabIndex = 0;
            this.lblPanel.Text = "Tienda animal";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(150, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(354, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Tablas de analisis adicional";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Location = new System.Drawing.Point(153, 63);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(180, 13);
            this.lblInventario.TabIndex = 2;
            this.lblInventario.Text = "Inventario por categoria y valor total";
            // 
            // lblPreparacion
            // 
            this.lblPreparacion.AutoSize = true;
            this.lblPreparacion.Location = new System.Drawing.Point(646, 63);
            this.lblPreparacion.Name = "lblPreparacion";
            this.lblPreparacion.Size = new System.Drawing.Size(192, 13);
            this.lblPreparacion.TabIndex = 3;
            this.lblPreparacion.Text = "Preparacion de animales para adopcion";
            // 
            // reportViewerInventario
            // 
            this.reportViewerInventario.Location = new System.Drawing.Point(154, 86);
            this.reportViewerInventario.Name = "reportViewerInventario";
            this.reportViewerInventario.ServerReport.BearerToken = null;
            this.reportViewerInventario.Size = new System.Drawing.Size(470, 515);
            this.reportViewerInventario.TabIndex = 4;
            // 
            // reportViewerAnimales
            // 
            this.reportViewerAnimales.Location = new System.Drawing.Point(649, 86);
            this.reportViewerAnimales.Name = "reportViewerAnimales";
            this.reportViewerAnimales.ServerReport.BearerToken = null;
            this.reportViewerAnimales.Size = new System.Drawing.Size(470, 515);
            this.reportViewerAnimales.TabIndex = 5;
            // 
            // ViewTablasExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 620);
            this.Controls.Add(this.reportViewerAnimales);
            this.Controls.Add(this.reportViewerInventario);
            this.Controls.Add(this.lblPreparacion);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "ViewTablasExtra";
            this.Text = "Tablas adicionales";
            this.Load += new System.EventHandler(this.ViewTablasExtra_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblPreparacion;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInventario;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAnimales;
    }
}
