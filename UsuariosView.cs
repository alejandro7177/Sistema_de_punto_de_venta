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
    public partial class UsuariosView : UserControl
    {
        public UsuariosView()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void DGSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarUsuario editUserForm = new EditarUsuario();
            editUserForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            DG_Users.Rows.Add("Juan", "Perez", "admin@gmail", "4353453", "Juan@Perez");
            DG_Users.Rows.Add("Juan", "Perez", "admin@gmail", "4353453", "Juan@Perez");
            DG_Users.Rows.Add("Juan", "Perez", "admin@gmail", "4353453", "Juan@Perez");
            DG_Users.Rows.Add("Juan", "Perez", "admin@gmail", "4353453", "Juan@Perez");
            DG_Users.Rows.Add("Juan", "Perez", "admin@gmail", "4353453", "Juan@Perez");
            DG_Users.Rows.Add("Juan", "Perez", "admin@gmail", "4353453", "Juan@Perez");
            DG_Users.Rows.Add("Juan", "Perez", "admin@gmail", "4353453", "Juan@Perez");
            DG_Users.Rows.Add("Juan", "Perez", "admin@gmail", "4353453", "Juan@Perez");

        }

        private void DG_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
