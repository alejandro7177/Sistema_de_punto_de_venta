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
    public partial class FIngresar : Form
    {
        public FIngresar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            //Pueba de la base de datos
            PanelPrincipal panel = new PanelPrincipal();
            panel.Show();
            PanelAdmin panelAdmin = new PanelAdmin();
            panelAdmin.Show();
            Vendedor.PanelVendedor panelVendedor = new Vendedor.PanelVendedor();
            panelVendedor.Show();
            //this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
