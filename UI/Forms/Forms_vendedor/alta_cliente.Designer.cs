namespace UI.Forms.Forms_vendedor
{
    partial class alta_cliente
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
            this.txt_cliente_nombre = new System.Windows.Forms.TextBox();
            this.txt_cliente_apellido = new System.Windows.Forms.TextBox();
            this.txt_cliente_dni = new System.Windows.Forms.TextBox();
            this.txt_cliente_telefono = new System.Windows.Forms.TextBox();
            this.txt_cliente_direccion = new System.Windows.Forms.TextBox();
            this.txt_cliente_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_cliente_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.btn_alta_cliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cliente_nombre
            // 
            this.txt_cliente_nombre.Location = new System.Drawing.Point(142, 71);
            this.txt_cliente_nombre.Name = "txt_cliente_nombre";
            this.txt_cliente_nombre.Size = new System.Drawing.Size(248, 22);
            this.txt_cliente_nombre.TabIndex = 0;
            // 
            // txt_cliente_apellido
            // 
            this.txt_cliente_apellido.Location = new System.Drawing.Point(142, 117);
            this.txt_cliente_apellido.Name = "txt_cliente_apellido";
            this.txt_cliente_apellido.Size = new System.Drawing.Size(248, 22);
            this.txt_cliente_apellido.TabIndex = 1;
            // 
            // txt_cliente_dni
            // 
            this.txt_cliente_dni.Location = new System.Drawing.Point(142, 169);
            this.txt_cliente_dni.Name = "txt_cliente_dni";
            this.txt_cliente_dni.Size = new System.Drawing.Size(248, 22);
            this.txt_cliente_dni.TabIndex = 2;
            // 
            // txt_cliente_telefono
            // 
            this.txt_cliente_telefono.Location = new System.Drawing.Point(142, 275);
            this.txt_cliente_telefono.Name = "txt_cliente_telefono";
            this.txt_cliente_telefono.Size = new System.Drawing.Size(248, 22);
            this.txt_cliente_telefono.TabIndex = 3;
            // 
            // txt_cliente_direccion
            // 
            this.txt_cliente_direccion.Location = new System.Drawing.Point(142, 328);
            this.txt_cliente_direccion.Name = "txt_cliente_direccion";
            this.txt_cliente_direccion.Size = new System.Drawing.Size(248, 22);
            this.txt_cliente_direccion.TabIndex = 4;
            // 
            // txt_cliente_email
            // 
            this.txt_cliente_email.Location = new System.Drawing.Point(142, 388);
            this.txt_cliente_email.Name = "txt_cliente_email";
            this.txt_cliente_email.Size = new System.Drawing.Size(248, 22);
            this.txt_cliente_email.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker_cliente_nacimiento
            // 
            this.dateTimePicker_cliente_nacimiento.Location = new System.Drawing.Point(221, 219);
            this.dateTimePicker_cliente_nacimiento.Name = "dateTimePicker_cliente_nacimiento";
            this.dateTimePicker_cliente_nacimiento.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_cliente_nacimiento.TabIndex = 13;
            // 
            // btn_alta_cliente
            // 
            this.btn_alta_cliente.Location = new System.Drawing.Point(266, 465);
            this.btn_alta_cliente.Name = "btn_alta_cliente";
            this.btn_alta_cliente.Size = new System.Drawing.Size(124, 23);
            this.btn_alta_cliente.TabIndex = 14;
            this.btn_alta_cliente.Text = "Crear Cliente";
            this.btn_alta_cliente.UseVisualStyleBackColor = true;
            this.btn_alta_cliente.Click += new System.EventHandler(this.btn_alta_cliente_Click);
            // 
            // alta_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 601);
            this.Controls.Add(this.btn_alta_cliente);
            this.Controls.Add(this.dateTimePicker_cliente_nacimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cliente_email);
            this.Controls.Add(this.txt_cliente_direccion);
            this.Controls.Add(this.txt_cliente_telefono);
            this.Controls.Add(this.txt_cliente_dni);
            this.Controls.Add(this.txt_cliente_apellido);
            this.Controls.Add(this.txt_cliente_nombre);
            this.Name = "alta_cliente";
            this.Text = "alta_cliente";
            this.Load += new System.EventHandler(this.alta_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cliente_nombre;
        private System.Windows.Forms.TextBox txt_cliente_apellido;
        private System.Windows.Forms.TextBox txt_cliente_dni;
        private System.Windows.Forms.TextBox txt_cliente_telefono;
        private System.Windows.Forms.TextBox txt_cliente_direccion;
        private System.Windows.Forms.TextBox txt_cliente_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_cliente_nacimiento;
        private System.Windows.Forms.Button btn_alta_cliente;
    }
}