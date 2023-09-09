namespace Proyecto_Taller_AdminShop
{
    partial class PruebaDB
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
            this.botonDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonDB
            // 
            this.botonDB.Location = new System.Drawing.Point(141, 29);
            this.botonDB.Name = "botonDB";
            this.botonDB.Size = new System.Drawing.Size(178, 111);
            this.botonDB.TabIndex = 0;
            this.botonDB.Text = "ConectarDB";
            this.botonDB.UseVisualStyleBackColor = true;
            this.botonDB.Click += new System.EventHandler(this.botonDB_Click);
            // 
            // PruebaDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 180);
            this.Controls.Add(this.botonDB);
            this.Name = "PruebaDB";
            this.Text = "PruebaDB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonDB;
    }
}