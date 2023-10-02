using Proyecto_Taller_AdminShop.Classes.Models;
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
        //golosinas

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem == null)
                return;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Golosinas":
                    comboBox2.Items.Add("Golosina 1");
                    comboBox2.Items.Add("Golosina 2");
                    break;

                case "Bebidas":
                    comboBox2.Items.Add("Bebida 1");
                    comboBox2.Items.Add("Bebida 2");
                    break;

                case "Snacks":
                    comboBox2.Items.Add("Snacks 1");
                    comboBox2.Items.Add("Snacks 2");
                    break;

                case "Cigarrillos":
                    comboBox2.Items.Add("Cigarrillos 1");
                    comboBox2.Items.Add("Cigarrillos 2");
                    break;

                case "Helados y Postres":
                    comboBox2.Items.Add("Helados y Postres 1");
                    comboBox2.Items.Add("Helados y Postres 2");
                    break;

                case "Panadería":
                    comboBox2.Items.Add("Panadería 1");
                    comboBox2.Items.Add("Panadería 2");
                    break;

                case "Primera Necesidad":
                    comboBox2.Items.Add("Primera Necesidad 1");
                    comboBox2.Items.Add("Primera Necesidad 2");
                    break;

                default:
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para manejar la selección de items en comboBox2 si es necesario.
        }

    }
}
