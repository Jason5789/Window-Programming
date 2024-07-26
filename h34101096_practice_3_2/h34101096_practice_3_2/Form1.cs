using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h34101096_practice_3_2
{
    public partial class Form1 : Form
    {
        Game g = new Game();

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void start_Click(object sender, EventArgs e)
        {
           
            g.testInput(text1.Text);
            g.testInput(text2.Text);
            g.testInput(text3.Text);
            g.testInput(text4.Text);

            if(g.input() == 0)
            {
                homeAction.Text = "請輸入測資";
                homeAction.Enabled = false;
                homeAction.Visible = false;
                a1.Enabled = false;
                a1.Visible = false;
                a2.Enabled = false;
                a2.Visible = false;
                a3.Enabled = false;
                a3.Visible = false;
                a4.Enabled = false;
                a4.Visible = false;
                text1.Enabled = false;
                text1.Visible = false;
                text2.Enabled = false;
                text2.Visible = false;
                text3.Enabled = false;
                text3.Visible = false;
                text4.Enabled = false;
                text4.Visible = false;
                start.Enabled = false;
                start.Visible = false;

                this.Height += 150;


                gameAction.Text = "...";
                gameAction.Enabled = true;
                gameAction.Visible = true;
                back.Enabled = true;
                back.Visible = true;
                b1.Enabled = true;
                b1.Visible = true;
                b2.Enabled = true;
                b2.Visible = true;
                b3.Enabled = true;
                b3.Visible = true;
                b4.Enabled = true;
                b4.Visible = true;

                p1.Text = "選取";
                p2.Text = "選取";
                p3.Text = "選取";
                p4.Text = "選取";
                p1.Visible = true;
                p2.Visible = true;
                p3.Visible = true;
                p4.Visible = true;
                label1.Enabled = true;
                label1.Visible = true;
                label2.Enabled = true;
                label2.Visible = true;
                label3.Enabled = true;
                label3.Visible = true;
                label4.Enabled = true;
                label4.Visible = true;

                label1.Text = g.inLabel(text1.Text);
                label2.Text = g.inLabel(text2.Text);
                label3.Text = g.inLabel(text3.Text);
                label4.Text = g.inLabel(text4.Text);
 

                if (label1.Text != "")
                {
                    p1.Enabled = true;
                }
                else
                {
                    p1.Enabled = false;
                }
                if (label2.Text != "")
                {
                    p2.Enabled = true;
                }
                else
                {
                    p2.Enabled = false;
                }
                if (label3.Text != "")
                {
                    p3.Enabled = true;
                }
                else
                {
                    p3.Enabled = false;
                }
                if (label4.Text != "")
                {
                    p4.Enabled = true;
                }
                else
                {
                    p4.Enabled = false;
                }
            }
            else
            {
                homeAction.Text = "測資錯誤";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            homeAction.Enabled = true;
            homeAction.Visible = true;
            a1.Enabled = true;
            a1.Visible = true;
            a2.Enabled = true;
            a2.Visible = true;
            a3.Enabled = true;
            a3.Visible = true;
            a4.Enabled = true;
            a4.Visible = true;
            text1.Enabled = true;
            text1.Visible = true;
            text2.Enabled = true;
            text2.Visible = true;
            text3.Enabled = true;
            text3.Visible = true;
            text4.Enabled = true;
            text4.Visible = true;
            start.Enabled = true;
            start.Visible = true;

            this.Height -= 150;

            gameAction.Enabled = false;
            gameAction.Visible = false;
            back.Enabled = false;
            back.Visible = false;
            b1.Enabled = false;
            b1.Visible = false;
            b2.Enabled = false;
            b2.Visible = false;
            b3.Enabled = false;
            b3.Visible = false;
            b4.Enabled = false;
            b4.Visible = false;
            p1.Enabled = false;
            p1.Visible = false;
            p2.Enabled = false;
            p2.Visible = false;
            p3.Enabled = false;
            p3.Visible = false;
            p4.Enabled = false;
            p4.Visible = false;
            label1.Enabled = false;
            label1.Visible = false;
            label2.Enabled = false;
            label2.Visible = false;
            label3.Enabled = false;
            label3.Visible = false;
            label4.Enabled = false;
            label4.Visible = false;
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void p1_Click(object sender, EventArgs e)
        {
            if (g.getTurn() == 0)
            {
                g.setMove(label1.Text, 1);
                take();
            }
            else
            {
                label1.Text = g.getMove() + label1.Text;
                delete(g.getWho());
            }
        }

        private void p2_Click(object sender, EventArgs e)
        {
            if (g.getTurn() == 0)
            {
                g.setMove(label2.Text, 2);
                take();
            }
            else
            {
                label2.Text = g.getMove() + label2.Text;
                delete(g.getWho());
            }
        }

        private void p3_Click(object sender, EventArgs e)
        {
            if (g.getTurn() == 0)
            {
                g.setMove(label3.Text, 3);
                take();
            }
            else
            {
                label3.Text = g.getMove() + label3.Text;
                delete(g.getWho());
            }
        }

        private void p4_Click(object sender, EventArgs e)
        {
            if (g.getTurn() == 0)
            {
                g.setMove(label4.Text, 4);
                take();
            }
            else
            {
                label4.Text = g.getMove() + label4.Text;
                delete(g.getWho());
            }
        }

        private void delete(int d)
        {
            if(d == 1)
            {
                label1.Text = label1.Text.Remove(0, 2);
                put();
            }
            if (d == 2)
            {
                label2.Text = label2.Text.Remove(0, 2);
                put();
            }
            if (d == 3)
            {
                label3.Text = label3.Text.Remove(0, 2);
                put();
            }
            if (d == 4)
            {
                label4.Text = label4.Text.Remove(0, 2);
                put();
            }

            if (g.win(label1.Text, label2.Text, label3.Text, label4.Text) == true)
            {
                gameAction.Text = "你贏了";

                p1.Enabled = false;
                p2.Enabled = false;
                p3.Enabled = false;
                p4.Enabled = false;

                p1.Text = "贏";
                p2.Text = "贏";
                p3.Text = "贏";
                p4.Text = "贏";
            }
        }

        private void take()
        {
            gameAction.Text = "你選了堆疊" + g.getWho();
            p1.Text = "放置";
            p2.Text = "放置";
            p3.Text = "放置";
            p4.Text = "放置";

            if (label1.Text.Length < 7)
            {
                p1.Enabled = true;
            }
            else
            {
                p1.Enabled = false;
            }

            if (label2.Text.Length < 7)
            {
                p2.Enabled = true;
            }
            else
            {
                p2.Enabled = false;
            }

            if (label3.Text.Length < 7)
            {
                p3.Enabled = true;
            }
            else
            {
                p3.Enabled = false;
            }

            if (label4.Text.Length < 7)
            {
                p4.Enabled = true;
            }
            else
            {
                p4.Enabled = false;
            }

        }

        private void put()
        {
            gameAction.Text = "...";
            p1.Text = "選取";
            p2.Text = "選取";
            p3.Text = "選取";
            p4.Text = "選取";

            if (label1.Text != "")
            {
                p1.Enabled = true;
            }
            else
            {
                p1.Enabled = false;
            }

            if (label2.Text != "")
            {
                p2.Enabled = true;
            }
            else
            {
                p2.Enabled = false;
            }

            if (label3.Text != "")
            {
                p3.Enabled = true;
            }
            else
            {
                p3.Enabled = false;
            }

            if (label4.Text != "")
            {
                p4.Enabled = true;
            }
            else
            {
                p4.Enabled = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
