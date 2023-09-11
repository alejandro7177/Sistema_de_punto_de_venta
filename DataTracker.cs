using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_AdminShop
{
    public partial class DataTracker : UserControl
    {
        public DataTracker()
        {
            InitializeComponent();
        }

        private void DataTracker_Load(object sender, EventArgs e)
        {
            this.Width = this.ClientSize.Width;
            this.Height = this.ClientSize.Height;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Size = new Size(150, 50);
            label1.Text = "Línea 1\nLínea 2";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
