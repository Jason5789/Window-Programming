using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h34101096_practice_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int[] already = new int[17] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int first,second;
        Button[] b = new Button[17];
        Random r = new Random();
        int choice = 0;
        int[] ima = new int[17];
        int score = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

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
                    score++;
                }
                else
                {
                    going.Enabled = true;
                    choice = 0;
                }

                if (score == 8)
                {
                    MessageBox.Show("你贏了!");
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 16;)
            {
                int number = r.Next(16) + 1;

                if (already[number] == 0)
                {
                    b[i] = new Button();
                    b[i].SetBounds(80 * ((i - 1) / 4) + 30, 75 * (i % 4) + 40, 65, 75);

                    ima[i] = (number + 1) / 2;
                    b[i].Enabled = true;
                    b[i].Click += new EventHandler(B_click);
                    b[i].Image = Image.FromFile(@"images\card.jpg");
                    b[i].Name = i.ToString();
                    Controls.Add(b[i]);
                    already[number] = i++;
                }
            }
            start.Enabled = false;
        }

        private void leave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void going_Click(object sender, EventArgs e)
        {
            going.Enabled = false;
            b[first].Image = Image.FromFile(@"images\card.jpg");
            b[second].Image = Image.FromFile(@"images\card.jpg");
            choice = 0;
        }
    }


    


}
