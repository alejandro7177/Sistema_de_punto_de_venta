﻿namespace Proyecto_Taller_AdminShop
{
    partial class RegistrarUsuarioForm
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.BRUser = new System.Windows.Forms.Button();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBInstagram = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBNombre
            // 
            this.TBNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBNombre.Location = new System.Drawing.Point(128, 91);
            this.TBNombre.Multiline = true;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(240, 20);
            this.TBNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // TBApellido
            // 
            this.TBApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBApellido.Location = new System.Drawing.Point(128, 145);
            this.TBApellido.Multiline = true;
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(240, 20);
            this.TBApellido.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // TBEmail
            // 
            this.TBEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBEmail.Location = new System.Drawing.Point(129, 203);
            this.TBEmail.Multiline = true;
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(240, 20);
            this.TBEmail.TabIndex = 6;
            // 
            // TBContraseña
            // 
            this.TBContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBContraseña.Location = new System.Drawing.Point(129, 267);
            this.TBContraseña.Multiline = true;
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.PasswordChar = '*';
            this.TBContraseña.Size = new System.Drawing.Size(240, 20);
            this.TBContraseña.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña";
            // 
            // TBTelefono
            // 
            this.TBTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTelefono.Location = new System.Drawing.Point(129, 327);
            this.TBTelefono.Multiline = true;
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(240, 20);
            this.TBTelefono.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(124, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rol";
            // 
            // CBRol
            // 
            this.CBRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.CBRol.Location = new System.Drawing.Point(129, 508);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(240, 23);
            this.CBRol.TabIndex = 13;
            this.CBRol.Text = "Seleccione un Rol";
            // 
            // BRUser
            // 
            this.BRUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BRUser.FlatAppearance.BorderSize = 0;
            this.BRUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRUser.ForeColor = System.Drawing.Color.White;
            this.BRUser.Location = new System.Drawing.Point(129, 559);
            this.BRUser.Name = "BRUser";
            this.BRUser.Size = new System.Drawing.Size(239, 34);
            this.BRUser.TabIndex = 14;
            this.BRUser.Text = "Registrar Usuario";
            this.BRUser.UseVisualStyleBackColor = false;
            this.BRUser.Click += new System.EventHandler(this.BRUser_Click);
            // 
            // TBDni
            // 
            this.TBDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBDni.Location = new System.Drawing.Point(130, 393);
            this.TBDni.Multiline = true;
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(240, 20);
            this.TBDni.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(125, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "D.N.I.";
            // 
            // TBInstagram
            // 
            this.TBInstagram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBInstagram.Location = new System.Drawing.Point(131, 457);
            this.TBInstagram.Multiline = true;
            this.TBInstagram.Name = "TBInstagram";
            this.TBInstagram.Size = new System.Drawing.Size(240, 20);
            this.TBInstagram.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(126, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Instagram";
            // 
            // RegistrarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TBInstagram);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BRUser);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBContraseña);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarUsuarioForm";
            this.Size = new System.Drawing.Size(669, 697);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Button BRUser;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBInstagram;
        private System.Windows.Forms.Label label9;
    }
}
