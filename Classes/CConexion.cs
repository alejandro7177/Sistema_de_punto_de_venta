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

        static string server;
        static string db;
        static string user;
        static string password;
        static string port;

        string cadenaConexion = "Data Source=" + server + "," + port + ";" + " user id=" + user + ";" + "password=" + password + ";" + "Initial Catalog=" + db + ";" + "Persist Segurity Info=true";

        public SqlConnection establecer_conexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                MessageBox.Show("Se conecto correctamente a la base de datos");

            }catch (SqlException ex)
            {
                MessageBox.Show("No se logro conectar a la base de datos" + ex.ToString());
            }
            return conex;
        }
    }
}
