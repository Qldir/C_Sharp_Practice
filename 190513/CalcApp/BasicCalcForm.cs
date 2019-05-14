using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyPress +=
                new KeyPressEventHandler(GetKeyPress);
        }

        //Key Pressed Event
        private void GetKeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case "+":
                    btnPlus.PerformClick();
                    break;
                case "-":
                    btnMns.PerformClick();
                    break;
                case "*":
                    btnMul.PerformClick();
                    break;
                case "/":
                    btnDiv.PerformClick();
                    break;
                case "=":
                    btnEqual.PerformClick();
                    break;
                case "\b":
                    btnBack.PerformClick();
                    break;
                case ".":
                    btnDot.PerformClick();
                    break;
            }




        }//getKeyPress



        private void NumButton(object sender, EventArgs e)
        {
            //Sender Type Check
            if(sender is Button)
            {
                Button num = sender as Button;
                int numValue;

                switch (num.Name)
                {
                    case "btn1":
                        numValue = 1;
                        break;
                    case "btn2":
                        numValue = 2;
                        break;
                    case "btn3":
                        numValue = 3;
                        break;
                    case "btn4":
                        numValue = 4;
                        break;
                    case "btn5":
                        numValue = 5;
                        break;
                    case "btn6":
                        numValue = 6;
                        break;
                    case "btn7":
                        numValue = 7;
                        break;
                    case "btn8":
                        numValue = 8;
                        break;
                    case "btn9":
                        numValue = 9;
                        break;
                    default:
                        numValue = 0;
                        break;
                }

                calcEngine.NumAppend(numValue);
                UpdateResult();

            }
        }//numButton

 
        // TxtResult Update Function
        private void UpdateResult()
        {

        }


    }
}
