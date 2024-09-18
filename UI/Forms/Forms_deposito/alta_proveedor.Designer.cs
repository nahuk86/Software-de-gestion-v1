namespace UI.Forms.Forms_deposito
{
    partial class alta_proveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_alta_proveedor = new System.Windows.Forms.TextBox();
            this.btn_agregar_proveedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo proveedor";
            // 
            // textBox_alta_proveedor
            // 
            this.textBox_alta_proveedor.Location = new System.Drawing.Point(195, 53);
            this.textBox_alta_proveedor.Name = "textBox_alta_proveedor";
            this.textBox_alta_proveedor.Size = new System.Drawing.Size(216, 22);
            this.textBox_alta_proveedor.TabIndex = 1;
            // 
            // btn_agregar_proveedor
            // 
            this.btn_agregar_proveedor.Location = new System.Drawing.Point(270, 100);
            this.btn_agregar_proveedor.Name = "btn_agregar_proveedor";
            this.btn_agregar_proveedor.Size = new System.Drawing.Size(141, 51);
            this.btn_agregar_proveedor.TabIndex = 2;
            this.btn_agregar_proveedor.Text = "Agregar nuevo proveedor";
            this.btn_agregar_proveedor.UseVisualStyleBackColor = true;
            this.btn_agregar_proveedor.Click += new System.EventHandler(this.btn_agregar_proveedor_Click);
            // 
            // alta_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.btn_agregar_proveedor);
            this.Controls.Add(this.textBox_alta_proveedor);
            this.Controls.Add(this.label1);
            this.Name = "alta_proveedor";
            this.Text = "alta_proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_alta_proveedor;
        private System.Windows.Forms.Button btn_agregar_proveedor;
    }
}