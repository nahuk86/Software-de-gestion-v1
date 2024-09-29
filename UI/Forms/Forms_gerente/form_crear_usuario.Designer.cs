namespace UI.Forms.Forms_gerente
{


    partial class form_crear_usuario
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
            this.input_email = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.input_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.input_apellido = new System.Windows.Forms.TextBox();
            this.input_dni = new System.Windows.Forms.TextBox();
            this.btn_crear_usuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_email
            // 
            this.input_email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.input_email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.input_email.Location = new System.Drawing.Point(155, 43);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(252, 22);
            this.input_email.TabIndex = 0;
            this.input_email.TextChanged += new System.EventHandler(this.input_email_TextChanged);
            // 
            // input_password
            // 
            this.input_password.Location = new System.Drawing.Point(189, 86);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(218, 22);
            this.input_password.TabIndex = 1;
            // 
            // input_nombre
            // 
            this.input_nombre.Location = new System.Drawing.Point(189, 129);
            this.input_nombre.Name = "input_nombre";
            this.input_nombre.Size = new System.Drawing.Size(218, 22);
            this.input_nombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "dni";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "nombre";
            // 
            // input_apellido
            // 
            this.input_apellido.Location = new System.Drawing.Point(189, 172);
            this.input_apellido.Name = "input_apellido";
            this.input_apellido.Size = new System.Drawing.Size(218, 22);
            this.input_apellido.TabIndex = 10;
            // 
            // input_dni
            // 
            this.input_dni.Location = new System.Drawing.Point(189, 216);
            this.input_dni.Name = "input_dni";
            this.input_dni.Size = new System.Drawing.Size(218, 22);
            this.input_dni.TabIndex = 11;
            // 
            // btn_crear_usuario
            // 
            this.btn_crear_usuario.Location = new System.Drawing.Point(268, 286);
            this.btn_crear_usuario.Name = "btn_crear_usuario";
            this.btn_crear_usuario.Size = new System.Drawing.Size(139, 23);
            this.btn_crear_usuario.TabIndex = 13;
            this.btn_crear_usuario.Text = "crear usuario";
            this.btn_crear_usuario.UseVisualStyleBackColor = true;
            this.btn_crear_usuario.Click += new System.EventHandler(this.btn_crear_usuario_Click);
            // 
            // form_crear_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.btn_crear_usuario);
            this.Controls.Add(this.input_dni);
            this.Controls.Add(this.input_apellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_nombre);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_email);
            this.Name = "form_crear_usuario";
            this.Text = "form_crear_usuario";
            this.Load += new System.EventHandler(this.form_crear_usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.TextBox input_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input_apellido;
        private System.Windows.Forms.TextBox input_dni;
        private System.Windows.Forms.Button btn_crear_usuario;

    }
}