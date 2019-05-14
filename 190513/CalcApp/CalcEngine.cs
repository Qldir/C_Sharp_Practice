using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{


    internal class CalcEngine
    {
        private static string m_input; //Display Number
        private static string m_operation; //Current operator
        private static string m_sign;
        private static bool m_decimal;

        //Init CalcEngine
        static CalcEngine()
        {
            m_input = null;
            m_operation = null;
            m_sign = "+";
            m_decimal = false;
        }

        public static void NumAppend(double numValue)
        {
            if ( !((m_input == null) && (numValue == 0)) )
            {
                m_input += "" + numValue;
            }

        }

        public static void Operation(string operationType)
        {

        }

        public static double GetResult()
        {
            return Convert.ToDouble(m_input);
        }
    }
}
