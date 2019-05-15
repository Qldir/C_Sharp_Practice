using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalcApp
{


    internal class CalcEngine
    {
        private static string m_input; //Display Number
        private static string m_operation; //Current operator
        private static string m_sign; //Sign of Number
        public static bool m_decimal; //Decimal status
        public static int m_countDigit; //Count of Digit
        public static bool m_wait;  // 

        //Init CalcEngine
        static CalcEngine()
        {
            m_input = null;
            m_operation = null;
            m_sign = "+";
            m_decimal = false;
            m_wait = false;
        }

        //Reset All Variables
        public static void AllClear()
        {
            m_input = null;
            m_operation = null;
            m_sign = "+";
            m_decimal = false;
            m_countDigit = 0;
        }

        public static void NumAppend(double numValue)
        {
            if ( !((m_input == null) && (numValue == 0)) )
            {
                m_input += "" + numValue;
            }

        }

        public static void NumAppend(string numValue)
        {
            if (!((m_input == null) && (int.Parse(numValue) == 0)))
            {
                m_input += numValue;
            }
        }


        public static void Operation(string operationType)
        {

        }

        public static void OtherOperations(string buttonType)
        {
            //Dot
            if (buttonType.Equals("dot"))
            {
                if (m_decimal == true) return;

                if (m_input == null)
                {
                    m_input = "0.";
                    m_decimal = true;
                }
                else
                {
                    m_input += ".";
                    m_decimal = true;
                }
            }
            //Switch Sign
            if (buttonType.Equals("sign"))
            {
                if(m_input != null)
                {
                    if (m_sign.Equals("+") && !m_input.Equals(""))
                    {
                        m_sign = "-";
                        m_input = m_sign + m_input;
                    }
                    else
                    {
                        if (m_sign.Equals("-"))
                        {
                            m_input = m_input.Remove(0, 1);
                        }
                        m_sign = "+";
                    }
                }
            }
            //BackSpace
            if (buttonType.Equals("back"))
            {
                if(m_input != null && !m_input.Equals(""))
                {
                    //BackSpace at "±0."
                    if (((int)double.Parse(m_input) == 0) && (m_input.Substring(m_input.Length - 1).Equals(".")))
                    {
                        m_input = null;
                        m_decimal = false;
                        m_sign = "+";
                    }
                    else
                    {
                        //BackSpace at 1digit
                        if (m_input.Length <= 1 || (m_input.Length == 2 && m_sign.Equals("-")))
                        {
                            m_input = null;
                            m_decimal = false;
                            m_sign = "+";
                        }
                        //BackSpace when the last digit is "."
                        else if (m_input.Substring(m_input.Length - 1).Equals("."))
                        {
                            m_decimal = false;
                        }
                        else m_input = m_input.Remove(m_input.Length - 1, 1);
                    }
                }
            }
        }//OtherOperations()


        public static bool CheckMaxInput()
        {
            bool checkMax = false;

            if (m_input != null)
            {
                string tempInput = Regex.Replace(m_input, @"\D", "");
                m_countDigit = tempInput.Length;

                if (m_countDigit == 10) checkMax = true;
            }

            return checkMax;
        }//CheckMaxInput()

        public static string GetResult()
        {
            return m_input;
        }

    }
}
