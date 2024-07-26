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

namespace h34101096_practice_7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int add = 0;
        string path;

        private void newone_Click(object sender, EventArgs e)
        {
            this.Text = "未命名*-待辦清單";
            add = 0;
            textBox.Text = "";
        }

        private void open_Click(object sender, EventArgs e)
        {
            add = 1;
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Todo Files(*.todo)|*.todo*|Text Files(*.txt)|*.txt*|All Files(*.*)|*.*";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                this.Text =  Path.GetFileNameWithoutExtension(openfile.FileName) + "-待辦清單";
                StreamReader s = new StreamReader(openfile.FileName);
                textBox.Text = s.ReadToEnd();
                path = openfile.FileName;
                s.Close();
            }
        }

        private void safe_Click(object sender, EventArgs e)
        {
            if (add == 1)
            {
                StreamWriter s = new StreamWriter(path);
                s.WriteLine(textBox.Text);
                s.Close();
            }
            else
            {
                saveNewFunc();
            }
        }

        private void savenew_Click(object sender, EventArgs e)
        {
            saveNewFunc();
        }

        private void saveNewFunc()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Todo Files(*.todo)|*.todo*|Text Files(*.txt)|*.txt*|All Files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FilterIndex == 1 && !(saveFileDialog.FileName.Contains(".todo")) )
                {
                    saveFileDialog.FileName += ".todo";
                }
                else if (saveFileDialog.FilterIndex == 2 && !(saveFileDialog.FileName.Contains(".txt")) )
                {
                    saveFileDialog.FileName += ".txt";
                }

                StreamWriter s = new StreamWriter(saveFileDialog.FileName);
                s.WriteLine(textBox.Text);
                s.Close();
                if (add == 0)
                {
                    this.Text = Path.GetFileNameWithoutExtension(saveFileDialog.FileName) + "-待辦清單";
                }
            }
        }

        private void leave_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void word_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = fontDialog.Font;
            }
        }

        private void additem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.ShowDialog();
                

            if (f2.enter == true)
            {
                if (textBox.Text == "")
                {
                    textBox.Text = f2.input;
                }
                else if (textBox.Text.LastIndexOf("") == 0)
                {
                    textBox.Text = textBox.Text + f2.input;
                }
                else
                {
                    textBox.Text = textBox.Text + "\r\n" + f2.input;
                }
            }
            this.Enabled = true;
            
            
        }
    }
}
