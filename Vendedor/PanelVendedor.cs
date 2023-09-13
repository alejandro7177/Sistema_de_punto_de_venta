using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_AdminShop.Vendedor
{
    public partial class PanelVendedor : Form
    {
        public PanelVendedor()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            RegistrarCliente registrarCliente = new RegistrarCliente();
            panelPrincipal.Controls.Add(registrarCliente);
        }

        private void IB_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            RegistrarVenta registrarVenta = new RegistrarVenta();
            panelPrincipal.Controls.Add(registrarVenta);
        }

        private void RU_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            ConsultarVenta consultarVenta = new ConsultarVenta();
            panelPrincipal.Controls.Add(consultarVenta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            RegistrarCliente registrarCliente = new RegistrarCliente();
            panelPrincipal.Controls.Add(registrarCliente);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Height = this.ClientSize.Height;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Width = this.ClientSize.Width;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelVendedor_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            panel2.Width = this.ClientSize.Width;
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
