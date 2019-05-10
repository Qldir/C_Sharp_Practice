using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07_0509
{
    public partial class AccountBook : Form
    {
        public AccountBook()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------
        //View Event
        //------------------------------------------------------------------------------

        private void AccountBook_Load(object sender, EventArgs e)
        {
            LoadData();
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", "入金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", "出金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("雑費", "出金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("住居", "出金");
        }

        private void AccountBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }


        //------------------------------------------------------------------------------
        //Form Event
        //------------------------------------------------------------------------------

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //------------------------------------------------------------------------------
        //StripMenu Event
        //------------------------------------------------------------------------------

        //File Menu
        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        
        private void 完了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Edit Menu
        private void 追加AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void 変更CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void 削除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        //View Menu
        private void 一覧表示SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabList);
        }

        private void 集計表示SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabSummary);
        }


        //------------------------------------------------------------------------------
        //tabControl Event
        //------------------------------------------------------------------------------

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSummary();
        }


        //------------------------------------------------------------------------------
        //Util method
        //------------------------------------------------------------------------------

        private void AddData()
        {
            ItemForm frmItem = new ItemForm(categoryDataSet1);
            DialogResult drRet = frmItem.ShowDialog();

            if (drRet == DialogResult.OK)
            {
                moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                frmItem.monCalendar.SelectionRange.Start,
                frmItem.cmbCategory.Text,
                frmItem.txtItem.Text,
                int.Parse(frmItem.mtxtMoney.Text),
                frmItem.txtRemarks.Text);
            }
        }

        private void LoadData()
        {
            string path = "MoneyData.csv";
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();

            string[] strData;
            string strLine;

            bool fileExists = File.Exists(path);

            if (fileExists)
            {
                StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);

                try
                {
                    while (sr.Peek() >= 0)
                    {
                        strLine = sr.ReadLine();
                        strData = strLine.Split(delimiter);
                        moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                                                    DateTime.Parse(strData[0]),
                                                    strData[1],
                                                    strData[2],
                                                    int.Parse(strData[3]),
                                                    strData[4]);
                    }
                }
                catch(IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sr.Close();
                }
            }

        }

        private void UpdateData()
        {
            int nowRow = dgv.CurrentRow.Index;

            //Cells param
            DateTime oldDate = DateTime.Parse(dgv.Rows[nowRow].Cells[0].Value.ToString());
            string oldCategory = dgv.Rows[nowRow].Cells[1].Value.ToString();
            string oldItem = dgv.Rows[nowRow].Cells[2].Value.ToString();
            int oldMoney = int.Parse(dgv.Rows[nowRow].Cells[3].Value.ToString());
            string oldRemarks = dgv.Rows[nowRow].Cells[4].Value.ToString();

            ItemForm frmItem = new ItemForm(categoryDataSet1, oldDate, oldCategory, oldItem, oldMoney, oldRemarks);

            DialogResult drRet = frmItem.ShowDialog();

            if(drRet == DialogResult.OK)
            {
                dgv.Rows[nowRow].Cells[0].Value = frmItem.monCalendar.SelectionRange.Start;
                dgv.Rows[nowRow].Cells[1].Value = frmItem.cmbCategory.Text;
                dgv.Rows[nowRow].Cells[2].Value = frmItem.txtItem.Text;
                dgv.Rows[nowRow].Cells[3].Value = int.Parse(frmItem.mtxtMoney.Text);
                dgv.Rows[nowRow].Cells[4].Value = frmItem.txtRemarks.Text;
            }

        }

        private void SaveData()
        {
            string path = "MoneyData.csv";
            string strData = "";

            StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default);

            try
            {
                foreach (MoneyDataSet.moneyDataTableRow drMoney in moneyDataSet.moneyDataTable)
                {
                    strData = drMoney.日付.ToShortDateString() + ","
                            + drMoney.分類 + ","
                            + drMoney.品名 + ","
                            + drMoney.金額.ToString() + ","
                            + drMoney.備考;
                    sw.WriteLine(strData);
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }

        private void DeleteData()
        {
            int nowRow = dgv.CurrentRow.Index;

            dgv.Rows.RemoveAt(nowRow);
        }


        /// <summary>
        /// total Account Calc method
        /// </summary>
        private void CalcSummary()
        {
            string expression;

            summaryDataSet.SumDataTable.Clear();

            foreach(MoneyDataSet.moneyDataTableRow drMoney in moneyDataSet.moneyDataTable)
            {
                expression = "日付= '" + drMoney.日付.ToShortDateString() + "'";
                SummaryDataSet.SumDataTableRow[] curDR = (SummaryDataSet.SumDataTableRow[])summaryDataSet.SumDataTable.Select(expression);

                if(curDR.Length == 0)
                {
                    CategoryDataSet.CategoryDataTableRow[] selectedDataRow;

                    selectedDataRow =
                        (CategoryDataSet.CategoryDataTableRow[])categoryDataSet1.CategoryDataTable.Select("分類='" + drMoney.分類 + "'");

                    if(selectedDataRow[0].入出金分類 == "入金")
                    {
                        summaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付, drMoney.金額, 0);
                    }
                    else if (selectedDataRow[0].入出金分類 == "出金")
                    {
                        summaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付, 0, drMoney.金額);
                    }

                }
                else
                {
                    CategoryDataSet.CategoryDataTableRow[] selectedDataRow;
                    selectedDataRow =
                        (CategoryDataSet.CategoryDataTableRow[])categoryDataSet1.CategoryDataTable.Select("分類='" + drMoney.分類 + "'");

                    if (selectedDataRow[0].入出金分類 == "入金")
                    {
                        curDR[0].入金合計 += drMoney.金額;
                    }
                    else if (selectedDataRow[0].入出金分類 == "出金")
                    {
                        curDR[0].出金合計 += drMoney.金額;
                    }
                }

            }//foreach
        }//CalcSummary()

        private void バージョン情報VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create 2019/05/11");
        }
    }
}
