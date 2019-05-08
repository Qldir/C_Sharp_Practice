using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace _0508_Chapter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "HI";
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "こんにちは";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String fileName;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            
            
            if((saveFileDialog.ShowDialog() == DialogResult.OK))
            {
                if(saveFileDialog.FileName.Length > 0)
                {
                    fileName = saveFileDialog.FileName;
                    FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);

                    try
                    {
                        sw.WriteLine(textBox1.Text);
                        sw.Flush();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        sw.Close();
                        fs.Close();
                    }
                }
                
            }
        }
    }
}
