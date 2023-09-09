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
    public partial class PruebaDB : Form
    {
        public PruebaDB()
        {
            InitializeComponent();
        }

        private void botonDB_Click(object sender, EventArgs e)
        {
            Classes.CConexion objetoConexion = new Classes.CConexion();
            objetoConexion.establecer_conexion();
        }
    }
}
