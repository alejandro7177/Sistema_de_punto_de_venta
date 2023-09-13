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
    public partial class ClientesView : UserControl
    {
        public ClientesView()
        {
            InitializeComponent();
            InitializeDataGridView();
            this.Resize += new System.EventHandler(this.FormResize);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Width = (int)(this.ClientSize.Width * 0.8);
            dataGridView1.Left = (this.ClientSize.Width - dataGridView1.Width) / 2;

            // Configuración de columnas
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns.Add("Telefono", "Teléfono");
            dataGridView1.Columns.Add("Correo", "Correo");
            dataGridView1.Columns.Add("FechaNacimiento", "Fecha de Nacimiento");
            dataGridView1.Columns.Add("Instagram", "Instagram");

            // Hacer que las celdas ocupen todo el ancho disponible
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Estilo de las cabeceras
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Cambiar la fuente a Quicksand si está disponible
            try
            {
                Font quicksandFont = new Font("Quicksand", 12, FontStyle.Bold);
                dataGridView1.Font = quicksandFont;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = quicksandFont;
            }
            catch (Exception)
            {
                // La fuente Quicksand no está disponible, continuar con la fuente por defecto
            }

            // Agregar 5 clientes de manera estática
            dataGridView1.Rows.Add("John", "Doe", "1234567890", "john.doe@example.com", "01/01/1990", "@johnDoe");
            dataGridView1.Rows.Add("Jane", "Doe", "0987654321", "jane.doe@example.com", "02/02/1992", "@janeDoe");
            dataGridView1.Rows.Add("Alice", "Smith", "1112223333", "alice.smith@example.com", "03/03/1993", "@aliceSmith");
            dataGridView1.Rows.Add("Bob", "Johnson", "4445556666", "bob.johnson@example.com", "04/04/1994", "@bobJohnson");
            dataGridView1.Rows.Add("Charlie", "Brown", "7778889999", "charlie.brown@example.com", "05/05/1995", "@charlieBrown");
        }

        private void FormResize(object sender, EventArgs e)
        {
            dataGridView1.Width = (int)(this.ClientSize.Width * 0.8);
            dataGridView1.Left = (this.ClientSize.Width - dataGridView1.Width) / 2;  // Centrarlo si lo deseas
        }
    }
}
