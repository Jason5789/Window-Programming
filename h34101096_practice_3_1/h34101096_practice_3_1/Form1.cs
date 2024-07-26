using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h34101096_practice_3_1
{
    public partial class Form1 : Form
    {
        List<string> listname = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (change.Text == "新增或刪除")
            {
                txtsearch.Visible = false;
                txtsearch.Enabled = false;
                search.Enabled = false;
                label2.Visible = false;
                label3.Visible = false;
                result.Visible = false;
                risk.Enabled = false;
                change.Text = "回主畫面";

                state.Text = "我是狀態列";
                state.Visible = true;
                address.Visible = true;
                name.Visible = true;
                password.Visible = true;
                txtaddress.Visible = true;
                txtuser.Visible = true;
                txtpassword.Visible = true;
                state.Enabled = true;
                address.Enabled = true;
                name.Enabled = true;
                password.Enabled = true;
                txtaddress.Enabled = true;
                txtuser.Enabled = true;
                txtpassword.Enabled = true;
                add.Visible = true;
                add.Enabled = true;
                delete.Visible = true;
                delete.Enabled = true;

                txtsearch.Text = "";
                result.Text = "";
            }
            else
            {
                txtsearch.Visible = true;
                txtsearch.Enabled = true;
                search.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                result.Visible = true;
                risk.Enabled = true;
                change.Text = "新增或刪除";

                state.Visible = false;
                address.Visible = false;
                name.Visible = false;
                password.Visible = false;
                txtaddress.Visible = false;
                txtuser.Visible = false;
                txtpassword.Visible = false;
                state.Enabled = false;
                address.Enabled = false;
                name.Enabled = false;
                password.Enabled = false;
                txtaddress.Enabled = false;
                txtuser.Enabled = false;
                txtpassword.Enabled = false;
                add.Visible = false;
                add.Enabled = false;
                delete.Visible = false;
                delete.Enabled = false;

                txtaddress.Text = "";
                txtuser.Text = "";
                txtpassword.Text = "";
            }
            
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            int k = 0;
            int c = 0;
            foreach (string a in listname)
            {
                if (a==txtaddress.Text && k % 3 == 0)
                {
                    state.Text = "帳號已存在";
                    c = 1;
                    k++;
                }
                else
                {
                    k++;
                }
            }

            if (c == 0)
            {
                listname.Add(txtaddress.Text);
                listname.Add(txtuser.Text);
                listname.Add(txtpassword.Text);

                state.Text = "新增完成";

                txtaddress.Clear();
                txtuser.Clear();
                txtpassword.Clear();
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int c = 0;
            int k = 0;
            int j = 0;
            foreach (string ab in listname)
            {
                if (ab == txtaddress.Text && k % 3 == 0)
                {
                    c=1;
                    j = k / 3;
                    k++;
                }
                else if (ab == txtuser.Text && k % 3 == 1 && c==1 && j == k / 3)
                {
                    c=2;
                    k++;
                }
                else if (ab == txtpassword.Text && k % 3 == 2 && c== 2 && j == k / 3)
                {
                    c=3;
                    k++;
                }
                else
                {
                    k++;
                }
            }

            if (c != 3)
            {
                state.Text = "帳號不存在或密碼錯誤";
            }
            else
            {
                listname.Remove(txtaddress.Text);
                listname.Remove(txtuser.Text);
                listname.Remove(txtpassword.Text);
                state.Text = "刪除完成";

                txtaddress.Clear();
                txtuser.Clear();
                txtpassword.Clear();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            string ans = "";
            int i = 0;
            if (txtsearch.Text == "")
            {
                foreach (string a in listname)
                {
                    if (i % 3 == 0)
                    {
                        ans = ans + "連結: " + a;
                        i++;
                    }
                    else if (i % 3 == 1)
                    {
                        ans = ans + "\n使用者: " + a;
                        i++;
                    }
                    else
                    {
                        ans = ans + "\n密碼: " + a + "\n===========================================\n";
                        i++;
                    }
                }
                result.Text = ans;
            }
            else
            {
                int c = 0;
                foreach (string a in listname)
                {
                    if (a.Contains(txtsearch.Text)||c!=0)
                    {
                        c++;
                        if (c % 3 == 1)
                        {
                            ans = ans + "連結: " + a;
                        }
                        else if (c % 3 == 2)
                        {
                            ans = ans + "\n使用者: " + a;
                        }
                        else
                        {
                            ans = ans + "\n密碼: " + a + "\n===========================================\n";
                            c = 0;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
                result.Text = ans;   
            }
                
        }

        private void risk_Click(object sender, EventArgs e)
        {
            int i = 0;
            int z = 1;
            string s = "";
            string ans = "";

            foreach (string a in listname)
            {
                if (i % 3 == 0)
                {
                    s = "";
                    s = "連結: " + a;
                    i++;
                }
                else if (i % 3 == 1)
                {
                    s = s + "\n使用者: " + a;
                    i++;
                }
                else
                {
                    s = s + "\n密碼: " + a + "\n===========================================\n";
                    i++;
                    int y = 0;
                    foreach (string b in listname)
                    {
                        if (y % 3 == 2 && (i != y + 1)&&a == b && z==1)
                        {
                            ans += s;
                            y++;
                            z = 0;
                        }
                        else
                        {
                            y++;
                        }
                    }
                    z = 1;
                }
            }
            result.Text = ans;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
