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
    public partial class RegistrarVenta : UserControl
    {
        public RegistrarVenta()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Esto asegura que hayamos hecho clic en una fila y no en el encabezado

            // Si se ha hecho clic en la columna "Eliminar"
            if (DGSale.Columns[e.ColumnIndex].Name == "eliminar")
            {
                DGSale.Rows.RemoveAt(e.RowIndex); // Elimina la fila
            }
        }

        private void InitializeDataGridView()
        {
            DGSale.Rows.Add("Coca Cola", "20", "$750.00", "Eliminar");
            DGSale.Rows.Add("Doritos", "20", "$750.00", "Eliminar");
            DGSale.Rows.Add("Pañuelos", "20", "$750.00", "Eliminar");
            DGSale.Rows.Add("Coca Cola", "20", "$750.00", "Eliminar");
            DGSale.Rows.Add("Doritos", "20", "$750.00", "Eliminar");
            DGSale.Rows.Add("Pañuelos", "20", "$750.00", "Eliminar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
