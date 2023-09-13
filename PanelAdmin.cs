using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_AdminShop
{
    public partial class PanelAdmin : Form
    {
        public PanelAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            LoadVentasView();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Width = this.ClientSize.Width;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Height = this.ClientSize.Height;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.Height = this.ClientSize.Height;
            panel3.Width = this.ClientSize.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            ClientesView clientesView = new ClientesView();
            panel3.Controls.Add(clientesView);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RU_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            LoadVentasView();
        }

        private void LoadVentasView()
        {
            VentasView ventasView = new VentasView();
            panel3.Controls.Add(ventasView);
        }
    }
}
