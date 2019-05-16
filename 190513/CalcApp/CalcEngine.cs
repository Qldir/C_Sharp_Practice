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
        private static string m_input;          //Display Number
        private static string m_operation;      //Current operator
        private static string m_sign;           //Sign of Number
        public static bool m_isDecimal;         //Decimal status
        public static bool m_isWait;            //Wait for new input after a number
        public static int m_countDigit;         //Count of Digit

        private static readonly int MaxDigit = 10;     //Max Digit 10

        /// <summary>
        /// Init CalcEngine
        /// </summary>
        static CalcEngine()
        {
            m_input = "";
            m_operation = "";
            m_sign = "+";
            m_isDecimal = false;
            m_isWait = false;
        }


        /// <summary>
        /// Reset All Variables
        /// </summary>
        public static void ClearAll()
        {
            m_input = "";
            m_operation = "";
            m_sign = "+";
            m_isDecimal = false;
            m_countDigit = 0;
        }

        /// <summary>
        /// AppendNum "0~9"
        /// 初めて入力が'0'であることを除外
        /// </summary>
        /// <param name="numValue">Double Type</param>
        public static void AppendNum(double numValue)
        {
            if ( !(m_input.Equals("") && (numValue == 0)) )
            {
                m_input += "" + numValue;
            }

        }

        /// <summary>
        /// AppendNum 00
        /// 初めて入力が0であることを除外
        /// "00"の場合Int刑変換を通じて'0'でチェック
        /// </summary>
        /// <param name="numValue">Input Number Value</param>
        public static void AppendNum(string numValue)
        {
            if (!(m_input.Equals("") && (int.Parse(numValue) == 0)))
            {
                m_input += numValue;
            }
        }

        /// <summary>
        /// Arithmetic Operation
        /// 基本演算(+, -, *, /)を処理するメソッド
        /// </summary>
        /// <param name="operationType">演算(+, -, *, /)タイプ</param>
        public static void Operation(string operationType)
        {

        }

        /// <summary>
        /// 数字入力以外の電卓の機能を処理するメソッド
        /// </summary>
        /// <param name="buttonType"></param>
        public static void OtherOperations(string buttonType)
        {
            //Dot
            if (buttonType.Equals("dot"))
            {
                if (m_isDecimal == true)
                {
                    return;
                }

                if (m_input.Equals(""))
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
                if(!m_input.Equals(""))
                {
                    if (m_sign.Equals("+"))
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
                if(!m_input.Equals(""))
                {
                    //BackSpace at "±0."
                    if (((int)double.Parse(m_input) == 0) && (m_input.Substring(m_input.Length - 1).Equals(".")))
                    {
                        m_input = "";
                        m_isDecimal = false;
                        m_sign = "+";
                    }
                    else
                    {
                        //BackSpace at 1digit
                        if (m_input.Length <= 1 || (m_input.Length == 2 && m_sign.Equals("-")))
                        {
                            m_input = "";
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


        /// <summary>
        /// 入力された数字の長さをチェックして
        /// 現在の数字長さを保存。
        /// string入力値で数字を析出
        /// </summary>
        /// <returns>設定した最大長さになるとbool値trueで変換</returns>
        public static bool IsMaxInput()
        {
            bool isMax = false;

            if (!m_input.Equals(""))
            {
                ///<summary>
                ///Extracting Number
                ///Regex.Replace(string input, string pattern, string replacement);
                ///Replace pattern(@"\D") is [^0-9]
                ///正規表現を利用して数字以外の文字を変換
                ///例 : -123.441  ->  123441
                ///</summary>
                string extractNumber = Regex.Replace(m_input, @"\D", "");

                m_countDigit = extractNumber.Length;

                if (m_countDigit == MaxDigit)
                {
                    isMax = true;
                }
            }

            return isMax;
        }//isMaxInput()

        /// <summary>
        /// 現在の入力された値をreturn
        /// </summary>
        public static string GetResult()
        {
            return m_input;
        }

    }
}
