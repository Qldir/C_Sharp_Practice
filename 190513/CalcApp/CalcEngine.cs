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
        public static bool m_isDecimal; //Decimal status
        public static int m_countDigit; //Count of Digit
        public static bool m_isWait;  // 

        //Init CalcEngine
        static CalcEngine()
        {
            m_input = null;
            m_operation = null;
            m_sign = "+";
            m_isDecimal = false;
            m_isWait = false;
        }

        //Reset All Variables
        public static void ClearAll()
        {
            m_input = null;
            m_operation = null;
            m_sign = "+";
            m_isDecimal = false;
            m_countDigit = 0;
        }

        public static void AppendNum(double numValue)
        {
            if ( !((m_input == null) && (numValue == 0)) )
            {
                m_input += "" + numValue;
            }

        }

        public static void AppendNum(string numValue)
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
                if (m_isDecimal == true)
                {
                    return;
                }

                if (m_input == null)
                {
                    m_input = "0.";
                    m_isDecimal = true;
                }
                else
                {
                    m_input += ".";
                    m_isDecimal = true;
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
                        m_isDecimal = false;
                        m_sign = "+";
                    }
                    else
                    {
                        //BackSpace at 1digit
                        if (m_input.Length <= 1 || (m_input.Length == 2 && m_sign.Equals("-")))
                        {
                            m_input = null;
                            m_isDecimal = false;
                            m_sign = "+";
                        }
                        else
                        {
                            //BackSpace when the last digit is "."
                            if (m_input.Substring(m_input.Length - 1).Equals("."))
                            {
                                m_isDecimal = false;
                            }
                            m_input = m_input.Remove(m_input.Length - 1, 1);
                        }
                    }
                }
            }
        }//OtherOperations()


        public static bool IsMaxInput()
        {
            bool isMax = false;

            if (m_input != null)
            {
                string tempInput = Regex.Replace(m_input, @"\D", "");
                m_countDigit = tempInput.Length;

                if (m_countDigit == 10)
                {
                    isMax = true;
                }
            }

            return isMax;
        }//isMaxInput()

        public static string GetResult()
        {
            return m_input;
        }

    }
}
