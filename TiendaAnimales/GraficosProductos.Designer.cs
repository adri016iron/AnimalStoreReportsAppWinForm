namespace TiendaAnimales
{
    partial class GraficosProductos
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
            this.btnProductos = new System.Windows.Forms.Button();
            this.lblPanel = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.picMascotas = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
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
            this.panelMenu.Size = new System.Drawing.Size(130, 482);
            this.panelMenu.TabIndex = 8;
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.picMascotas);
            this.panelContenido.Controls.Add(this.btnProductos);
            this.panelContenido.Controls.Add(this.lblPanel);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(130, 482);
            this.panelContenido.TabIndex = 4;
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(16, 49);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(103, 29);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "Volver";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
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
            this.lblTitulo.Location = new System.Drawing.Point(293, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(274, 31);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Productos por stock";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TiendaAnimales.Service.reportGraficosProductosCategoria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(148, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(640, 380);
            this.reportViewer1.TabIndex = 11;
            // 
            // picMascotas
            // 
            this.picMascotas.BackColor = System.Drawing.Color.Transparent;
            this.picMascotas.Image = global::TiendaAnimales.Properties.Resources.Cachorro_y_gatito_juntos_en_calma2;
            this.picMascotas.Location = new System.Drawing.Point(3, 362);
            this.picMascotas.Name = "picMascotas";
            this.picMascotas.Size = new System.Drawing.Size(127, 120);
            this.picMascotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMascotas.TabIndex = 2;
            this.picMascotas.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(148, 429);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(108, 43);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click_1);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(680, 429);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(108, 43);
            this.btnSiguiente.TabIndex = 12;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // GraficosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "GraficosProductos";
            this.Text = "GraficosProductos";
            this.Load += new System.EventHandler(this.GraficosProductos_Load);
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
        private System.Windows.Forms.PictureBox picMascotas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Label lblTitulo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
    }
}