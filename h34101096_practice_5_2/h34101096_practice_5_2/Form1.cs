using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h34101096_practice_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] b = new Button[42];
        string[] nowTurn = new string[3] { "戰士", "法師", "遊俠" };
        int[] alive = new int[6] { 1, 1, 1, 1, 1, 1 };
        int sec = 10;
        int player;
        int character = 0;
        int action = 0;
        int who = 0;
        int people;
        Player1_a P1_a=new Player1_a();
        Player1_b P1_b = new Player1_b();
        Player1_c P1_c = new Player1_c();
        Player2_a P2_a = new Player2_a();
        Player2_b P2_b = new Player2_b();
        Player2_c P2_c = new Player2_c();

        private void start_Click(object sender, EventArgs e)
        {
            p2_info.Text = "";
            sec = 10;
            time.Text = sec.ToString();

            timer1.Enabled = true;
            timer1.Interval = 1000;

            start.Enabled = false;
            start.Visible = false;

            now.Enabled = true;
            now.Visible = true;
            time.Enabled = true;
            time.Visible = true;

            p1.Enabled = true;
            p1.Visible = true;
            p1a.Enabled = true;
            p1a.Visible = true;
            p1b.Enabled = true;
            p1b.Visible = true;
            p1c.Enabled = true;
            p1c.Visible = true;

            p2.Visible = true;
            p2.Enabled = true;
            p2a.Visible = true;
            p2b.Visible = true;
            p2c.Visible = true;

            for (int i=0; i < 42; i++)
            {
                b[i] = new Button();
                b[i].SetBounds(50 * (i % 6) + 165, 50 * (i / 6) + 80, 50, 50);
                b[i].Click += new EventHandler(B_click);
                b[i].Name = i.ToString();
                if (i % 6 == 0 || i % 6 == 1 || i % 6 == 2)
                {
                    b[i].Enabled = true;
                }
                else
                {
                    b[i].Enabled = false;
                }

                Controls.Add(b[i]);
            }

            player = 1;
            put(player);
        }

        private void B_click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (character == 1)
            {
                button.Text = "戰士";
                button.BackColor = Color.LightBlue;
                p1a.Enabled = false;
                p1a.Text = "戰士: 0顆";
                character = 0;
            }
            else if (character == 2)
            {
                button.Text = "法師";
                button.BackColor = Color.LightBlue;
                p1b.Enabled = false;
                p1b.Text = "法師: 0顆";
                character = 0;
            }
            else if (character == 3)
            {
                button.Text = "遊俠";
                button.BackColor = Color.LightBlue;
                p1c.Enabled = false;
                p1c.Text = "遊俠: 0顆";
                character = 0;
            }
            else if (character == 4)
            {
                button.Text = "戰士";
                button.BackColor = Color.LightPink;
                p2a.Enabled = false;
                p2a.Text = "戰士: 0顆";
                character = 0;
            }
            else if (character == 5)
            {
                button.Text = "法師";
                button.BackColor = Color.LightPink;
                p2b.Enabled = false;
                p2b.Text = "法師: 0顆";
                character = 0;
            }
            else if (character == 6)
            {
                button.Text = "遊俠";
                button.BackColor = Color.LightPink;
                p2c.Enabled = false;
                p2c.Text = "遊俠: 0顆";
                character = 0;
            }
            else if (action == 1 || action == 3)
            {
                int whichClick = Int32.Parse(button.Name);

                int canAttack = 0;
                int howAttack = 0;


                if (whoisnow() == 0)
                {
                    canAttack = P1_a.atkRange;
                    howAttack = P1_a.atk;
                }
                else if (whoisnow() == 1)
                {
                    canAttack = P1_b.atkRange;
                    howAttack = P1_b.atk;
                }
                else if (whoisnow() == 2)
                {
                    canAttack = P1_c.atkRange;
                    howAttack = P1_c.atk;
                }
                else if (whoisnow() == 3)
                {
                    canAttack = P2_a.atkRange;
                    howAttack = P2_a.atk;
                }
                else if (whoisnow() == 4)
                {
                    canAttack = P2_b.atkRange;
                    howAttack = P2_b.atk;
                }
                else if (whoisnow() == 5)
                {
                    canAttack = P2_c.atkRange;
                    howAttack = P2_c.atk;
                }

                Color c, d;
                if (who % 6 == 0 || who % 6 == 1 || who % 6 == 2)
                {
                    c = Color.LightBlue;
                    d = Color.LightPink;
                }
                else
                {
                    c = Color.LightPink;
                    d = Color.LightBlue;
                }

                int now;
                for (now = 0; now < 42; now++)
                {
                    if (b[now].Text == nowTurn[who % 3] && b[now].BackColor == c)
                    {
                        break;
                    }
                }
                people = whoisnow();
                for (int i = 1; i <= canAttack; i++)
                {
                    if (whichClick - 6 * i >= 0 && whichClick - 6 * i == now && b[whichClick].BackColor == d)
                    {
                        if (b[whichClick].Text == nowTurn[0] && d == Color.LightPink)
                        {
                            P2_a.hp = P2_a.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[1] && d == Color.LightPink)
                        {
                            P2_b.hp = P2_b.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[2] && d == Color.LightPink)
                        {
                            P2_c.hp = P2_c.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[0] && d == Color.LightBlue)
                        {
                            P1_a.hp = P1_a.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[1] && d == Color.LightBlue)
                        {
                            P1_b.hp = P1_b.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[2] && d == Color.LightBlue)
                        {
                            P1_c.hp = P1_c.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                    }
                    else if (whichClick - 1 * i >= 0 && whichClick - 1 * i == now && b[whichClick].BackColor == d)
                    {
                        if (b[whichClick].Text == nowTurn[0] && d == Color.LightPink)
                        {
                            P2_a.hp = P2_a.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[1] && d == Color.LightPink)
                        {
                            P2_b.hp = P2_b.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[2] && d == Color.LightPink)
                        {
                            P2_c.hp = P2_c.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[0] && d == Color.LightBlue)
                        {
                            P1_a.hp = P1_a.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[1] && d == Color.LightBlue)
                        {
                            P1_b.hp = P1_b.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[2] && d == Color.LightBlue)
                        {
                            P1_c.hp = P1_c.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                    }
                    else if (whichClick + 1 * i >= 0 && whichClick + 1 * i == now && b[whichClick].BackColor == d)
                    {
                        if (b[whichClick].Text == nowTurn[0] && d == Color.LightPink)
                        {
                            P2_a.hp = P2_a.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[1] && d == Color.LightPink)
                        {
                            P2_b.hp = P2_b.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[2] && d == Color.LightPink)
                        {
                            P2_c.hp = P2_c.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[0] && d == Color.LightBlue)
                        {
                            P1_a.hp = P1_a.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[1] && d == Color.LightBlue)
                        {
                            P1_b.hp = P1_b.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[2] && d == Color.LightBlue)
                        {
                            P1_c.hp = P1_c.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                    }
                    else if (whichClick + 6 * i >= 0 && whichClick + 6 * i == now && b[whichClick].BackColor == d)
                    {
                        if (b[whichClick].Text == nowTurn[0] && d == Color.LightPink)
                        {
                            P2_a.hp = P2_a.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[1] && d == Color.LightPink)
                        {
                            P2_b.hp = P2_b.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[2] && d == Color.LightPink)
                        {
                            P2_c.hp = P2_c.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[0] && d == Color.LightBlue)
                        {
                            P1_a.hp = P1_a.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[1] && d == Color.LightBlue)
                        {
                            P1_b.hp = P1_b.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (b[whichClick].Text == nowTurn[2] && d == Color.LightBlue)
                        {
                            P1_c.hp = P1_c.hp - howAttack;
                            who++;
                            textinfo();
                            break;
                        }
                    }
                    else if(i == canAttack)
                    {
                        MessageBox.Show("超出攻擊範圍");
                        if (who % 6 == 0 || who % 6 == 1 || who % 6 == 2)
                        {
                            attack1.Enabled = true;
                            move1.Enabled = true;
                            skill1.Enabled = true;
                            wait1.Enabled = true;
                            end1.Enabled = false;

                            attack2.Enabled = false;
                            move2.Enabled = false;
                            skill2.Enabled = false;
                            wait2.Enabled = false;
                            end2.Enabled = false;
                        }
                        else
                        {
                            attack1.Enabled = false;
                            move1.Enabled = false;
                            skill1.Enabled = false;
                            wait1.Enabled = false;
                            end1.Enabled = false;

                            attack2.Enabled = true;
                            move2.Enabled = true;
                            skill2.Enabled = true;
                            wait2.Enabled = true;
                            end2.Enabled = false;
                        }
                    }
                }
            if (P1_a.hp <= 0 && alive[0] == 1)
                {
                    alive[0] = 0;

                    for(int x = 0; x < 42; x++)
                    {
                        if (b[x].Text == nowTurn[0] && b[x].BackColor == Color.LightBlue)
                        {
                            b[x].BackColor = Color.White;
                            b[x].Text = "";
                        }
                    }
                }
                else if (P1_b.hp <= 0 && alive[1] == 1)
                {
                    alive[1] = 0;

                    for (int x = 0; x < 42; x++)
                    {
                        if (b[x].Text == nowTurn[1] && b[x].BackColor == Color.LightBlue)
                        {
                            b[x].BackColor = Color.White;
                            b[x].Text = "";
                        }
                    }
                }
                else if (P1_c.hp <= 0 && alive[2] == 1)
                {
                    alive[2] = 0;

                    for (int x = 0; x < 42; x++)
                    {
                        if (b[x].Text == nowTurn[2] && b[x].BackColor == Color.LightBlue)
                        {
                            b[x].BackColor = Color.White;
                            b[x].Text = "";
                        }
                    }
                }
                else if (P2_a.hp <= 0 && alive[3] == 1)
                {
                    alive[3] = 0;

                    for (int x = 0; x < 42; x++)
                    {
                        if (b[x].Text == nowTurn[0] && b[x].BackColor == Color.LightPink)
                        {
                            b[x].BackColor = Color.White;
                            b[x].Text = "";
                        }
                    }
                }
                else if (P2_b.hp <= 0 && alive[4] == 1)
                {
                    alive[4] = 0;

                    for (int x = 0; x < 42; x++)
                    {
                        if (b[x].Text == nowTurn[1] && b[x].BackColor == Color.LightPink)
                        {
                            b[x].BackColor = Color.White;
                            b[x].Text = "";
                        }
                    }
                }
                else if (P2_c.hp <= 0 && alive[5] == 1)
                {
                    alive[5] = 0;

                    for (int x = 0; x < 42; x++)
                    {
                        if (b[x].Text == nowTurn[2] && b[x].BackColor == Color.LightPink)
                        {
                            b[x].BackColor = Color.White;
                            b[x].Text = "";
                        }
                    }
                }
                textinfo();

            }
            else if (action == 2)
            {
                int whichClick = Int32.Parse(button.Name);

                Color c, d;
                int canMove=0;

                if (whoisnow() == 0)
                {
                    canMove = P1_a.moveRange;
                }
                else if (whoisnow() == 1)
                {
                    canMove = P1_b.moveRange;
                }
                else if (whoisnow() == 2)
                {
                    canMove = P1_c.moveRange;
                }
                else if (whoisnow() == 3)
                {
                    canMove = P2_a.moveRange;
                }
                else if (whoisnow() == 4)
                {
                    canMove = P2_b.moveRange;
                }
                else if (whoisnow() == 5)
                {
                    canMove = P2_c.moveRange;
                }

                if (button.Text == "")
                {
                    if (who % 6 == 0 || who % 6 == 1 || who % 6 == 2)
                    {
                        c = Color.LightBlue;
                    }
                    else
                    {
                        c = Color.LightPink;
                    }
                    for(int i = 1; i <= canMove; i++)
                    {
                        if (whichClick - 6 * i >= 0 && b[whichClick - 6 * i].Text == nowTurn[who % 3] && b[whichClick - 6 * i].BackColor == c)
                        {
                            button.Text = nowTurn[who % 3];
                            b[whichClick - 6 * i].BackColor = button.BackColor;
                            b[whichClick - 6 * i].Text = "";
                            button.BackColor = c;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (whichClick - 1 * i >= 0 && b[whichClick - 1 * i].Text == nowTurn[who % 3] && b[whichClick - 1 * i].BackColor == c)
                        {
                            button.Text = nowTurn[who % 3];
                            b[whichClick - 1 * i].BackColor = button.BackColor;
                            b[whichClick - 1 * i].Text = "";
                            button.BackColor = c;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (whichClick + 1 * i < 42 && b[whichClick + 1 * i].Text == nowTurn[who % 3] && b[whichClick + 1 * i].BackColor == c)
                        {
                            button.Text = nowTurn[who % 3];
                            b[whichClick + 1 * i].BackColor = button.BackColor;
                            b[whichClick + 1 * i].Text = "";
                            button.BackColor = c;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (whichClick + 6 * i < 42 && b[whichClick + 6 * i].Text == nowTurn[who % 3] && b[whichClick + 6 * i].BackColor == c)
                        {
                            button.Text = nowTurn[who % 3];
                            b[whichClick + 6 * i].BackColor = button.BackColor;
                            b[whichClick + 6 * i].Text = "";
                            button.BackColor = c;
                            who++;
                            textinfo();
                            break;
                        }
                        else if (i == canMove)
                        {
                            MessageBox.Show("超出攻擊範圍");
                            if (who % 6 == 0 || who % 6 == 1 || who % 6 == 2)
                            {
                                attack1.Enabled = true;
                                move1.Enabled = true;
                                skill1.Enabled = true;
                                wait1.Enabled = true;

                                attack2.Enabled = false;
                                move2.Enabled = false;
                                skill2.Enabled = false;
                                wait2.Enabled = false;
                            }
                            else
                            {
                                attack1.Enabled = false;
                                move1.Enabled = false;
                                skill1.Enabled = false;
                                wait1.Enabled = false;

                                attack2.Enabled = true;
                                move2.Enabled = true;
                                skill2.Enabled = true;
                                wait2.Enabled = true;
                            }
                        }
                    }
                    
                }
                action = 0;

            }

            if (action == 3 || action == 1)
            {
                if (people == 1)
                {
                    P1_b.atk = 20;
                }
                else if (people == 2)
                {
                    P1_c.atkRange = 3;
                }
                else if (people == 4)
                {
                    P2_b.atk = 20;
                }
                else if (people == 5)
                {
                    P2_c.atkRange = 3;
                }
                action = 0;
                end1.Enabled = false;
                end2.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            time.Text = sec.ToString();

            if (sec == 0 && player == 1)
            {
                put(++player);
                character = 0;
                sec = 10;
                time.Text = sec.ToString();
                initial_player1();
                changePlayer();
            }
            if (sec == 0 && player == 2)
            {
                timer1.Enabled = false;

                character = 0;

                time.Enabled = false;
                time.Visible = false;
                p1a.Enabled = false;
                p1a.Visible = false;
                p1b.Enabled = false;
                p1b.Visible = false;
                p1c.Enabled = false;
                p1c.Visible = false;
                p2a.Enabled = false;
                p2a.Visible = false;
                p2b.Enabled = false;
                p2b.Visible = false;
                p2c.Enabled = false;
                p2c.Visible = false;


                p1_info.Enabled = true;
                p1_info.Visible = true;
                p2_info.Enabled = true;
                p2_info.Visible = true;

                attack1.Enabled = true;
                attack1.Visible = true;
                move1.Enabled = true;
                move1.Visible = true;
                skill1.Enabled = true;
                skill1.Visible = true;
                wait1.Enabled = true;
                wait1.Visible = true;
                end1.Visible = true;

                attack2.Visible = true;
                move2.Visible = true;
                skill2.Visible = true;
                wait2.Visible = true;
                end2.Visible = true;

                for (int i = 0; i < 42; i++)
                {
                    if (b[i].BackColor != Color.LightBlue)
                    {
                        if (b[i].BackColor != Color.LightPink)
                        {
                            b[i].BackColor = Color.White;
                        }
                    }
                    
                }
                initial_player2();
                textinfo();
            }
            
        }

        private void put(int a)
        {
            if (a % 2 == 1)
            {
                p1a.Enabled = true;
                p1b.Enabled = true;
                p1c.Enabled = true;

                p2a.Enabled = false;
                p2b.Enabled = false;
                p2c.Enabled = false;
            }
            else
            {
                p1a.Enabled = false;
                p1b.Enabled = false;
                p1c.Enabled = false;

                p2a.Enabled = true;
                p2b.Enabled = true;
                p2c.Enabled = true; 
            }
        }

        private void changePlayer()
        {
            for (int i = 0; i < 42; i++)
            {
                if (b[i].Enabled == false)
                {
                    b[i].Enabled = true;
                }
                else
                {
                    b[i].Enabled = false;
                }
            }
        }

        private void initial_player1()
        {
            if(p1a.Text != "戰士: 0顆")
            {
                for(int i = 0; i < 7; i++)
                {
                    int a = i * 6;
                    if(b[a].Text == "")
                    {
                        b[a].Text = "戰士";
                        b[a].BackColor = Color.LightBlue;
                        p1a.Enabled = false;
                        p1a.Text = "戰士: 0顆";
                        break;
                    }
                }
            }

            if (p1b.Text != "法師: 0顆")
            {
                for (int i = 0; i < 7; i++)
                {
                    int a = i * 6;
                    if (b[a].Text == "")
                    {
                        b[a].Text = "法師";
                        b[a].BackColor = Color.LightBlue;
                        p1b.Enabled = false;
                        p1b.Text = "法師: 0顆";
                        break;
                    }
                }
            }

            if (p1c.Text != "遊俠: 0顆")
            {
                for (int i = 0; i < 7; i++)
                {
                    int a = i * 6;
                    if (b[a].Text == "")
                    {
                        b[a].Text = "遊俠";
                        b[a].BackColor = Color.LightBlue;
                        p1c.Enabled = false;
                        p1c.Text = "遊俠: 0顆";
                        break;
                    }
                }
            }
        }

        private void initial_player2()
        {
            if (p2a.Text != "戰士: 0顆")
            {
                for (int i = 0; i < 7; i++)
                {
                    int a = i * 6 + 5;
                    if (b[a].Text == "")
                    {
                        b[a].Text = "戰士";
                        b[a].BackColor = Color.LightPink;
                        p2a.Enabled = false;
                        p2a.Text = "戰士: 0顆";
                        break;
                    }
                }
            }

            if (p2b.Text != "法師: 0顆")
            {
                for (int i = 0; i < 7; i++)
                {
                    int a = i * 6 + 5;
                    if (b[a].Text == "")
                    {
                        b[a].Text = "法師";
                        b[a].BackColor = Color.LightPink;
                        p2b.Enabled = false;
                        p2b.Text = "法師: 0顆";
                        break;
                    }
                }
            }

            if (p2c.Text != "遊俠: 0顆")
            {
                for (int i = 0; i < 7; i++)
                {
                    int a = i * 6 + 5;
                    if (b[a].Text == "")
                    {
                        b[a].Text = "遊俠";
                        b[a].BackColor = Color.LightPink;
                        p2c.Enabled = false;
                        p2c.Text = "遊俠: 0顆";
                        break;
                    }
                }
            }

            for (int i = 0; i < 42; i++)
            {
                b[i].Enabled = true;
            }
        }

        private void p1a_Click(object sender, EventArgs e)
        {
            character = 1;
        }

        private void p1b_Click(object sender, EventArgs e)
        {
            character = 2;
        }

        private void p1c_Click(object sender, EventArgs e)
        {
            character = 3;
        }

        private void p2a_Click(object sender, EventArgs e)
        {
            character = 4;
        }

        private void p2b_Click(object sender, EventArgs e)
        {
            character = 5;
        }

        private void p2c_Click(object sender, EventArgs e)
        {
            character = 6;
        }

        private void attack1_Click(object sender, EventArgs e)
        {
            action = 1;
        }

        private void move1_Click(object sender, EventArgs e)
        {
            action = 2;
        }

        private void skill1_Click(object sender, EventArgs e)
        {
            action = 3;
            if (whoisnow() == 0 && P1_a.mp >= 10)
            {
                P1_a.Skill();
                textinfo();
                attack1.Enabled = false;
                move1.Enabled = false;
                skill1.Enabled = false;
                wait1.Enabled = false;

                end1.Enabled = true;
            }
            else if (whoisnow() == 1 && P1_b.mp >= 10)
            {
                P1_b.Skill();
                textinfo();
                attack1.Enabled = false;
                move1.Enabled = false;
                skill1.Enabled = false;
                wait1.Enabled = false;

                end1.Enabled = true;
            }
            else if (whoisnow() == 2 && P1_c.mp >= 10)
            {
                P1_c.Skill();
                textinfo();
                attack1.Enabled = false;
                move1.Enabled = false;
                skill1.Enabled = false;
                wait1.Enabled = false;

                end1.Enabled = true;
            }
            

        }

        private void wait1_Click(object sender, EventArgs e)
        {
            who++;
            textinfo();
        }

        private void end1_Click(object sender, EventArgs e)
        {
            if (who % 6 == 0 || who % 6 == 1 || who % 6 == 2)
            {
                attack1.Enabled = true;
                move1.Enabled = true;
                skill1.Enabled = true;
                wait1.Enabled = true;
                end1.Enabled = false;

                attack2.Enabled = false;
                move2.Enabled = false;
                skill2.Enabled = false;
                wait2.Enabled = false;
                end2.Enabled = false;
            }
            else
            {
                attack1.Enabled = false;
                move1.Enabled = false;
                skill1.Enabled = false;
                wait1.Enabled = false;
                end1.Enabled = false;

                attack2.Enabled = true;
                move2.Enabled = true;
                skill2.Enabled = true;
                wait2.Enabled = true;
                end2.Enabled = false;
            }
        }

        private void attack2_Click(object sender, EventArgs e)
        {
            action = 1;
        }

        private void move2_Click(object sender, EventArgs e)
        {
            action = 2;
        }

        private void skill2_Click(object sender, EventArgs e)
        {
            action = 3;
            if (whoisnow() == 3 && P2_a.mp >= 10)
            {
                P2_a.Skill();
                textinfo();
                attack2.Enabled = false;
                move2.Enabled = false;
                skill2.Enabled = false;
                wait2.Enabled = false;

                end2.Enabled = true;
            }
            else if (whoisnow() == 4 && P2_b.mp >= 10)
            {
                P2_b.Skill();
                textinfo();
                attack2.Enabled = false;
                move2.Enabled = false;
                skill2.Enabled = false;
                wait2.Enabled = false;

                end2.Enabled = true;
            }
            else if (whoisnow() == 5 && P2_c.mp >= 10)
            {
                P2_c.Skill();
                textinfo();
                attack2.Enabled = false;
                move2.Enabled = false;
                skill2.Enabled = false;
                wait2.Enabled = false;

                end2.Enabled = true;
            }
            
        }

        private void wait2_Click(object sender, EventArgs e)
        {
            who++;
            textinfo();
        }

        private void end2_Click(object sender, EventArgs e)
        {
            if (who % 6 == 0 || who % 6 == 1 || who % 6 == 2)
            {
                attack1.Enabled = true;
                move1.Enabled = true;
                skill1.Enabled = true;
                wait1.Enabled = true;
                end1.Enabled = false;

                attack2.Enabled = false;
                move2.Enabled = false;
                skill2.Enabled = false;
                wait2.Enabled = false;
                end2.Enabled = false;
            }
            else
            {
                attack1.Enabled = false;
                move1.Enabled = false;
                skill1.Enabled = false;
                wait1.Enabled = false;
                end1.Enabled = false;

                attack2.Enabled = true;
                move2.Enabled = true;
                skill2.Enabled = true;
                wait2.Enabled = true;
                end2.Enabled = false;
            }
        }

        private void textinfo()
        {
            while (alive[who % 6] == 0)
            {
                who++;
            }

            if (alive[0] == 0 && alive[1] == 0 && alive[2] == 0)
            {
                DialogResult d = MessageBox.Show("P2 贏了");

                if (d == DialogResult.OK)
                {
                    System.Environment.Exit(0);
                }
            }
            else if (alive[3] == 0 && alive[4] == 0 && alive[5] == 0)
            {
                DialogResult d = MessageBox.Show("P1 贏了");

                if (d == DialogResult.OK)
                {
                    System.Environment.Exit(0);
                }
            }

            if (who % 6 == 0 || who % 6 == 1 || who % 6 == 2)
            {
                attack1.Enabled = true;
                move1.Enabled = true;
                skill1.Enabled = true;
                wait1.Enabled = true;

                attack2.Enabled = false;
                move2.Enabled = false;
                skill2.Enabled = false;
                wait2.Enabled = false;

                now.Text = "P1 Turn";
            }
            else
            {
                attack1.Enabled = false;
                move1.Enabled = false;
                skill1.Enabled = false;
                wait1.Enabled = false;

                attack2.Enabled = true;
                move2.Enabled = true;
                skill2.Enabled = true;
                wait2.Enabled = true;

                now.Text = "P2 Turn";
            }

            string s = "";
            if (who % 6 == 0)
            {
                s += nowTurn[who % 3];
                s += "\nHP: " + P1_a.hp + "\nMP: " + P1_a.mp + "\nATK: " + P1_a.atk + "\nATK Range: " + P1_a.atkRange + "\nMOVE Range: " + P1_a.moveRange;
                p1_info.Text = s;
            }
            else if (who % 6 == 1)
            {
                s += nowTurn[who % 3];
                s += "\nHP: " + P1_b.hp + "\nMP: " + P1_b.mp + "\nATK: " + P1_b.atk + "\nATK Range: " + P1_b.atkRange + "\nMOVE Range: " + P1_b.moveRange;
                p1_info.Text = s;
            }
            else if (who % 6 == 2)
            {
                s += nowTurn[who % 3];
                s += "\nHP: " + P1_c.hp + "\nMP: " + P1_c.mp + "\nATK: " + P1_c.atk + "\nATK Range: " + P1_c.atkRange + "\nMOVE Range: " + P1_c.moveRange;
                p1_info.Text = s;
            }
            else if (who % 6 == 3)
            {
                s += nowTurn[who % 3];
                s += "\nHP: " + P2_a.hp + "\nMP: " + P2_a.mp + "\nATK: " + P2_a.atk + "\nATK Range: " + P2_a.atkRange + "\nMOVE Range: " + P2_a.moveRange;
                p2_info.Text = s;
            }
            else if (who % 6 == 4)
            {
                s += nowTurn[who % 3];
                s += "\nHP: " + P2_b.hp + "\nMP: " + P2_b.mp + "\nATK: " + P2_b.atk + "\nATK Range: " + P2_b.atkRange + "\nMOVE Range: " + P2_b.moveRange;
                p2_info.Text = s;
            }
            else if (who % 6 == 5)
            {
                s += nowTurn[who % 3];
                s += "\nHP: " + P2_c.hp + "\nMP: " + P2_c.mp + "\nATK: " + P2_c.atk + "\nATK Range: " + P2_c.atkRange + "\nMOVE Range: " + P2_c.moveRange;
                p2_info.Text = s;
            }
        }

        public int whoisnow()
        {
            return who % 6;
        }

        
    }
}
