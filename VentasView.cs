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
    public partial class VentasView : UserControl
    {
        public VentasView()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfigureDataGridView()
        {
            DGVentas.Rows.Add("Coca Cola", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Doritos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Pañuelos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Coca Cola", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Doritos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Pañuelos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Coca Cola", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Doritos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Pañuelos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Coca Cola", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Doritos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Pañuelos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Coca Cola", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Doritos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Pañuelos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Coca Cola", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Doritos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Pañuelos", "20", "$750.00", "$2250.00");
        }

        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
