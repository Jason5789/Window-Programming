using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace h34101096_practice_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Image = Image.FromFile(@"...\Debug\quarternote.png");
            radioButton2.Image = Image.FromFile(@"...\Debug\quavers.png");
            comboBox1.SelectedIndex = 0;
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
            button5.BackColor = Color.LightGray;
            button6.BackColor = Color.LightGray;
            button7.BackColor = Color.LightGray;
            button8.BackColor = Color.LightGray;
            button11.BackColor = Color.LightGray;
            button12.BackColor = Color.LightGray;
        }


        
        
        int choose = 4;
        int style = 1;
        int sound = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            style = 1;
            double k = trackBar1.Value * style / 60.0;
            double j = 1000.0 / k;
            timer1.Interval = Convert.ToInt32(j);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            style = 2;
            double k = trackBar1.Value * style / 60.0;
            double j = 1000.0 / k;
            timer1.Interval = Convert.ToInt32(j);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            bpm.Text = trackBar1.Value.ToString() + " BPM";
            double k = trackBar1.Value * style / 60.0;
            double j = 1000.0 / k;
            timer1.Interval = Convert.ToInt32(j);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                choose = 4;
                reset();
                button11.Visible = true;
                button12.Visible = true;

                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                
            }
            else
            {
                choose = 8;
                reset();
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;

                button11.Visible = false;
                button12.Visible = false;
                
            }
            double k = trackBar1.Value * style / 60.0;
            double j = 1000.0 / k;
            timer1.Interval = Convert.ToInt32(j);
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (start.Text == "Start")
            {
                start.Text = "Stop";

                if (radioButton1.Checked == true)
                {
                    style = 1;
                }
                else
                {
                    style = 2;
                }

                timer1.Enabled = true;

                double k = trackBar1.Value * style / 60.0;
                double j = 1000.0 / k;
                timer1.Interval = Convert.ToInt32(j);
            }
            else
            {
                start.Text = "Start";
                timer1.Enabled = false;
            }
        }

        private void reset()
        {
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button3.BackColor = Color.LightGray;
            button4.BackColor = Color.LightGray;
            button5.BackColor = Color.LightGray;
            button6.BackColor = Color.LightGray;
            button7.BackColor = Color.LightGray;
            button8.BackColor = Color.LightGray;
            button11.BackColor = Color.LightGray;
            button12.BackColor = Color.LightGray;
        }

        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer player1 = new SoundPlayer();
            String filename1 = @"ding.wav";
            player1.SoundLocation = filename1;
            player1.Load();

            SoundPlayer player2 = new SoundPlayer();
            String filename2 = @"dong.wav";
            player2.SoundLocation = filename2;
            player2.Load();

            
            SoundPlayer player3 = new SoundPlayer();
            String filename3 = @"doo.wav";
            player3.SoundLocation = filename3;
            player3.Load();

            if (style == 1 && choose == 4)
            {
                if (sound % 4 == 0)
                {
                    player1.Play();
                    reset();
                    button1.BackColor = Color.LightGreen;
                }
                else if (sound % 4 == 1)
                {
                    player2.Play();
                    reset();
                    button11.BackColor = Color.LightGreen;
                }
                else if (sound % 4 == 2)
                {
                    player2.Play();
                    reset();
                    button12.BackColor = Color.LightGreen;
                }
                else if (sound % 4 == 3)
                {
                    player2.Play();
                    reset();
                    button8.BackColor = Color.LightGreen;
                }
                sound++;
            }
            else if (style == 1 && choose == 8)
            {
                if (sound % 8 == 0)
                {
                    player1.Play();
                    reset();
                    button1.BackColor = Color.LightGreen;
                }
                else if (sound % 8 == 1)
                {
                    player2.Play();
                    reset();
                    button2.BackColor = Color.LightGreen;
                }
                else if (sound % 8 == 2)
                {
                    player2.Play();
                    reset();
                    button3.BackColor = Color.LightGreen;
                }
                else if (sound % 8 == 3)
                {
                    player2.Play();
                    reset();
                    button4.BackColor = Color.LightGreen;
                }
                else if (sound % 8 == 4)
                {
                    player2.Play();
                    reset();
                    button5.BackColor = Color.LightGreen;
                }
                else if (sound % 8 == 5)
                {
                    player2.Play();
                    reset();
                    button6.BackColor = Color.LightGreen;
                }
                else if (sound % 8 == 6)
                {
                    player2.Play();
                    reset();
                    button7.BackColor = Color.LightGreen;
                }
                else if (sound % 8 == 7)
                {
                    player2.Play();
                    reset();
                    button8.BackColor = Color.LightGreen;
                }
                sound++;
            }
            else if (style == 2 && choose == 4)
            {
                if (sound % 8 == 0)
                {
                    player1.Play();
                    reset();
                    button1.BackColor = Color.LightGreen;
                }
                else if (sound % 8 == 1)
                {
                    player3.Play();
                }
                else if (sound % 8 == 2)
                {
                    player2.Play();
                    reset();
                    button11.BackColor = Color.LightGreen;
                }
                else if (sound % 8 == 3)
                {
                    player2.Play();
                }
                else if (sound % 8 == 4)
                {
                    player2.Play();
                    reset();
                    button12.BackColor = Color.LightGreen;
                }
                else if (sound % 8 == 5)
                {
                    player2.Play();
                }
                else if (sound % 8 == 6)
                {
                    player2.Play();
                    reset();
                    button8.BackColor = Color.LightGreen;
                }
                else if (sound % 8 == 7)
                {
                    player2.Play();
                }
                sound++;
            }
            else if (style == 2 && choose == 8)
            {
                if (sound % 16 == 0)
                {
                    player1.Play();
                    reset();
                    button1.BackColor = Color.LightGreen;
                }
                else if (sound % 16 == 2)
                {
                    player2.Play();
                    reset();
                    button2.BackColor = Color.LightGreen;
                }
                else if (sound % 16 == 4)
                {
                    player2.Play();
                    reset();
                    button3.BackColor = Color.LightGreen;
                }
                else if (sound % 16 == 6)
                {
                    player2.Play();
                    reset();
                    button4.BackColor = Color.LightGreen;
                }
                else if (sound % 16 == 8)
                {
                    player2.Play();
                    reset();
                    button5.BackColor = Color.LightGreen;
                }
                else if (sound % 16 == 10)
                {
                    player2.Play();
                    reset();
                    button6.BackColor = Color.LightGreen;
                }
                else if (sound % 16 == 12)
                {
                    player2.Play();
                    reset();
                    button7.BackColor = Color.LightGreen;
                }
                else if (sound % 16 == 14)
                {
                    player2.Play();
                    reset();
                    button8.BackColor = Color.LightGreen;
                }
                else if (sound % 16 == 1)
                {
                    player3.Play();
                }
                else
                {
                    player2.Play();
                }
                sound++;
            }

        }
    }
}
