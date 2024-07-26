using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h34101096_practice_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] already = new int[17] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int first, second;
        Button[] b = new Button[17];
        Random r = new Random();
        int choice = 0;
        int[] ima = new int[17];
        int score = 0;
        int grade;

        private void B_click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (choice == 0)
            {
                first = Convert.ToInt32(button.Name);
                button.Image = Image.FromFile(@"images\0" + ima[first] + ".jpg");
                choice = already[first];
            }
            else
            {
                second = Convert.ToInt32(button.Name);
                button.Image = Image.FromFile(@"images\0" + ima[second] + ".jpg");
                if (ima[first] == ima[second])
                {
                    button.Enabled = false;
                    b[first].Enabled = false;
                    going.Enabled = false;
                    choice = 0;
                    grade += 10;
                    point.Text = grade.ToString();
                    score++;
                }
                else
                {
                    going.Enabled = true;
                    grade -= 5;
                    point.Text = grade.ToString();
                    choice = 0;
                }

                if (score == 8)
                {
                    DialogResult d;
                    d = MessageBox.Show("分數: " + grade, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                    history.Text = history.Text + userName.Text + " 得分為：" + grade + "\n\n";

                    if (d == DialogResult.Retry)
                    {
                        retry();
                    }
                }
                
            }
        }

        

        private void start_Click(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                MessageBox.Show("名稱不能為空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if(userName.Text.Length < 3 || userName.Text.Length > 10)
            {
                MessageBox.Show("名稱不和格式（>=3 && <=10）", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                for (int i = 1; i <= 16;)
                {
                    int number = r.Next(16) + 1;

                    if (already[number] == 0)
                    {
                        b[i] = new Button();
                        b[i].SetBounds(90 * ((i - 1) / 4) + 30, 80 * (i % 4) + 40, 68, 78);

                        ima[i] = (number + 1) / 2;
                        b[i].Enabled = true;
                        b[i].Click += new EventHandler(B_click);
                        b[i].Image = Image.FromFile(@"images\card.jpg");
                        b[i].Name = i.ToString();
                        page1.Controls.Add(b[i]);
                        already[number] = i++;
                    }
                }
                start.Enabled = false;
                userName.Enabled = false;
                grade = 100;
                score = 0;
            }
        }


        private void going_Click(object sender, EventArgs e)
        {
            going.Enabled = false;
            b[first].Image = Image.FromFile(@"images\card.jpg");
            b[second].Image = Image.FromFile(@"images\card.jpg");
            choice = 0;
        }

        private void again_Click(object sender, EventArgs e)
        {
            retry();
        }


        private void leave_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("確定要離開遊戲嗎？", "離開遊戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (d == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void point_Click(object sender, EventArgs e)
        {

        }

        private void retry()
        {
            for (int i = 1; i < 17; i++)
            {
                page1.Controls.Remove(b[i]);
                already[i] = 0;
            }

            start.Enabled = true;
            userName.Enabled = true;
            going.Enabled = false;
            grade = 100;
            point.Text = grade.ToString();
            userName.Text = "";
            score = 0;
        }
    }
}
