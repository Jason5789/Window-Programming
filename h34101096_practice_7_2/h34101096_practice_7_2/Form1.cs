﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace h34101096_practice_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int add = 0;
        string path;
        string all;
        string search;
        public int choose = 0;

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
                string str;
                this.Text = Path.GetFileNameWithoutExtension(openfile.FileName) + "-待辦清單";
                StreamReader s = new StreamReader(openfile.FileName);
                textBox.Text = "";

                do
                {
                    str = s.ReadLine();
                    if (str == null)
                    {
                        break;
                    }
                    else
                    {
                        if (str.Substring(0, 1) == "+")
                        {
                            str = str.Remove(0, 1);
                            str = str.Insert(0, " [√] ");
                        }
                        else if (str.Substring(0, 1) == "-")
                        {
                            str = str.Remove(0, 1);
                            str = str.Insert(0, " [　] ");
                        }

                        if(textBox.Text != "")
                        {
                            textBox.Text += "\r\n";
                        }
                        textBox.Text += str;
                    }
                } while (true);
               
                s.Close();
                path = openfile.FileName;

                all = textBox.Text;
            }
        }

        private void safe_Click(object sender, EventArgs e)
        {
            if (add == 1)
            {
                string check = textBox.Text;
                string ans = "";

                while (check != "")
                {
                    if (check.IndexOf(" [", 5) == -1)
                    {
                        string first = check.Substring(0);

                        if (first.IndexOf(" [　] ") == 0)
                        {
                            first = first.Remove(0, 5);
                            first = first.Insert(0, "-");
                        }
                        else if (first.IndexOf(" [√] ") == 0)
                        {
                            first = first.Remove(0, 5);
                            first = first.Insert(0, "+");
                        }

                        ans += first;
                        check = check.Remove(0);
                    }
                    else
                    {
                        string first = check.Substring(0, check.IndexOf(" [", 5));
                        if (first.IndexOf(" [　] ") == 0)
                        {
                            first = first.Remove(0, 5);
                            first = first.Insert(0, "-");
                        }
                        else if (first.IndexOf(" [√] ") == 0)
                        {
                            first = first.Remove(0, 5);
                            first = first.Insert(0, "+");
                        }
                        ans += first;
                        check = check.Remove(0, check.IndexOf(" [", 5));
                    }
                }

                StreamWriter s = new StreamWriter(path);
                s.WriteLine(ans);
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
                if (saveFileDialog.FilterIndex == 1 && !(saveFileDialog.FileName.Contains(".todo")))
                {
                    saveFileDialog.FileName += ".todo";
                }
                else if (saveFileDialog.FilterIndex == 2 && !(saveFileDialog.FileName.Contains(".txt")))
                {
                    saveFileDialog.FileName += ".txt";
                }

                string check = textBox.Text;
                string ans = "";

                while (check != "")
                {
                    if (check.IndexOf(" [", 5) == -1)
                    {
                        string first = check.Substring(0);

                        if (first.IndexOf(" [　] ") == 0)
                        {
                            first = first.Remove(0, 5);
                            first = first.Insert(0, "-");
                        }
                        else if (first.IndexOf(" [√] ") == 0)
                        {
                            first = first.Remove(0, 5);
                            first = first.Insert(0, "+");
                        }

                        ans += first;
                        check = check.Remove(0);
                    }
                    else
                    {
                        string first = check.Substring(0, check.IndexOf(" [", 5));
                        if(first.IndexOf(" [　] ") == 0)
                        {
                            first = first.Remove(0, 5);
                            first = first.Insert(0, "-");
                        }
                        else if (first.IndexOf(" [√] ") == 0)
                        {
                            first = first.Remove(0, 5);
                            first = first.Insert(0, "+");
                        }
                        ans += first;
                        check = check.Remove(0, check.IndexOf(" [", 5));
                    }
                }

                StreamWriter s = new StreamWriter(saveFileDialog.FileName);
                s.WriteLine(ans);
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

        private void ok_Click(object sender, EventArgs e)
        {
            if (all != "")
            {
                textBox.Text = all;
            }
            else
            {
                all = textBox.Text;
            }
            
        }

        private void nok_Click(object sender, EventArgs e)
        {
            string no, ans;
            if(textBox.Text.Contains(" [√] "))
            {
                all = textBox.Text;
            }
            
            no = textBox.Text;
            ans = "";

            while(no.IndexOf(" [√] ") != -1)
            {
                if(no.IndexOf(" [　] ") != -1)
                {
                    if (no.IndexOf(" [√] ") == 0 && no.IndexOf(" [√] ", no.IndexOf(" [　] ")) == -1)
                    {
                        no = no.Remove(0, no.IndexOf(" [　] "));
                        ans += no;
                    }
                    else if (no.IndexOf(" [√] ") == 0)
                    {
                        no = no.Remove(0, no.IndexOf(" [　] "));
                        ans += no.Substring(0, no.IndexOf(" [√] "));
                        no = no.Remove(0, no.IndexOf(" [√] "));
                    }
                    else if(no.IndexOf(" [√] ") != 0)
                    {
                        ans += no.Substring(0, no.IndexOf(" [√] "));
                        no = no.Remove(0, no.IndexOf(" [√] "));
                    }
                }
                else
                {
                    no = "";
                }
                
            }

            textBox.Text = ans;


        }

        private void additem_Click(object sender, EventArgs e)
        {
            if(additem.Text == "關閉搜尋")
            {
                textBox.Text = search;
                additem.Text = "新增事項";
                menuStrip1.Enabled = true;
                finishitem.Enabled = true;
                finishitem.Visible = true;
            }
            else
            {
                choose = 1;
                Form2 f2 = new Form2();
                this.Enabled = false;
                f2.ShowDialog();


                if (f2.enter == true)
                {
                    string str = f2.input;
                    adding(str);
                }
                this.Enabled = true;
                all = textBox.Text;
            }
        }

        private void adding(string str)
        {
            
            if (textBox.Text == "")
            {
                if (str.Substring(0, 1) == "+")
                {
                    str = str.Remove(0, 1);
                    str = str.Insert(0, " [√] ");
                }
                else if (str.Substring(0, 1) == "-")
                {
                    str = str.Remove(0, 1);
                    str = str.Insert(0, " [　] ");
                }

                textBox.Text = str;
                all = str;
            }
            else if (textBox.Text.LastIndexOf("") == 0)
            {
                if (str.Substring(0, 1) == "+")
                {
                    str = str.Remove(0, 1);
                    str = str.Insert(0, " [√] ");
                }
                else if (str.Substring(0, 1) == "-")
                {
                    str = str.Remove(0, 1);
                    str = str.Insert(0, " [　] ");
                }

                textBox.Text = textBox.Text + str;
                all = all + str;
            }
            else
            {
                if (str.Substring(0, 1) == "+")
                {
                    str = str.Remove(0, 1);
                    str = str.Insert(0, " [√] ");
                }
                else if (str.Substring(0, 1) == "-")
                {
                    str = str.Remove(0, 1);
                    str = str.Insert(0, " [　] ");
                }


                textBox.Text = textBox.Text + "\r\n" + str;
                all = all + "\r\n" + str;
            }
        }

        private void finishitem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.ShowDialog();


            if (f2.enter == true)
            {
                string str = f2.input;
                finish(str);
            }
            this.Enabled = true;
            all = textBox.Text;
        }

        private void finish(string str)
        {
            int place = textBox.Text.IndexOf(str);
            int leng = str.Length;
            if (textBox.Text.Contains(str) && (textBox.Text.Substring(place - 5, 5) == " [√] " || textBox.Text.Substring(place - 5, 5) == " [　] "))
            {
                if (place + leng + 3 < textBox.Text.Length)
                {
                    if (textBox.Text.Substring(place + leng + 2, 5) == " [√] " || textBox.Text.Substring(place + leng + 2, 5) == " [　] ")
                    {
                        textBox.Text = textBox.Text.Remove(place - 5, 5);
                        textBox.Text = textBox.Text.Insert(textBox.Text.IndexOf(str), " [√] ");
                    }
                }
                else if (place + leng == textBox.Text.Length)
                {
                    textBox.Text = textBox.Text.Remove(place - 5, 5);
                    textBox.Text = textBox.Text.Insert(textBox.Text.IndexOf(str), " [√] ");
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            choose = 1;
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.ShowDialog();


            if (f2.enter == true)
            {
                search = textBox.Text;
                string str = f2.input;
                string check = textBox.Text;
                string ans = "";

                while (check.Contains(str))
                {
                    if(check.IndexOf(" [", 5) == -1)
                    {
                        string first = check.Substring(0);

                        if (first.Contains(str))
                        {
                            ans += first;
                        }

                        check = check.Remove(0);
                    }
                    else
                    {
                        string first = check.Substring(0, check.IndexOf(" [", 5));

                        if (first.Contains(str))
                        {
                            ans += first;
                        }

                        check = check.Remove(0, check.IndexOf(" [", 5));
                    }
                }
                textBox.Text = ans;

                this.Enabled = true;
                menuStrip1.Enabled = false;
                finishitem.Enabled = false;
                finishitem.Visible = false;
                additem.Text = "關閉搜尋";
            }
            else
            {
                this.Enabled = true;
            }
        }

        private void additemup_Click(object sender, EventArgs e)
        {
            choose = 1;
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.ShowDialog();


            if (f2.enter == true)
            {
                string str = f2.input;
                adding(str);
            }
            this.Enabled = true;
            all = textBox.Text;
        }

        private void finishitemup_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.ShowDialog();


            if (f2.enter == true)
            {
                string str = f2.input;
                finish(str);
            }
            this.Enabled = true;
            all = textBox.Text;
        }

        private void deleteitemup_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Enabled = false;
            f2.ShowDialog();


            if (f2.enter == true)
            {
                string str = f2.input;

                int place = textBox.Text.IndexOf(str);
                int leng = str.Length;
                if (textBox.Text.Contains(str) && (textBox.Text.Substring(place - 5, 5) == " [√] " || textBox.Text.Substring(place - 5, 5) == " [　] "))
                {
                    if (place + leng + 3 < textBox.Text.Length)
                    {
                        if (textBox.Text.Substring(place + leng + 2, 5) == " [√] " || textBox.Text.Substring(place + leng + 2, 5) == " [　] ")
                        {
                            textBox.Text = textBox.Text.Remove(place - 5, leng + 7);
                        }
                    }
                    else if (place + leng == textBox.Text.Length)
                    {
                        textBox.Text = textBox.Text.Remove(place - 7);
                    }
                }
            }
            this.Enabled = true;
            all = textBox.Text;
        }
    }
}
