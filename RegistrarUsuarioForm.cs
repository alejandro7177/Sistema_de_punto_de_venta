using Proyecto_Taller_AdminShop.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            bool valid = ValidationUser.ValidationEmail(TBEmail)
                && ValidationUser.ValidationLengh(TBNombre)
                && ValidationUser.ValidationLengh(TBApellido)
                && ValidationUser.ValidationLengh(TBTelefono)
                && ValidationUser.ValidationLengh(TBContraseña)
                && ValidationUser.ValidationLengh(TBDni)
                && ValidationUser.ValidationLengh(TBInstagram)
                && CBRol.SelectedIndex != -1;

            if (valid)
            {
                string sPass = Classes.Encrypt.GetSHA256(TBContraseña.Text.Trim());
                using (Classes.Models.TallerII_AdminShopEntities db = new Classes.Models.TallerII_AdminShopEntities())
                {
                    Usuario user = new Usuario();
                    if (CBRol.SelectedItem.ToString() == "Vendedor")
                    {
                        user.tipo_usuario = 2;
                    }
                    else if(CBRol.SelectedItem.ToString() == "Administrador")
                    {
                        user.tipo_usuario = 3;
                    }
                    user.nombre = TBNombre.Text.Trim();
                    user.contraseña = sPass;
                    user.correo = TBEmail.Text.Trim();
                    user.dni = long.Parse(TBDni.Text);
                    user.apellido = TBApellido.Text.Trim();
                    user.instagram = TBInstagram.Text.Trim();
                    user.telefono = long.Parse(TBTelefono.Text);
                    
                    db.Usuario.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Usuario Creado Correctamente!","Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TBNombre.Clear();
                    TBApellido.Clear();
                    TBContraseña.Clear();
                    CBRol.SelectedIndex = -1;
                    TBEmail.Clear();
                    TBDni.Clear();
                    TBInstagram.Clear();
                    TBTelefono.Clear();
                }
            }
            else if (!valid)
            {
                MessageBox.Show("Complete todos los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBNombre))
            {
                TBNombre.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBNombre.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBNombreKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es una letra o una tecla de control (como Retroceso)
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es una letra o una tecla de control (como Retroceso)
            }
        }

        private void TBEmail_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationEmail(TBEmail))
            {
                // El correo es válido, no hagas nada
                TBEmail.ForeColor = System.Drawing.Color.Black; // Restaurar el color del texto
            }
            else
            {
                // El correo no es válido, cambia el color del texto o muestra un mensaje de error
                TBEmail.ForeColor = System.Drawing.Color.Red; // Cambia el color del texto a rojo
            }
        }

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es un número o una tecla de control (como Retroceso)
            }
        }

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es un número o una tecla de control (como Retroceso)
            }
        }

        private void TBApellido_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBApellido))
            {
                TBApellido.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBApellido.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBContraseña_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBContraseña))
            {
                TBContraseña.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBContraseña.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBTelefono_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBTelefono))
            {
                TBTelefono.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBTelefono.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBDni_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBDni))
            {
                TBDni.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBDni.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void TBInstagram_TextChanged(object sender, EventArgs e)
        {
            if (ValidationUser.ValidationLengh(TBInstagram))
            {
                TBInstagram.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                TBInstagram.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}

