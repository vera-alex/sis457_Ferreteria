namespace CpFerreteria
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.rbtCatalogos = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaCategoria = new C1.Win.Ribbon.RibbonButton();
            this.btnCaProductos = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaProveedor = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaCliente = new C1.Win.Ribbon.RibbonButton();
            this.rbtComprasVentas = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCVCompras = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup5 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCVVentas = new C1.Win.Ribbon.RibbonButton();
            this.rbtReporte = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup7 = new C1.Win.Ribbon.RibbonGroup();
            this.btnReRegistroVentas = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup8 = new C1.Win.Ribbon.RibbonGroup();
            this.btnReRegistroCompras = new C1.Win.Ribbon.RibbonButton();
            this.rbtAdministracion = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup11 = new C1.Win.Ribbon.RibbonGroup();
            this.btnAdEmpleado = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup6 = new C1.Win.Ribbon.RibbonGroup();
            this.btnAdUsuario = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(1482, 201);
            this.c1Ribbon1.Tabs.Add(this.rbtCatalogos);
            this.c1Ribbon1.Tabs.Add(this.rbtComprasVentas);
            this.c1Ribbon1.Tabs.Add(this.rbtReporte);
            this.c1Ribbon1.Tabs.Add(this.rbtAdministracion);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // rbtCatalogos
            // 
            this.rbtCatalogos.Groups.Add(this.ribbonGroup1);
            this.rbtCatalogos.Groups.Add(this.ribbonGroup2);
            this.rbtCatalogos.Groups.Add(this.ribbonGroup3);
            this.rbtCatalogos.Name = "rbtCatalogos";
            this.rbtCatalogos.Text = "Catálogos";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnCaCategoria);
            this.ribbonGroup1.Items.Add(this.btnCaProductos);
            this.ribbonGroup1.Name = "ribbonGroup1";
            // 
            // btnCaCategoria
            // 
            this.btnCaCategoria.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaCategoria.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(64, 64), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaCategoria.IconSet")))));
            this.btnCaCategoria.Name = "btnCaCategoria";
            this.btnCaCategoria.Text = "Categorías";
            this.btnCaCategoria.Click += new System.EventHandler(this.btnCaCategoria_Click);
            // 
            // btnCaProductos
            // 
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(128, 128), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaProductos.IconSet")))));
            this.btnCaProductos.Name = "btnCaProductos";
            this.btnCaProductos.Text = "Productos";
            this.btnCaProductos.Click += new System.EventHandler(this.btnCaProductos_Click);
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.btnCaProveedor);
            this.ribbonGroup2.Name = "ribbonGroup2";
            // 
            // btnCaProveedor
            // 
            this.btnCaProveedor.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProveedor.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(128, 128), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaProveedor.IconSet")))));
            this.btnCaProveedor.Name = "btnCaProveedor";
            this.btnCaProveedor.Text = "Proveedores";
            this.btnCaProveedor.Click += new System.EventHandler(this.btnCaProveedor_Click);
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.btnCaCliente);
            this.ribbonGroup3.Name = "ribbonGroup3";
            // 
            // btnCaCliente
            // 
            this.btnCaCliente.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaCliente.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(128, 128), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaCliente.IconSet")))));
            this.btnCaCliente.Name = "btnCaCliente";
            this.btnCaCliente.Text = "Clientes";
            this.btnCaCliente.Click += new System.EventHandler(this.btnCaCliente_Click);
            // 
            // rbtComprasVentas
            // 
            this.rbtComprasVentas.Groups.Add(this.ribbonGroup4);
            this.rbtComprasVentas.Groups.Add(this.ribbonGroup5);
            this.rbtComprasVentas.Name = "rbtComprasVentas";
            this.rbtComprasVentas.Text = "Compras/Ventas";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.btnCVCompras);
            this.ribbonGroup4.Name = "ribbonGroup4";
            // 
            // btnCVCompras
            // 
            this.btnCVCompras.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCVCompras.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(128, 128), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCVCompras.IconSet")))));
            this.btnCVCompras.Name = "btnCVCompras";
            this.btnCVCompras.Text = "Compras";
            this.btnCVCompras.Click += new System.EventHandler(this.btnCVCompras_Click);
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Items.Add(this.btnCVVentas);
            this.ribbonGroup5.Name = "ribbonGroup5";
            // 
            // btnCVVentas
            // 
            this.btnCVVentas.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCVVentas.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(128, 128), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCVVentas.IconSet")))));
            this.btnCVVentas.Name = "btnCVVentas";
            this.btnCVVentas.Text = "Ventas";
            this.btnCVVentas.Click += new System.EventHandler(this.btnCVVentas_Click);
            // 
            // rbtReporte
            // 
            this.rbtReporte.Groups.Add(this.ribbonGroup7);
            this.rbtReporte.Groups.Add(this.ribbonGroup8);
            this.rbtReporte.Name = "rbtReporte";
            this.rbtReporte.Text = "Reportes";
            // 
            // ribbonGroup7
            // 
            this.ribbonGroup7.Items.Add(this.btnReRegistroVentas);
            this.ribbonGroup7.Name = "ribbonGroup7";
            // 
            // btnReRegistroVentas
            // 
            this.btnReRegistroVentas.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnReRegistroVentas.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(128, 128), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnReRegistroVentas.IconSet")))));
            this.btnReRegistroVentas.Name = "btnReRegistroVentas";
            this.btnReRegistroVentas.Text = "Registro de Ventas";
            this.btnReRegistroVentas.Click += new System.EventHandler(this.btnReRegistroVentas_Click);
            // 
            // ribbonGroup8
            // 
            this.ribbonGroup8.Items.Add(this.btnReRegistroCompras);
            this.ribbonGroup8.Name = "ribbonGroup8";
            // 
            // btnReRegistroCompras
            // 
            this.btnReRegistroCompras.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnReRegistroCompras.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(128, 128), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnReRegistroCompras.IconSet")))));
            this.btnReRegistroCompras.Name = "btnReRegistroCompras";
            this.btnReRegistroCompras.Text = "Registro de Compras";
            this.btnReRegistroCompras.Click += new System.EventHandler(this.btnReRegistroCompras_Click);
            // 
            // rbtAdministracion
            // 
            this.rbtAdministracion.Groups.Add(this.ribbonGroup11);
            this.rbtAdministracion.Groups.Add(this.ribbonGroup6);
            this.rbtAdministracion.Name = "rbtAdministracion";
            this.rbtAdministracion.Text = "Administración";
            // 
            // ribbonGroup11
            // 
            this.ribbonGroup11.Items.Add(this.btnAdEmpleado);
            this.ribbonGroup11.Name = "ribbonGroup11";
            // 
            // btnAdEmpleado
            // 
            this.btnAdEmpleado.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAdEmpleado.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(128, 128), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnAdEmpleado.IconSet")))));
            this.btnAdEmpleado.Name = "btnAdEmpleado";
            this.btnAdEmpleado.Text = "Empleados";
            this.btnAdEmpleado.Click += new System.EventHandler(this.btnAdEmpleado_Click);
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Items.Add(this.btnAdUsuario);
            this.ribbonGroup6.Name = "ribbonGroup6";
            // 
            // btnAdUsuario
            // 
            this.btnAdUsuario.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAdUsuario.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(128, 128), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnAdUsuario.IconSet")))));
            this.btnAdUsuario.Name = "btnAdUsuario";
            this.btnAdUsuario.Text = "Usuarios";
            this.btnAdUsuario.Click += new System.EventHandler(this.btnAdUsuario_Click);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 201);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1482, 852);
            this.pnlContenedor.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1482, 1053);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Todo en Uno - Principal :::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab rbtCatalogos;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonButton btnCaProductos;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonButton btnCaProveedor;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonButton btnCaCliente;
        private C1.Win.Ribbon.RibbonTab rbtComprasVentas;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.Ribbon.RibbonButton btnCVCompras;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.Ribbon.RibbonButton btnCVVentas;
        private C1.Win.Ribbon.RibbonTab rbtAdministracion;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup6;
        private C1.Win.Ribbon.RibbonButton btnAdUsuario;
        private System.Windows.Forms.Panel pnlContenedor;
        private C1.Win.Ribbon.RibbonButton btnCaCategoria;
        private C1.Win.Ribbon.RibbonTab rbtReporte;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup7;
        private C1.Win.Ribbon.RibbonButton btnReRegistroVentas;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup8;
        private C1.Win.Ribbon.RibbonButton btnReRegistroCompras;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup11;
        private C1.Win.Ribbon.RibbonButton btnAdEmpleado;
    }
}