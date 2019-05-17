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
        private static string input;          //Display Number
        private static string operation;      //Current operator
        private static string sign;           //Sign of Number
        public static bool isDecimal;         //Decimal status
        public static bool isWait;            //Wait for new input after a number
        public static int countDigit;         //Count of Digit

        private static readonly int MaxDigit = 10;     //Max Digit 10

        /// <summary>
        /// Init CalcEngine
        /// </summary>
        static CalcEngine()
        {
            input = "";
            operation = "";
            sign = "+";
            isDecimal = false;
            isWait = false;
        }


        /// <summary>
        /// Reset All Variables
        /// </summary>
        public static void ClearAll()
        {
            input = "";
            operation = "";
            sign = "+";
            isDecimal = false;
            countDigit = 0;
        }


        /// <summary>
        /// AppendNum "0~9"
        /// 初めて入力が'0'であることを除外
        /// </summary>
        /// <param name="numValue">Double Type</param>
        public static void AppendNum(double numValue)
        {
            if ( !(input.Equals("") && (numValue == 0)) )
            {
                input += "" + numValue;
            }

        }


        /// <summary>
        /// AppendNum 00
        /// 初めて入力が0であることを除外
        /// "00"の場合Int刑変換を通じて'0'でチェック
        /// </summary>
        /// <param name="numValue">Input Number Value</param>arithmetic
        public static void AppendNum(string numValue)
        {
            if (!(input.Equals("") && (int.Parse(numValue) == 0)))
            {
                input += numValue;
            }
        }


        /// <summary>
        /// Arithmetic Operation
        /// 基本演算(+, -, *, /)を処理するメソッド
        /// </summary>
        /// <param name="operatorType">演算(+, -, *, /)タイプ</param>
        public static void NumericOperation(string operatorType)
        {

        }


        /// <summary>
        /// 数字入力以外の電卓の機能を処理するメソッド
        /// </summary>
        /// <param name="buttonType"></param>
        public static void NonNumericOperation(string buttonType)
        {
            //Dot
            if (buttonType.Equals("dot"))
            {
                if (isDecimal)
                {
                    return;
                }

                if (input.Equals(""))
                {
                    input = "0.";
                    isDecimal = true;
                }
                else
                {
                    input += ".";
                    isDecimal = true;
                }
            }
            //Switch Sign
            if (buttonType.Equals("sign"))
            {
                if(!input.Equals(""))
                {
                    if (sign.Equals("+"))
                    {
                        sign = "-";
                        input = sign + input;
                    }
                    else
                    {
                        if (sign.Equals("-"))
                        {
                            input = input.Remove(0, 1);
                        }
                        sign = "+";
                    }
                }
            }
            //BackSpace
            if (buttonType.Equals("back"))
            {
                if(!input.Equals(""))
                {
                    //BackSpace at "±0."
                    if (((int)double.Parse(input) == 0) && (input.Substring(input.Length - 1).Equals(".")))
                    {
                        input = "";
                        isDecimal = false;
                        sign = "+";
                    }
                    else
                    {
                        //BackSpace at 1digit
                        if (input.Length <= 1 || (input.Length == 2 && sign.Equals("-")))
                        {
                            input = "";
                            isDecimal = false;
                            sign = "+";
                        }
                        else
                        {
                            //BackSpace when the last digit is "."
                            if (input.Substring(input.Length - 1).Equals("."))
                            {
                                isDecimal = false;
                            }
                            input = input.Remove(input.Length - 1, 1);
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

            if (!input.Equals(""))
            {
                ///<summary>
                ///Extracting Number
                ///Regex.Replace(string input, string pattern, string replacement);
                ///Replace pattern(@"\D") is [^0-9]
                ///正規表現を利用して数字以外の文字を変換
                ///例 : -123.441  ->  123441
                ///</summary>
                string extractNumber = Regex.Replace(input, @"\D", "");

                countDigit = extractNumber.Length;

                if (countDigit >= MaxDigit)
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
            return input;
        }

    }
}
