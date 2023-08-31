namespace Proyecto_Taller_AdminShop
{
    partial class FIngresar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIngresar));
            this.BIngresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.correoInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BIngresar
            // 
            this.BIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.BIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIngresar.Font = new System.Drawing.Font("Noto Kufi Arabic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BIngresar.Location = new System.Drawing.Point(145, 243);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(187, 39);
            this.BIngresar.TabIndex = 11;
            this.BIngresar.Text = "Ingresar";
            this.BIngresar.UseVisualStyleBackColor = false;
            this.BIngresar.Click += new System.EventHandler(this.BIngresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Kufi Arabic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Kufi Arabic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Kufi Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buen día!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.inputPassword);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.correoInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BIngresar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(59, 138);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(482, 330);
            this.panel1.TabIndex = 12;
            // 
            // correoInput
            // 
            this.correoInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correoInput.Font = new System.Drawing.Font("Noto Kufi Arabic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoInput.Location = new System.Drawing.Point(30, 120);
            this.correoInput.Name = "correoInput";
            this.correoInput.Size = new System.Drawing.Size(424, 21);
            this.correoInput.TabIndex = 15;
            this.correoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Kufi Arabic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 43);
            this.label4.TabIndex = 12;
            this.label4.Text = "Iniciar Sesión";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(433, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "_______________________________________________________________________";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Noto Kufi Arabic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(56, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 40);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hola!";
            // 
            // inputPassword
            // 
            this.inputPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPassword.Font = new System.Drawing.Font("Noto Kufi Arabic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPassword.Location = new System.Drawing.Point(30, 180);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(424, 21);
            this.inputPassword.TabIndex = 17;
            this.inputPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(434, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "_____________________________________________________________";
            // 
            // FIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(600, 557);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FIngresar";
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BIngresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox correoInput;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label7;
    }
}

