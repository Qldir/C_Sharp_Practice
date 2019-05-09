using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter04_0509.Models
{
    class UtilModel
    {
        public static void SimpleCalcPlus(TextBox leftBox, TextBox rightBox, TextBox resultBox)
        {
            double left = double.Parse(leftBox.Text);
            double right = double.Parse(rightBox.Text);

            double result = left + right;
            resultBox.Text = result + "";
        }




        public static void TypingOnlyNumber(object sender, KeyPressEventArgs e, bool includePoint)
        {
            bool isValildInput = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if (includePoint == true) { if (e.KeyChar == '.') isValildInput = true; }

                if (isValildInput == false) e.Handled = true;
            }

            if (includePoint == true)
            {
                if (e.KeyChar == '.' && (string.IsNullOrEmpty((sender as TextBox).Text.Trim()) || (sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
            }

        }
    }
}
