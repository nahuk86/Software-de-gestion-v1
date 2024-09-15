namespace UI
{
    partial class Home_deposito
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verStockProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarStockProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMovimientosProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(156, 653);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.listarProductosToolStripMenuItem,
            this.buscarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // crearNuevoProductoToolStripMenuItem
            // 
            this.crearNuevoProductoToolStripMenuItem.Name = "crearNuevoProductoToolStripMenuItem";
            this.crearNuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.crearNuevoProductoToolStripMenuItem.Text = "Crear nuevo producto";
            this.crearNuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.modificarProductoToolStripMenuItem.Text = "Modificar producto";
            // 
            // listarProductosToolStripMenuItem
            // 
            this.listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            this.listarProductosToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.listarProductosToolStripMenuItem.Text = "Listar productos";
            // 
            // buscarProductoToolStripMenuItem
            // 
            this.buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            this.buscarProductoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.buscarProductoToolStripMenuItem.Text = "Buscar producto";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verStockProductoToolStripMenuItem,
            this.actualizarStockProductoToolStripMenuItem,
            this.verMovimientosProductoToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // verStockProductoToolStripMenuItem
            // 
            this.verStockProductoToolStripMenuItem.Name = "verStockProductoToolStripMenuItem";
            this.verStockProductoToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.verStockProductoToolStripMenuItem.Text = "Ver stock producto";
            // 
            // actualizarStockProductoToolStripMenuItem
            // 
            this.actualizarStockProductoToolStripMenuItem.Name = "actualizarStockProductoToolStripMenuItem";
            this.actualizarStockProductoToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.actualizarStockProductoToolStripMenuItem.Text = "Actualizar stock producto";
            // 
            // verMovimientosProductoToolStripMenuItem
            // 
            this.verMovimientosProductoToolStripMenuItem.Name = "verMovimientosProductoToolStripMenuItem";
            this.verMovimientosProductoToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.verMovimientosProductoToolStripMenuItem.Text = "Ver movimientos producto";
            // 
            // Home_deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 653);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home_deposito";
            this.Text = "Home_deposito";
            this.Load += new System.EventHandler(this.Home_deposito_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verStockProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarStockProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMovimientosProductoToolStripMenuItem;
    }
}