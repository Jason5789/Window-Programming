using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h34101096_practice_7_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public bool enter = false;
        public string input;

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            if (newthing.Text == "")
            {
                MessageBox.Show("請輸入事項");
            }
            else
            {
                this.enter = true;
                this.input = newthing.Text;
                this.Close();
            }

            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Enabled = true;
        }
    }
}
