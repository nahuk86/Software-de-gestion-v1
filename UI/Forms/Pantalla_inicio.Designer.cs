namespace UI
{
    partial class Pantalla_inicio
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
            this.button_access = new System.Windows.Forms.Button();
            this.input_txt_username = new System.Windows.Forms.TextBox();
            this.input_txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_access
            // 
            this.button_access.Location = new System.Drawing.Point(322, 206);
            this.button_access.Name = "button_access";
            this.button_access.Size = new System.Drawing.Size(75, 23);
            this.button_access.TabIndex = 0;
            this.button_access.Text = "Iniciar sesion";
            this.button_access.UseVisualStyleBackColor = true;
            this.button_access.Click += new System.EventHandler(this.button_access_Click);
            // 
            // input_txt_username
            // 
            this.input_txt_username.Location = new System.Drawing.Point(272, 112);
            this.input_txt_username.Name = "input_txt_username";
            this.input_txt_username.Size = new System.Drawing.Size(178, 22);
            this.input_txt_username.TabIndex = 1;
            // 
            // input_txt_password
            // 
            this.input_txt_password.Location = new System.Drawing.Point(272, 155);
            this.input_txt_password.Name = "input_txt_password";
            this.input_txt_password.Size = new System.Drawing.Size(178, 22);
            this.input_txt_password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_txt_password);
            this.Controls.Add(this.input_txt_username);
            this.Controls.Add(this.button_access);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_access;
        private System.Windows.Forms.TextBox input_txt_username;
        private System.Windows.Forms.TextBox input_txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

