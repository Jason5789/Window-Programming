using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h34101096_practice_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] b = new Button[26];
        string[] ans;
        int[] correct;
        int sec=0;
        int finish = 0;
        int sta = 0;

        private void start_Click(object sender, EventArgs e)
        {
            sta = 1;
            answer.Text = answer.Text.ToUpper();
            ans = new string[answer.Text.Length];
            correct = new int[answer.Text.Length];

            for (int i =0;i< answer.Text.Length; i++)
            {
                ans[i] = answer.Text.Substring(i, 1);
                correct[i] = 0;
            }

            label1.Enabled = false;
            label1.Visible = false;
            label2.Enabled = false;
            label2.Visible = false;
            answer.Enabled = false;
            answer.Visible = false;
            start.Enabled = false;
            start.Visible = false;

            time.Enabled = true;
            time.Visible = true;
            timeNum.Enabled = true;
            timeNum.Visible = true;
            wrong.Enabled = true;
            wrong.Visible = true;
            guess.Enabled = true;
            guess.Visible = true;
            wrongTime.Enabled = true;
            wrongTime.Visible = true;

            timer1.Enabled = true;
            timer1.Interval = 1000;

            for (char c = 'A'; c <= 'Z'; c++)
            {
                int i = c - 65;
                b[i] = new Button();
                b[i].SetBounds(45*(i%9)+95, 45 * (i / 9) + 30, 40, 40);
                b[i].BackColor = Color.White;
                b[i].Enabled = false;
                b[i].Text = c.ToString();
                b[i].Name = c.ToString();
                Controls.Add(b[i]);
            }

            int length = answer.Text.Length;
            string s = "";

            for(int i = 0; i < length; i++)
            {
                s += "_";

                if (i != length - 1)
                {
                    s += " ";
                }
            }

            guess.Text = s;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (sta == 1)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        B_click("A");
                        break;
                    case Keys.B:
                        B_click("B");
                        break;
                    case Keys.C:
                        B_click("C");
                        break;
                    case Keys.D:
                        B_click("D");
                        break;
                    case Keys.E:
                        B_click("E");
                        break;
                    case Keys.F:
                        B_click("F");
                        break;
                    case Keys.G:
                        B_click("G");
                        break;
                    case Keys.H:
                        B_click("H");
                        break;
                    case Keys.I:
                        B_click("I");
                        break;
                    case Keys.J:
                        B_click("J");
                        break;
                    case Keys.K:
                        B_click("K");
                        break;
                    case Keys.L:
                        B_click("L");
                        break;
                    case Keys.M:
                        B_click("M");
                        break;
                    case Keys.N:
                        B_click("N");
                        break;
                    case Keys.O:
                        B_click("O");
                        break;
                    case Keys.P:
                        B_click("P");
                        break;
                    case Keys.Q:
                        B_click("Q");
                        break;
                    case Keys.R:
                        B_click("R");
                        break;
                    case Keys.S:
                        B_click("S");
                        break;
                    case Keys.T:
                        B_click("T");
                        break;
                    case Keys.U:
                        B_click("U");
                        break;
                    case Keys.V:
                        B_click("V");
                        break;
                    case Keys.W:
                        B_click("W");
                        break;
                    case Keys.X:
                        B_click("X");
                        break;
                    case Keys.Y:
                        B_click("Y");
                        break;
                    case Keys.Z:
                        B_click("Z");
                        break;
                }
            }
            
        }


        private void B_click(string p)
        {
            int now;
            int yes = 0;
            for(now = 0; now < 26; now++)
            {
                if (p == b[now].Text)
                {
                    yes = 1;
                    break;
                }
            }

            if (answer.Text.Contains(p) && yes==1 && b[now].Visible == true)
            {
                string s="";
                b[now].BackColor = Color.LightGreen;

                for(int i = 0; i < ans.Length; i++)
                {
                    if (correct[i] == 1)
                    {
                        s += ans[i];
                    }
                    else if (ans[i] == b[now].Text)
                    {
                        s += b[now].Text;
                        correct[i] = 1;
                        finish++;
                    }
                    else
                    {
                        s += "_";
                    }

                    if (i != ans.Length - 1)
                    {
                        s += " ";
                    }
                }

                guess.Text = s;

                if (finish == ans.Length)
                {
                    timer1.Enabled = false;
                    DialogResult d = MessageBox.Show("花費時間:" + timeNum.Text + "\n猜錯" + wrongTime.Text + "次", "You win!");

                    if (d == DialogResult.OK)
                    {
                        reset();
                    }
                }
            }
            else if(b[now].Visible == true)
            {
                b[now].Enabled = false;
                b[now].Visible = false;

                int i = Convert.ToInt32(wrongTime.Text);
                wrongTime.Text = (++i).ToString();

                if (Convert.ToInt32(wrongTime.Text) == 6)
                {
                    timer1.Enabled = false;
                    DialogResult d = MessageBox.Show("You Lose!");

                    if (d == DialogResult.OK)
                    {
                        reset();
                    }
                }

            }
        }

        private void answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) || c==8 || c==46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            timeNum.Text = sec.ToString();
        }

        private void reset()
        {
            label1.Enabled = true;
            label1.Visible = true;
            label2.Enabled = true;
            label2.Visible = true;
            answer.Enabled = true;
            answer.Visible = true;
            start.Enabled = true;
            start.Visible = true;

            time.Enabled = false;
            time.Visible = false;
            timeNum.Enabled = false;
            timeNum.Visible = false;
            wrong.Enabled = false;
            wrong.Visible = false;
            guess.Enabled = false;
            guess.Visible = false;
            wrongTime.Enabled = false;
            wrongTime.Visible = false;

            answer.Text = "";

            sec = 0;
            finish = 0;
            wrongTime.Text = "0";
            timeNum.Text = "0";

            for (int i = 0; i < 26; i++)
            {
                Controls.Remove(b[i]);
            }
        }

    }
}
