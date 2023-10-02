using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_AdminShop
{
    public partial class ProductosView : UserControl
    {
        public ProductosView()
        {
            InitializeComponent();
            initDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void initDataGrid()
        {
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");

            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Fanta", "100", "120", "35", "Fanta Naranja de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
            DG_Products.Rows.Add("1", "Coca Cola", "500", "600", "65", "Coca Cola de vidrio de 2lts botella descartable");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BIngresar_Click(object sender, EventArgs e)
        {
            if (DG_Products.SelectedRows.Count == 1)
            {
                DataGridViewRow SRow = DG_Products.SelectedRows[0];
                Enombre.Text = SRow.Cells["Nombre"].Value.ToString();
                EPCosto.Text = SRow.Cells["PrecioCosto"].Value.ToString();
                EPVenta.Text = SRow.Cells["pVenta"].Value.ToString();
                EStock.Text = SRow.Cells["stock"].Value.ToString();
                EDescripcion.Text = SRow.Cells["descripcion"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarProductoForm agregarProductoForm = new AgregarProductoForm();
            agregarProductoForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DG_Products.SelectedRows.Count == 1)
            {
                DataGridViewRow SRow = DG_Products.SelectedRows[0];
                SRow.Cells["Nombre"].Value = Enombre.Text;
                SRow.Cells["PrecioCosto"].Value = EPCosto.Text ;
                SRow.Cells["pVenta"].Value = EPVenta.Text;
                SRow.Cells["stock"].Value = EStock.Text;
                SRow.Cells["descripcion"].Value = EDescripcion.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enombre.Clear();
            EPCosto.Clear();
            EPVenta.Clear();
            EStock.Clear();
            EDescripcion.Clear();
        }
    }
}
