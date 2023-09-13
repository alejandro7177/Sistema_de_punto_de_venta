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
            // Crear columnas
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Precio", "Precio");

            // Añadir productos estáticos
            dataGridView1.Rows.Add("Producto 1", "10", "20.5");
            dataGridView1.Rows.Add("Producto 2", "5", "15.0");
            dataGridView1.Rows.Add("Producto 3", "8", "22.5");
            dataGridView1.Rows.Add("Producto 4", "6", "19.0");
            dataGridView1.Rows.Add("Producto 5", "11", "21.0");

            // Cambiar el estilo de la cabecera y las celdas
            dataGridView1.EnableHeadersVisualStyles = false; // Para que los cambios en la cabecera tengan efecto
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Quicksand", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.Font = new Font("Quicksand", 10, FontStyle.Bold);
        }


    }
}
