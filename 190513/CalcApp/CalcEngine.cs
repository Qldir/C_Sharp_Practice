using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalcApp
{


    public class CalcEngine
    {
        #region fields

        private string input;            //Display Number
        private string recentResult;     //Last Displayed Number
        private string lastInput;        //Last Input Number
        private string operation;        //Current operator
        private string sign;             //Sign of Number
        public bool isDecimal;           //Decimal status
        public bool isWait;              //Wait for new input after a number
        public int countDigit;           //Count of Digit

        public static readonly int MaxDigit = 10;     //Max Digit 10

        #endregion


        /// <summary>
        /// Init CalcEngine
        /// </summary>
        public CalcEngine()
        {
            input = String.Empty;
            recentResult = String.Empty;
            lastInput = String.Empty;
            operation = String.Empty;
            sign = "+";
            isDecimal = false;
            isWait = false;
        }


        /// <summary>
        /// Reset All Variables
        /// Event Method : ClickAllClearButton
        /// </summary>
        public void ClearAll()
        {
            input = String.Empty;
            recentResult = String.Empty;
            lastInput = String.Empty;
            operation = String.Empty;
            sign = "+";
            isDecimal = false;
            countDigit = 0;
        }


        /// <summary>
        /// AppendNum "0~9"
        /// Event Method : ClickNumButton
        /// 初めて入力が'0'であることを除外
        /// </summary>
        /// <param name="numValue">Double Type</param>
        public void AppendNum(double numValue)
        {
            if ( !(String.IsNullOrEmpty(input) && (numValue == 0)) )
            {
                input += "" + numValue;
            }

        }


        /// <summary>
        /// AppendNum 00
        /// Event Method : ClickNumButton
        /// 初めて入力が0であることを除外
        /// "00"の場合Int刑変換を通じて'0'でチェック
        /// </summary>
        /// <param name="numValue">Input Number Value</param>arithmetic
        public void AppendNum(string numValue)
        {
            if (!(String.IsNullOrEmpty(input) && (int.Parse(numValue) == 0)))
            {
                input += numValue;
            }
        }


        /// <summary>
        /// Arithmetic Operation
        /// 基本演算(+, -, *, /)を処理するメソッド
        /// </summary>
        /// <param name="operatorType">演算(+, -, *, /)タイプ</param>
        public void Calculate(string operatorType)
        {

        }


        /// <summary>
        /// Append Decimal
        /// Event Method : ClickDecimalButton
        /// isDecimal == true  -> return
        /// input == String.Empty -> 0.####
        /// </summary>
        public void AppendDecimal()
        {
            if (isDecimal)
            {
                return;
            }

            if (String.IsNullOrEmpty(input))
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


        /// <summary>
        /// Switch Sign +-
        /// Event Method : ClickSignButton
        /// </summary>
        public void SwitchSign()
        {
            if (!String.IsNullOrEmpty(input))
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


        /// <summary>
        /// Remove Digit
        /// Event Method : ClickBackButton
        /// - One digit delete
        /// </summary>
        public void RemoveDigit()
        {
            if (!String.IsNullOrEmpty(input))
            {
                //BackSpace at 1digit
                //Input Length <= 1   OR
                //-[0~9] -> 0       0. -> 0
                if (input.Length <= 1 || (input.Length == 2 && (sign.Equals("-") || input.IndexOf("0") == 0) ))
                {
                    input = String.Empty;
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


        /// <summary>
        /// IsMaxInput
        /// 入力された数字の長さをチェックして
        /// 現在の数字長さを保存。
        /// string入力値で数字を析出
        /// </summary>
        /// <returns>設定した最大長さになるとbool値trueで変換</returns>
        public bool IsMaxInput()
        {
            bool isMax = false;

            if (!String.IsNullOrEmpty(input))
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
        public string GetResult()
        {
            return input;
        }

    }
}
