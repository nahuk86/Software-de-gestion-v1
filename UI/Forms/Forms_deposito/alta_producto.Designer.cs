namespace UI.Forms.Forms_deposito
{
    partial class alta_producto
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
            this.textBox_nombre_producto = new System.Windows.Forms.TextBox();
            this.textBox_valor_unitario_producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_marca_producto = new System.Windows.Forms.ComboBox();
            this.comboBox_proveedor_producto = new System.Windows.Forms.ComboBox();
            this.button_agregar_producto = new System.Windows.Forms.Button();
            this.comboBox_categoria_producto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_nombre_producto
            // 
            this.textBox_nombre_producto.Location = new System.Drawing.Point(234, 43);
            this.textBox_nombre_producto.Name = "textBox_nombre_producto";
            this.textBox_nombre_producto.Size = new System.Drawing.Size(196, 22);
            this.textBox_nombre_producto.TabIndex = 0;
            // 
            // textBox_valor_unitario_producto
            // 
            this.textBox_valor_unitario_producto.Location = new System.Drawing.Point(234, 238);
            this.textBox_valor_unitario_producto.Name = "textBox_valor_unitario_producto";
            this.textBox_valor_unitario_producto.Size = new System.Drawing.Size(196, 22);
            this.textBox_valor_unitario_producto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Unitario";
            // 
            // comboBox_marca_producto
            // 
            this.comboBox_marca_producto.FormattingEnabled = true;
            this.comboBox_marca_producto.Location = new System.Drawing.Point(234, 85);
            this.comboBox_marca_producto.Name = "comboBox_marca_producto";
            this.comboBox_marca_producto.Size = new System.Drawing.Size(196, 24);
            this.comboBox_marca_producto.TabIndex = 8;
            // 
            // comboBox_proveedor_producto
            // 
            this.comboBox_proveedor_producto.FormattingEnabled = true;
            this.comboBox_proveedor_producto.Location = new System.Drawing.Point(234, 135);
            this.comboBox_proveedor_producto.Name = "comboBox_proveedor_producto";
            this.comboBox_proveedor_producto.Size = new System.Drawing.Size(196, 24);
            this.comboBox_proveedor_producto.TabIndex = 9;
            // 
            // button_agregar_producto
            // 
            this.button_agregar_producto.Location = new System.Drawing.Point(293, 327);
            this.button_agregar_producto.Name = "button_agregar_producto";
            this.button_agregar_producto.Size = new System.Drawing.Size(137, 52);
            this.button_agregar_producto.TabIndex = 10;
            this.button_agregar_producto.Text = "Agregar nuevo producto";
            this.button_agregar_producto.UseVisualStyleBackColor = true;
            this.button_agregar_producto.Click += new System.EventHandler(this.button_agregar_producto_Click);
            // 
            // comboBox_categoria_producto
            // 
            this.comboBox_categoria_producto.FormattingEnabled = true;
            this.comboBox_categoria_producto.Location = new System.Drawing.Point(234, 188);
            this.comboBox_categoria_producto.Name = "comboBox_categoria_producto";
            this.comboBox_categoria_producto.Size = new System.Drawing.Size(196, 24);
            this.comboBox_categoria_producto.TabIndex = 12;
            this.comboBox_categoria_producto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Categoria";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // alta_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 441);
            this.Controls.Add(this.comboBox_categoria_producto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_agregar_producto);
            this.Controls.Add(this.comboBox_proveedor_producto);
            this.Controls.Add(this.comboBox_marca_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_valor_unitario_producto);
            this.Controls.Add(this.textBox_nombre_producto);
            this.Name = "alta_producto";
            this.Text = "alta_producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nombre_producto;
        private System.Windows.Forms.TextBox textBox_valor_unitario_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_marca_producto;
        private System.Windows.Forms.ComboBox comboBox_proveedor_producto;
        private System.Windows.Forms.Button button_agregar_producto;
        private System.Windows.Forms.ComboBox comboBox_categoria_producto;
        private System.Windows.Forms.Label label5;
    }
}