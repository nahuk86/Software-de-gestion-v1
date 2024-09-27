namespace UI.Forms.Forms_gerente
{
    partial class frmPatenteFamilia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarPatente = new System.Windows.Forms.Button();
            this.cboPatentes = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePatente = new System.Windows.Forms.TextBox();
            this.btnGuardarPatente = new System.Windows.Forms.Button();
            this.cboPermisos = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarFamilia = new System.Windows.Forms.Button();
            this.btnConfigFamilia = new System.Windows.Forms.Button();
            this.cboFamilias = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreFamilia = new System.Windows.Forms.TextBox();
            this.btnGuardarNombreFamilia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuardarFamilia = new System.Windows.Forms.Button();
            this.treeConfigurarFamilia = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregarPatente);
            this.groupBox1.Controls.Add(this.cboPatentes);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patentes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Todas las patentes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgregarPatente
            // 
            this.btnAgregarPatente.Location = new System.Drawing.Point(26, 88);
            this.btnAgregarPatente.Name = "btnAgregarPatente";
            this.btnAgregarPatente.Size = new System.Drawing.Size(118, 32);
            this.btnAgregarPatente.TabIndex = 2;
            this.btnAgregarPatente.Text = "Agregar >>";
            this.btnAgregarPatente.UseVisualStyleBackColor = true;
            this.btnAgregarPatente.Click += new System.EventHandler(this.btnAgregarPatente_Click);
            // 
            // cboPatentes
            // 
            this.cboPatentes.FormattingEnabled = true;
            this.cboPatentes.Location = new System.Drawing.Point(26, 58);
            this.cboPatentes.Name = "cboPatentes";
            this.cboPatentes.Size = new System.Drawing.Size(315, 24);
            this.cboPatentes.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtNombrePatente);
            this.groupBox4.Controls.Add(this.btnGuardarPatente);
            this.groupBox4.Controls.Add(this.cboPermisos);
            this.groupBox4.Location = new System.Drawing.Point(6, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 179);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nueva Patente";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Permiso";
            // 
            // txtNombrePatente
            // 
            this.txtNombrePatente.Location = new System.Drawing.Point(20, 96);
            this.txtNombrePatente.Name = "txtNombrePatente";
            this.txtNombrePatente.Size = new System.Drawing.Size(291, 22);
            this.txtNombrePatente.TabIndex = 3;
            // 
            // btnGuardarPatente
            // 
            this.btnGuardarPatente.Location = new System.Drawing.Point(20, 124);
            this.btnGuardarPatente.Name = "btnGuardarPatente";
            this.btnGuardarPatente.Size = new System.Drawing.Size(118, 32);
            this.btnGuardarPatente.TabIndex = 6;
            this.btnGuardarPatente.Text = "Guardar";
            this.btnGuardarPatente.UseVisualStyleBackColor = true;
            this.btnGuardarPatente.Click += new System.EventHandler(this.btnGuardarPatente_Click);
            // 
            // cboPermisos
            // 
            this.cboPermisos.FormattingEnabled = true;
            this.cboPermisos.Location = new System.Drawing.Point(20, 43);
            this.cboPermisos.Name = "cboPermisos";
            this.cboPermisos.Size = new System.Drawing.Size(291, 24);
            this.cboPermisos.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAgregarFamilia);
            this.groupBox2.Controls.Add(this.btnConfigFamilia);
            this.groupBox2.Controls.Add(this.cboFamilias);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(403, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Familias";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Todas las familias";
            // 
            // btnAgregarFamilia
            // 
            this.btnAgregarFamilia.Location = new System.Drawing.Point(202, 88);
            this.btnAgregarFamilia.Name = "btnAgregarFamilia";
            this.btnAgregarFamilia.Size = new System.Drawing.Size(118, 32);
            this.btnAgregarFamilia.TabIndex = 4;
            this.btnAgregarFamilia.Text = "Agregar >>";
            this.btnAgregarFamilia.UseVisualStyleBackColor = true;
            this.btnAgregarFamilia.Click += new System.EventHandler(this.btnAgregarFamilia_Click);
            // 
            // btnConfigFamilia
            // 
            this.btnConfigFamilia.Location = new System.Drawing.Point(19, 88);
            this.btnConfigFamilia.Name = "btnConfigFamilia";
            this.btnConfigFamilia.Size = new System.Drawing.Size(118, 32);
            this.btnConfigFamilia.TabIndex = 3;
            this.btnConfigFamilia.Text = "Configurar";
            this.btnConfigFamilia.UseVisualStyleBackColor = true;
            this.btnConfigFamilia.Click += new System.EventHandler(this.btnConfigFamilia_Click);
            // 
            // cboFamilias
            // 
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(19, 58);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(301, 24);
            this.cboFamilias.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtNombreFamilia);
            this.groupBox5.Controls.Add(this.btnGuardarNombreFamilia);
            this.groupBox5.Location = new System.Drawing.Point(30, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(302, 173);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nueva Familia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre";
            // 
            // txtNombreFamilia
            // 
            this.txtNombreFamilia.Location = new System.Drawing.Point(6, 58);
            this.txtNombreFamilia.Name = "txtNombreFamilia";
            this.txtNombreFamilia.Size = new System.Drawing.Size(273, 22);
            this.txtNombreFamilia.TabIndex = 7;
            // 
            // btnGuardarNombreFamilia
            // 
            this.btnGuardarNombreFamilia.Location = new System.Drawing.Point(6, 94);
            this.btnGuardarNombreFamilia.Name = "btnGuardarNombreFamilia";
            this.btnGuardarNombreFamilia.Size = new System.Drawing.Size(118, 32);
            this.btnGuardarNombreFamilia.TabIndex = 5;
            this.btnGuardarNombreFamilia.Text = "Guardar";
            this.btnGuardarNombreFamilia.UseVisualStyleBackColor = true;
            this.btnGuardarNombreFamilia.Click += new System.EventHandler(this.btnGuardarNombreFamilia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGuardarFamilia);
            this.groupBox3.Controls.Add(this.treeConfigurarFamilia);
            this.groupBox3.Location = new System.Drawing.Point(768, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 400);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnGuardarFamilia
            // 
            this.btnGuardarFamilia.Location = new System.Drawing.Point(6, 350);
            this.btnGuardarFamilia.Name = "btnGuardarFamilia";
            this.btnGuardarFamilia.Size = new System.Drawing.Size(118, 32);
            this.btnGuardarFamilia.TabIndex = 9;
            this.btnGuardarFamilia.Text = "Guardar familia";
            this.btnGuardarFamilia.UseVisualStyleBackColor = true;
            this.btnGuardarFamilia.Click += new System.EventHandler(this.btnGuardarFamilia_Click);
            // 
            // treeConfigurarFamilia
            // 
            this.treeConfigurarFamilia.Location = new System.Drawing.Point(6, 36);
            this.treeConfigurarFamilia.Name = "treeConfigurarFamilia";
            this.treeConfigurarFamilia.Size = new System.Drawing.Size(333, 297);
            this.treeConfigurarFamilia.TabIndex = 0;
            this.treeConfigurarFamilia.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeConfigurarFamilia_AfterSelect);
            // 
            // frmPatenteFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPatenteFamilia";
            this.Text = "frmPatenteFamilia";
            this.Load += new System.EventHandler(this.frmPatenteFamilia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarPatente;
        private System.Windows.Forms.ComboBox cboPatentes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePatente;
        private System.Windows.Forms.Button btnGuardarPatente;
        private System.Windows.Forms.ComboBox cboPermisos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarFamilia;
        private System.Windows.Forms.Button btnConfigFamilia;
        private System.Windows.Forms.ComboBox cboFamilias;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreFamilia;
        private System.Windows.Forms.Button btnGuardarNombreFamilia;
        private System.Windows.Forms.TreeView treeConfigurarFamilia;
        private System.Windows.Forms.Button btnGuardarFamilia;
    }
}