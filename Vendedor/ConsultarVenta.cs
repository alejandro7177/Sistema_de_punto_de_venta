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
    public partial class ConsultarVenta : UserControl
    {
        public ConsultarVenta()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void DGVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            DGVentas.Width = (int)(this.ClientSize.Width * 0.8);
            DGVentas.Left = (this.ClientSize.Width - DGVentas.Width) / 2;

            // Configuración de columnas
            DGVentas.Columns.Add("Nombre", "Nombre");
            DGVentas.Columns.Add("Cantidad", "Cantidad");
            DGVentas.Columns.Add("Precio", "Precio");
            DGVentas.Columns.Add("Total", "Total");

            // Hacer que las celdas ocupen todo el ancho disponible
            foreach (DataGridViewColumn column in DGVentas.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Estilo de las cabeceras
            DGVentas.EnableHeadersVisualStyles = false;
            DGVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            DGVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Cambiar la fuente a Quicksand si está disponible
            try
            {
                Font quicksandFont = new Font("Quicksand", 12, FontStyle.Bold);
                DGVentas.Font = quicksandFont;
                DGVentas.ColumnHeadersDefaultCellStyle.Font = quicksandFont;
            }
            catch (Exception)
            {
                // La fuente Quicksand no está disponible, continuar con la fuente por defecto
            }

            // Agregar 5 clientes de manera estática
            DGVentas.Rows.Add("Coca Cola", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Doritos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Pañuelos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Coca Cola", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Doritos", "20", "$750.00", "$2250.00");
            DGVentas.Rows.Add("Pañuelos", "20", "$750.00", "$2250.00");
        }
    }
}
