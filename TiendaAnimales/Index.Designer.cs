namespace TiendaAnimales
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnProovedores = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picMascotas = new System.Windows.Forms.PictureBox();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnAdopcion = new System.Windows.Forms.Button();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblPanel = new System.Windows.Forms.Label();
            this.panelProductosData = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTodosProductos = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewerAnimales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelMenu.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascotas)).BeginInit();
            this.panelProductosData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(132, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(480, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenidos a la tienda de animales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "En este apartado podrás visualizar las tablas y gestionar los datos";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMenu.Controls.Add(this.panelContenido);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(130, 578);
            this.panelMenu.TabIndex = 3;
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.btnProovedores);
            this.panelContenido.Controls.Add(this.btnSalir);
            this.panelContenido.Controls.Add(this.picMascotas);
            this.panelContenido.Controls.Add(this.btnGraficos);
            this.panelContenido.Controls.Add(this.btnClientes);
            this.panelContenido.Controls.Add(this.btnAdopcion);
            this.panelContenido.Controls.Add(this.btnAnimales);
            this.panelContenido.Controls.Add(this.btnProductos);
            this.panelContenido.Controls.Add(this.btnInicio);
            this.panelContenido.Controls.Add(this.lblPanel);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(130, 578);
            this.panelContenido.TabIndex = 4;
            // 
            // btnProovedores
            // 
            this.btnProovedores.Location = new System.Drawing.Point(16, 253);
            this.btnProovedores.Name = "btnProovedores";
            this.btnProovedores.Size = new System.Drawing.Size(103, 29);
            this.btnProovedores.TabIndex = 11;
            this.btnProovedores.Text = "👨‍💼Proovedor";
            this.btnProovedores.UseVisualStyleBackColor = true;
            this.btnProovedores.Click += new System.EventHandler(this.btnProovedores_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(16, 288);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 29);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "📤 Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picMascotas
            // 
            this.picMascotas.BackColor = System.Drawing.Color.Transparent;
            this.picMascotas.Image = global::TiendaAnimales.Properties.Resources.Cachorro_y_gatito_juntos_en_calma2;
            this.picMascotas.Location = new System.Drawing.Point(3, 458);
            this.picMascotas.Name = "picMascotas";
            this.picMascotas.Size = new System.Drawing.Size(127, 120);
            this.picMascotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMascotas.TabIndex = 2;
            this.picMascotas.TabStop = false;
            // 
            // btnGraficos
            // 
            this.btnGraficos.Location = new System.Drawing.Point(16, 218);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(103, 29);
            this.btnGraficos.TabIndex = 9;
            this.btnGraficos.Text = "📊 Gráficos";
            this.btnGraficos.UseVisualStyleBackColor = true;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click_1);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(16, 183);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(103, 29);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Text = "👤 Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnAdopcion
            // 
            this.btnAdopcion.Location = new System.Drawing.Point(16, 148);
            this.btnAdopcion.Name = "btnAdopcion";
            this.btnAdopcion.Size = new System.Drawing.Size(103, 29);
            this.btnAdopcion.TabIndex = 7;
            this.btnAdopcion.Text = "❤️ Adopcion";
            this.btnAdopcion.UseVisualStyleBackColor = true;
            this.btnAdopcion.Click += new System.EventHandler(this.btnAdopcion_Click_1);
            // 
            // btnAnimales
            // 
            this.btnAnimales.Location = new System.Drawing.Point(16, 113);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(103, 29);
            this.btnAnimales.TabIndex = 6;
            this.btnAnimales.Text = "🐾 Animales";
            this.btnAnimales.UseVisualStyleBackColor = true;
            this.btnAnimales.Click += new System.EventHandler(this.btnAnimales_Click_1);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(16, 78);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(103, 29);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "🛒 Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click_1);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(16, 43);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(103, 29);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "🏠 Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
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
            // panelProductosData
            // 
            this.panelProductosData.Controls.Add(this.label2);
            this.panelProductosData.Controls.Add(this.btnTodosProductos);
            this.panelProductosData.Controls.Add(this.reportViewer1);
            this.panelProductosData.Location = new System.Drawing.Point(146, 68);
            this.panelProductosData.Name = "panelProductosData";
            this.panelProductosData.Size = new System.Drawing.Size(330, 234);
            this.panelProductosData.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Productos";
            // 
            // btnTodosProductos
            // 
            this.btnTodosProductos.Location = new System.Drawing.Point(243, 200);
            this.btnTodosProductos.Name = "btnTodosProductos";
            this.btnTodosProductos.Size = new System.Drawing.Size(84, 34);
            this.btnTodosProductos.TabIndex = 1;
            this.btnTodosProductos.Text = "Ver todos";
            this.btnTodosProductos.UseVisualStyleBackColor = true;
            this.btnTodosProductos.Click += new System.EventHandler(this.btnTodosProductos_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TiendaAnimales.Service.tablaProductosIndex.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(30, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(279, 163);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.reportViewerAnimales);
            this.panel1.Location = new System.Drawing.Point(482, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 234);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Animales";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewerAnimales
            // 
            this.reportViewerAnimales.LocalReport.ReportEmbeddedResource = "TiendaAnimales.Service.tablaProductosIndex.rdlc";
            this.reportViewerAnimales.Location = new System.Drawing.Point(32, 31);
            this.reportViewerAnimales.Name = "reportViewerAnimales";
            this.reportViewerAnimales.ServerReport.BearerToken = null;
            this.reportViewerAnimales.Size = new System.Drawing.Size(279, 163);
            this.reportViewerAnimales.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.reportViewer3);
            this.panel2.Location = new System.Drawing.Point(146, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 270);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adopciones";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ver todos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer3
            // 
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "TiendaAnimales.Service.tablaProductosIndex.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(30, 57);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(279, 163);
            this.reportViewer3.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.reportViewer4);
            this.panel3.Location = new System.Drawing.Point(482, 308);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 270);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Clientes";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "Ver todos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "TiendaAnimales.Service.tablaProductosIndex.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(32, 57);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(279, 163);
            this.reportViewer4.TabIndex = 0;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 578);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelProductosData);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Index";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Index_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascotas)).EndInit();
            this.panelProductosData.ResumeLayout(false);
            this.panelProductosData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.PictureBox picMascotas;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAdopcion;
        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Panel panelProductosData;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnTodosProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerAnimales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProovedores;
    }
}

