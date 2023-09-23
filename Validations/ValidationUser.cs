using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller_AdminShop
{
    internal class ValidationUser
    {
        public static bool ValidationLengh(TextBox tB)
        {
            return tB.Text.Length >= 3;
        }

        public static bool ValidationEmail(TextBox tB)
        {
            string text = tB.Text;
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(patronCorreo);

            return tB.Text.Length >= 7 && regex.IsMatch(text);
        }
    }
}
