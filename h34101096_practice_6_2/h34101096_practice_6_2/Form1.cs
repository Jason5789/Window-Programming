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

namespace h34101096_practice_6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        int press = 0;

        private void press1()
        {
            media1.URL = @"697.mp3";
            media2.URL = @"1209.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "1";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }
        private void press2()
        {
            media1.URL = @"697.mp3";
            media2.URL = @"1336.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "2";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }
        private void press3()
        {
            media1.URL = @"697.mp3";
            media2.URL = @"1477.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "3";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }
        private void press4()
        {
            media1.URL = @"770.mp3";
            media2.URL = @"1209.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "4";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }
        private void press5()
        {
            media1.URL = @"770.mp3";
            media2.URL = @"1336.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "5";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }
        private void press6()
        {
            media1.URL = @"770.mp3";
            media2.URL = @"1477.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "6";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }
        private void press7()
        {
            media1.URL = @"852.mp3";
            media2.URL = @"1209.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "7";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }
        private void press8()
        {
            media1.URL = @"852.mp3";
            media2.URL = @"1336.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "8";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }
        private void press9()
        {
            media1.URL = @"852.mp3";
            media2.URL = @"1477.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "9";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }
        private void press0()
        {
            media1.URL = @"941.mp3";
            media2.URL = @"1336.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "0";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }

        private void pressleft()
        {
            media1.URL = @"941.mp3";
            media2.URL = @"1209.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "*";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }
        private void pressright()
        {
            media1.URL = @"941.mp3";
            media2.URL = @"1477.mp3";
            media1.Ctlcontrols.play();
            media2.Ctlcontrols.play();
            label1.Text += "#";
            media1.settings.setMode("loop", true);
            media2.settings.setMode("loop", true);
        }

        private void pressphone()
        {
            if (button14.Text == "📱")
            {
                press = 0;
                button14.Text = "📵";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button15.Enabled = false;

                history.Text = history.Text + label1.Text + "\n";
            }
            else
            {
                button14.Text = "📱";
                label1.Text = "Telephone";

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button15.Enabled = true;
            }
        }

        private void up()
        {
            media1.Ctlcontrols.stop();
            media2.Ctlcontrols.stop();
        }

        private void delete()
        {
            if (label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
                
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            press1();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            press2();
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            press3();
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }
        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            press4();
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            press5();
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            press6();
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            press7();
        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            press8();
        }

        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            press9();
        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }
        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            pressleft();
        }

        private void button10_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            press0();
        }

        private void button11_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }

        
        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            pressright();
        }

        private void button12_MouseUp(object sender, MouseEventArgs e)
        {
            up();
            clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pressphone();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            delete();
            clear();
        }

        private void clear()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
        }
        int sw_success = 0;
        private void number_KeyDown(object sender, KeyEventArgs e)
        {
            int sw;
            if (e.Shift == true)
            {
                sw = 1;
            }
            else
            {
                sw = 0;
            }
            if (sw == 1 && tabcontrol.SelectedIndex == 0 && button14.Text == "📱" && sw_success == 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.D8:
                        pressleft();
                        sw_success = 1;
                        break;
                    case Keys.D3:
                        pressright();
                        sw_success = 1;
                        break;
                }
            }
            else if (tabcontrol.SelectedIndex == 0 && button14.Text == "📱" && press == 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    pressphone();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    delete();
                }
                else
                {
                    switch (e.KeyCode)
                    {
                        case Keys.D0:
                            press0();
                            break;
                        case Keys.D1:
                            press1();
                            break;
                        case Keys.D2:
                            press2();
                            break;
                        case Keys.D3:
                            press3();
                            break;
                        case Keys.D4:
                            press4();
                            break;
                        case Keys.D5:
                            press5();
                            break;
                        case Keys.D6:
                            press6();
                            break;
                        case Keys.D7:
                            press7();
                            break;
                        case Keys.D8:
                            press8();
                            break;
                        case Keys.D9:
                            press9();
                            break;
                    }
                } 
            }
            else if(button14.Text == "📵")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    pressphone();
                }
            }

            press = 1;
        }

        private void number_KeyUp(object sender, KeyEventArgs e)
        {
            up();
            press = 0;
            sw_success = 0;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (where.Text == "")
            {
                MessageBox.Show("Empty String");
            }
            else
            {
                FileInfo fileinfo = new FileInfo(where.Text);
                if (fileinfo.Exists == true)
                {
                    StreamWriter steamwriter = new StreamWriter(where.Text);
                    steamwriter.WriteLine(history.Text);
                    steamwriter.Close();
                    MessageBox.Show("Done\n" + fileinfo.FullName);
                }
                else
                {
                    MessageBox.Show("Directory Not Found");
                }
            }
            
        }
    }
}
