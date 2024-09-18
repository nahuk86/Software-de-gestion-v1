namespace UI.Forms.Forms_deposito
{
    partial class gestion_marca
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_agregar_marca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btn_agregar_marca
            // 
            this.btn_agregar_marca.Location = new System.Drawing.Point(173, 83);
            this.btn_agregar_marca.Name = "btn_agregar_marca";
            this.btn_agregar_marca.Size = new System.Drawing.Size(120, 34);
            this.btn_agregar_marca.TabIndex = 1;
            this.btn_agregar_marca.Text = "Agregar Marca";
            this.btn_agregar_marca.UseVisualStyleBackColor = true;
            this.btn_agregar_marca.Click += new System.EventHandler(this.btn_agregar_marca_Click);
            // 
            // gestion_marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.btn_agregar_marca);
            this.Controls.Add(this.textBox1);
            this.Name = "gestion_marca";
            this.Text = "gestion_marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_agregar_marca;
    }
}