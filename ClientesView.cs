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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Rows.Add("John", "Doe", "1234567890", "john.doe@example.com", "01/01/1990", "@johnDoe");
            dataGridView1.Rows.Add("Jane", "Doe", "0987654321", "jane.doe@example.com", "02/02/1992", "@janeDoe");
            dataGridView1.Rows.Add("Alice", "Smith", "1112223333", "alice.smith@example.com", "03/03/1993", "@aliceSmith");
            dataGridView1.Rows.Add("Bob", "Johnson", "4445556666", "bob.johnson@example.com", "04/04/1994", "@bobJohnson");
            dataGridView1.Rows.Add("Charlie", "Brown", "7778889999", "charlie.brown@example.com", "05/05/1995", "@charlieBrown");
            dataGridView1.Rows.Add("John", "Doe", "1234567890", "john.doe@example.com", "01/01/1990", "@johnDoe");
            dataGridView1.Rows.Add("Jane", "Doe", "0987654321", "jane.doe@example.com", "02/02/1992", "@janeDoe");
            dataGridView1.Rows.Add("Alice", "Smith", "1112223333", "alice.smith@example.com", "03/03/1993", "@aliceSmith");
            dataGridView1.Rows.Add("Bob", "Johnson", "4445556666", "bob.johnson@example.com", "04/04/1994", "@bobJohnson");
            dataGridView1.Rows.Add("Charlie", "Brown", "7778889999", "charlie.brown@example.com", "05/05/1995", "@charlieBrown");
            dataGridView1.Rows.Add("John", "Doe", "1234567890", "john.doe@example.com", "01/01/1990", "@johnDoe");
            dataGridView1.Rows.Add("Jane", "Doe", "0987654321", "jane.doe@example.com", "02/02/1992", "@janeDoe");
            dataGridView1.Rows.Add("Alice", "Smith", "1112223333", "alice.smith@example.com", "03/03/1993", "@aliceSmith");
            dataGridView1.Rows.Add("Bob", "Johnson", "4445556666", "bob.johnson@example.com", "04/04/1994", "@bobJohnson");
            dataGridView1.Rows.Add("Charlie", "Brown", "7778889999", "charlie.brown@example.com", "05/05/1995", "@charlieBrown");
        }
    }
}
