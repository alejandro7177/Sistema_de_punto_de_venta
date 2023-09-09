using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
    
namespace Proyecto_Taller_AdminShop.Classes
{
    internal class CConexion
    {
        SqlConnection conex = new SqlConnection();

        static string server = "localhost";
        static string db="TallerII_AdminShop";
        static string user="sa";
        static string password="Taller7177";
        static string port="1433";

        string cadenaConexion = "Data Source=" + server + "," + port + ";" + " user id=" + user + ";" + "password=" + password + ";" + "Initial Catalog=" + db;

        public SqlConnection establecer_conexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conecto correctamente a la base de datos");

            }catch (SqlException e)
            {
                MessageBox.Show("Error"+e.Message);
            }
            return conex;
        }
    }
}
