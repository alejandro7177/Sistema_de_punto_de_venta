using Proyecto_Taller_AdminShop.Classes.Models;
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
    public partial class RegistrarUsuarioForm : UserControl
    {
        public RegistrarUsuarioForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BRUser_Click(object sender, EventArgs e)
        {
            string sPass = Classes.Encrypt.GetSHA256(TBContraseña.Text.Trim());
            using (Classes.Models.TallerII_AdminShopEntities db = new Classes.Models.TallerII_AdminShopEntities())
            {
                Usuario user = new Usuario();
                user.nombre = TBNombre.Text.Trim();
                user.contraseña = sPass;
                if (CBRol.SelectedItem.ToString() == "Usuario")
                {
                    user.tipo_usuario = 2;
                }
                else{
                    user.tipo_usuario = 3;
                }
                int dniNumero;
                user.correo = TBEmail.Text.Trim();
                if (int.TryParse(TBDni.Text, out dniNumero))
                {
                    user.dni = dniNumero;
                }
                user.apellido = TBApellido.Text.Trim();
                user.instagram  = TBInstagram.Text.Trim();
                int telefonoInt;
                if (int.TryParse(TBTelefono.Text, out telefonoInt))
                {
                    user.telefono = telefonoInt;
                }

                db.Usuario.Add(user);
                db.SaveChanges();
                MessageBox.Show("Usuario Creado Correctamente :) ");

                TBNombre.Clear();
                TBApellido.Clear();
                TBContraseña.Clear();
                CBRol.SelectedIndex = 1;
                TBEmail.Clear();
                TBDni.Clear();
                TBInstagram.Clear();
                TBTelefono.Clear();
            }

        }
    }
}
