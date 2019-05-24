namespace CalcApp
{
    partial class CalcForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnMemClear = new System.Windows.Forms.Button();
            this.btnMemRead = new System.Windows.Forms.Button();
            this.btnIncludedTax = new System.Windows.Forms.Button();
            this.btnMemAdd = new System.Windows.Forms.Button();
            this.btnMemStore = new System.Windows.Forms.Button();
            this.btnGrandTotal = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnExcludedTax = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnMns = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.lblSubText = new System.Windows.Forms.Label();
            this.btn00 = new System.Windows.Forms.Button();
            this.pnlBackGround = new System.Windows.Forms.Panel();
            this.lblOnText = new System.Windows.Forms.Label();
            this.pnlBackGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.txtResult, "txtResult");
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            // 
            // btnMemClear
            // 
            this.btnMemClear.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnMemClear, "btnMemClear");
            this.btnMemClear.Name = "btnMemClear";
            this.btnMemClear.UseVisualStyleBackColor = true;
            // 
            // btnMemRead
            // 
            this.btnMemRead.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnMemRead, "btnMemRead");
            this.btnMemRead.Name = "btnMemRead";
            this.btnMemRead.UseVisualStyleBackColor = true;
            // 
            // btnIncludedTax
            // 
            resources.ApplyResources(this.btnIncludedTax, "btnIncludedTax");
            this.btnIncludedTax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIncludedTax.Name = "btnIncludedTax";
            this.btnIncludedTax.UseVisualStyleBackColor = true;
            // 
            // btnExcludedTax
            // 
            resources.ApplyResources(this.btnExcludedTax, "btnExcludedTax");
            this.btnExcludedTax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcludedTax.Name = "btnExcludedTax";
            this.btnExcludedTax.UseVisualStyleBackColor = true;
            // 
            // btnMemAdd
            // 
            this.btnMemAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnMemAdd, "btnMemAdd");
            this.btnMemAdd.Name = "btnMemAdd";
            this.btnMemAdd.UseVisualStyleBackColor = true;
            // 
            // btnMemStore
            // 
            this.btnMemStore.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnMemStore, "btnMemStore");
            this.btnMemStore.Name = "btnMemStore";
            this.btnMemStore.UseVisualStyleBackColor = true;
            // 
            // btnGrandTotal
            // 
            this.btnGrandTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnGrandTotal, "btnGrandTotal");
            this.btnGrandTotal.Name = "btnGrandTotal";
            this.btnGrandTotal.UseVisualStyleBackColor = true;
            // 
            // btnSign
            // 
            this.btnSign.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnSign, "btnSign");
            this.btnSign.Name = "btnSign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.ClickSignButton);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAllClear
            // 
            this.btnAllClear.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnAllClear, "btnAllClear");
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.Click += new System.EventHandler(this.ClickAllClearButton);
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.ClickBackButton);
            // 
            // btnPercent
            // 
            this.btnPercent.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnPercent, "btnPercent");
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btn9, "btn9");
            this.btn9.Name = "btn9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn8
            // 
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btn8, "btn8");
            this.btn8.Name = "btn8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn7
            // 
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btn7, "btn7");
            this.btn7.Name = "btn7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn6
            // 
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btn6, "btn6");
            this.btn6.Name = "btn6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn5
            // 
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btn5, "btn5");
            this.btn5.Name = "btn5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn4
            // 
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btn4, "btn4");
            this.btn4.Name = "btn4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn3
            // 
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btn3, "btn3");
            this.btn3.Name = "btn3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn2
            // 
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btn2, "btn2");
            this.btn2.Name = "btn2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn1
            // 
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.Name = "btn1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn0
            // 
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btn0, "btn0");
            this.btn0.Name = "btn0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.ClickNumButton);
            // 
            // btn00
            // 
            this.btn00.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btn00, "btn00");
            this.btn00.Name = "btn00";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.ClickNumButton);

            //=================[Operator Button]===========================================
            // 
            // btnPlus
            // 
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnPlus, "btnPlus");
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.ClickOperatorButton);
            // 
            // btnMns
            // 
            this.btnMns.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnMns, "btnMns");
            this.btnMns.Name = "btnMns";
            this.btnMns.UseVisualStyleBackColor = true;
            this.btnMns.Click += new System.EventHandler(this.ClickOperatorButton);
            // 
            // btnMul
            // 
            this.btnMul.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnMul, "btnMul");
            this.btnMul.Name = "btnMul";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.ClickOperatorButton);
            // 
            // btnDiv
            // 
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnDiv, "btnDiv");
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.ClickOperatorButton);
            // 
            // btnEqual
            // 
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnEqual, "btnEqual");
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.ClickOperatorButton);
            //============================================================================

            // 
            // btnDecimal
            // 
            this.btnDecimal.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btnDecimal, "btnDecimal");
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.ClickDecimalButton);
            // 
            // pnlBackGround
            // 
            this.pnlBackGround.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlBackGround.Controls.Add(this.lblSubText);
            this.pnlBackGround.Controls.Add(this.txtResult);
            resources.ApplyResources(this.pnlBackGround, "pnlBackGround");
            this.pnlBackGround.Name = "pnlBackGround";
            // 
            // lblSubText
            // 
            resources.ApplyResources(this.lblSubText, "lblSubText");
            this.lblSubText.BackColor = System.Drawing.SystemColors.Control;
            this.lblSubText.Name = "lblSubText";
            // 
            // lblOnText
            // 
            resources.ApplyResources(this.lblOnText, "lblOnText");
            this.lblOnText.Name = "lblOnText";
            // 
            // CalcForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblOnText);
            this.Controls.Add(this.pnlBackGround);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnMns);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnExcludedTax);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnGrandTotal);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMemStore);
            this.Controls.Add(this.btnMemAdd);
            this.Controls.Add(this.btnIncludedTax);
            this.Controls.Add(this.btnMemRead);
            this.Controls.Add(this.btnMemClear);
            this.KeyPreview = true;
            this.Name = "CalcForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GetKeyPress);
            this.pnlBackGround.ResumeLayout(false);
            this.pnlBackGround.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnMemClear;
        private System.Windows.Forms.Button btnMemRead;
        private System.Windows.Forms.Button btnIncludedTax;
        private System.Windows.Forms.Button btnMemAdd;
        private System.Windows.Forms.Button btnMemStore;
        private System.Windows.Forms.Button btnGrandTotal;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnExcludedTax;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnMns;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn0;
        public System.Windows.Forms.Label lblSubText;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Panel pnlBackGround;
        private System.Windows.Forms.Label lblOnText;
    }
}

