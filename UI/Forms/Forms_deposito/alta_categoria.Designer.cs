namespace UI.Forms.Forms_deposito
{
    partial class alta_categoria
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
            this.textBox_categoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregar_categoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_categoria
            // 
            this.textBox_categoria.Location = new System.Drawing.Point(154, 50);
            this.textBox_categoria.Name = "textBox_categoria";
            this.textBox_categoria.Size = new System.Drawing.Size(224, 22);
            this.textBox_categoria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nueva categoria";
            // 
            // btn_agregar_categoria
            // 
            this.btn_agregar_categoria.Location = new System.Drawing.Point(219, 111);
            this.btn_agregar_categoria.Name = "btn_agregar_categoria";
            this.btn_agregar_categoria.Size = new System.Drawing.Size(159, 38);
            this.btn_agregar_categoria.TabIndex = 2;
            this.btn_agregar_categoria.Text = "Agregar categoria";
            this.btn_agregar_categoria.UseVisualStyleBackColor = true;
            this.btn_agregar_categoria.Click += new System.EventHandler(this.btn_agregar_categoria_Click);
            // 
            // alta_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.btn_agregar_categoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_categoria);
            this.Name = "alta_categoria";
            this.Text = "alta_categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregar_categoria;
    }
}