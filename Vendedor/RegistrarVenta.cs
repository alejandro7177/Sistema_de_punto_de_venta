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
            if (DGSale.Columns[e.ColumnIndex].Name == "colEliminar")
            {
                DGSale.Rows.RemoveAt(e.RowIndex); // Elimina la fila
            }
        }

        private void InitializeDataGridView()
        {
            DGSale.Width = (int)(this.ClientSize.Width * 0.52);

            // Alinea el DataGridView a la derecha del formulario
            DGSale.Left = this.ClientSize.Width - DGSale.Width;

            // Configuración de columnas
            DGSale.Columns.Add("Nombre", "Nombre");
            DGSale.Columns.Add("Cantidad", "Cantidad");
            DGSale.Columns.Add("Precio", "Precio");
            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.Name = "colEliminar";
            colEliminar.HeaderText = "Eliminar";
            colEliminar.Text = "Eliminar";  // Esta es la línea que faltaba
            colEliminar.UseColumnTextForButtonValue = true; // Esto hace que todas las filas muestren el texto "Eliminar"
            DGSale.Columns.Add(colEliminar);

            // Hacer que las celdas ocupen todo el ancho disponible
            foreach (DataGridViewColumn column in DGSale.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Estilo de las cabeceras
            DGSale.EnableHeadersVisualStyles = false;
            DGSale.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#071526");
            DGSale.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Cambiar la fuente a Quicksand si está disponible
            try
            {
                Font quicksandFont = new Font("Quicksand", 12, FontStyle.Bold);
                DGSale.Font = quicksandFont;
                DGSale.ColumnHeadersDefaultCellStyle.Font = quicksandFont;
            }
            catch (Exception)
            {
                // La fuente Quicksand no está disponible, continuar con la fuente por defecto
            }

            // Agregar 5 clientes de manera estática
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
    }
}
