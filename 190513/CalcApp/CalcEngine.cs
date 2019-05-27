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
        private decimal recentResult;     //Last Displayed Number
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
            recentResult = 0;
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
            recentResult = 0;
            lastInput = String.Empty;
            operation = String.Empty;
            sign = "+";
            isDecimal = false;
            isWait = false;
            countDigit = 0;
        }


        public void Clear()
        {
            input = String.Empty;
            sign = "+";
            isDecimal = false;
            isWait = false;
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
            AppendNumAfterWait();
            //값이 0일때 다른수넣으면 붙이는게 아닌 입력
            if (String.IsNullOrEmpty(input))
            {
                input += "" + numValue;
                return;
            }

            if(input.Equals("0"))
            {
                input = "" + numValue;
                return;
            }

            input += "" + numValue;

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
            AppendNumAfterWait();

            if (!(String.IsNullOrEmpty(input) && (int.Parse(numValue) == 0)))
            {
                input += numValue;
            }
        }


        /// <summary>
        /// Append Decimal
        /// Event Method : ClickDecimalButton
        /// isDecimal == true  -> return
        /// input == String.Empty -> 0.####
        /// </summary>
        public void AppendDecimal()
        {
            AppendNumAfterWait();

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
        /// if(isWait) { isWait = false; input = String.Empty; }
        /// </summary>
        private void AppendNumAfterWait()
        {
            if (isWait)
            {
                Clear();
                return;
            }

            if (operation.Equals("="))
            {
                Clear();
                operation = String.Empty;
                return;
            }
        }


        /// <summary>
        /// Arithmetic Operation
        /// Event Method : ClickOperatorButton
        /// 基本演算(+, -, *, /, =)を処理するメソッド
        /// ÷,×, -, +, =
        /// </summary>
        /// <param name="operatorType">演算(+, -, *, /, =)タイプ</param>
        public void Calculate(string operatorType)
        {

            if (isWait)
            {
                operation = operatorType;
                return;
            }

            if (String.IsNullOrEmpty(input))
            {
                input = "0";
            }

            if (String.IsNullOrEmpty(lastInput))
            {
                lastInput = input;
                isWait = true;
                operation = operatorType;
                return;
            }

            switch (operation)
            {
                case "+":
                    recentResult = Convert.ToDecimal(lastInput) + Convert.ToDecimal(input);
                    break;
                case "-":
                    recentResult = Convert.ToDecimal(lastInput) - Convert.ToDecimal(input);
                    break;
                case "×":
                    recentResult = Convert.ToDecimal(lastInput) * Convert.ToDecimal(input);
                    break;
                case "÷":
                    recentResult = Convert.ToDecimal(lastInput) / Convert.ToDecimal(input);
                    break;
                case "=":
                    //Add GT
                    break;
                default:
                    Console.WriteLine("Invalid Parameter Value");
                    break;
            }

            if (recentResult < 0)
            {
                sign = "-";
            }

            input = Convert.ToString(recentResult);

            //小数点フォーマット適用
            ApplyDecimalPattern();

            operation = operatorType;

            if (operation.Equals("="))
            {
                lastInput = String.Empty;
                isWait = false;
                return;
            }

            lastInput = input;

            isWait = true;

        }


        /// <summary>
        /// Switch Sign +-
        /// Event Method : ClickSignButton
        /// </summary>
        public void SwitchSign()
        {
            if (String.IsNullOrEmpty(input))
            {
                return;
            }

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


        /// <summary>
        /// Remove Digit
        /// Event Method : ClickBackButton
        /// - One digit delete
        /// </summary>
        public void RemoveDigit()
        {
            if (String.IsNullOrEmpty(input))
            {
                return;
            }

            //(input.Length <= 1) || (input.Length == 2 && sign.Equals("-")) || (input.Equals("0."))
            if (IsRemoveDigit())
            {
                input = String.Empty;
                isDecimal = false;
                sign = "+";

                return;
            }

            //BackSpace when the last digit is "."
            if (input.Substring(input.Length - 1).Equals("."))
            {
                isDecimal = false;
            }

            input = input.Remove(input.Length - 1, 1);
        }


        private bool IsRemoveDigit()
        {
            return (input.Length <= 1) || (input.Length == 2 && sign.Equals("-")) || (input.Equals("0."));
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


            if (String.IsNullOrEmpty(input) || isWait || operation.Equals("="))
            {
                return isMax;
            }

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

            return isMax;
        }//isMaxInput()


        public string GetOperation()
        {
            return operation;
        }


        /// <summary>
        /// Limit the number of digits
        /// 出力値の桁を10文字まで限る
        /// 0.123 + 12345678 = 12345678.12
        /// 0.000000001 X 0.5 = 0
        /// </summary>
        private string LimitDigit(string resultNumber)
        {
            string extractNumber = Regex.Replace(resultNumber, @"\D", "");

            if (extractNumber.Length <= MaxDigit)
            {
                return resultNumber;
            }

            int maxLength = MaxDigit;

            if (sign.Equals("-"))
            {
                maxLength++;
            }

            if (resultNumber.IndexOf(".") != -1)
            {
                maxLength++;
            }

            if (resultNumber.IndexOf(".") == 10)
            {
                maxLength--;
            }

            input = resultNumber.Substring(0, maxLength);

            // 小数点があるときだけ表示
            ApplyDecimalPattern();

            lastInput = input;

            return input;
        }


        /// <summary>
        /// 演算結果に適用
        /// 小数点があるときだけ表示
        /// </summary>
        private void ApplyDecimalPattern()
        {
            if(input.IndexOf(".") == -1)
            {
                return;
            }

            while ((input.IndexOf(".") != -1) && (input.LastIndexOf("0") == input.Length - 1))
            {
                RemoveDigit();
            }

            if (input.IndexOf(".") == input.Length - 1)
            {
                RemoveDigit();
                return;
            }
        }


        /// <summary>
        /// 現在の入力された値をreturn
        /// </summary>
        public string GetResult()
        {
            return LimitDigit(input);
        }

    }
}
