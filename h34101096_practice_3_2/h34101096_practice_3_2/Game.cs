using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h34101096_practice_3_2
{
    class Game
    {
        private int one;
        private int two;
        private int three;
        private int turn;
        private int who;
        private int end;
        private string move;
        private string ans1;
        private string ans2;
        private string ans3;

        public Game()
        {
            one = 0;
            two = 0;
            three = 0;
            turn = 0;
            who = 0;
            ans1 = "1\n1\n1\n";
            ans2 = "2\n2\n2\n";
            ans3 = "3\n3\n3\n";
        }


        public void testInput(string s)
        {
            if (s != "" && s.IndexOf(' ') != 0 && s.IndexOf("  ") == -1)
            {
               String[] number = s.Split(' ');

                if (number.Length <= 4)
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                        switch (number[i])
                        {
                            case "1":
                                one++;
                                break;
                            case "2":
                                two++;
                                break;
                            case "3":
                                three++;
                                break;
                            default:
                                break;
                        }
                    }
                }
                
            }
            
        }


        public int input()
        {
            if (one == 3 && two == 3 && three == 3)
            {
                one = 0;
                two = 0;
                three = 0;
                return 0;
            }
            else
            {
                one = 0;
                two = 0;
                three = 0;
                return -1;
            }
        }

        public string inLabel(string s)
        {
            if (s != "")
            {
                String[] number = s.Split(' ');
                string result = "";


                for (int i = number.Length-1; i >= 0; i--)
                {
                    result += number[i] + "\n";
                }

                return result;
            }
            else
            {
                return "";
            }

        }


        public int getTurn()
        {
            return (turn++)%2;
        }

        public void setMove(string s,int w)
        {
            move = s.Substring(0, 2);
            who = w;
        }

        public string getMove()
        {
            return move;
        }
        
        public int getWho()
        {
            return who;
        }

        public bool win(string s1,string s2,string s3,string s4)
        {
            end = 0;
            if (s1==ans1||s2 == ans1 || s3 == ans1 || s4 == ans1)
            {
                end++;
            }
            if (s1 == ans2 || s2 == ans2 || s3 == ans2 || s4 == ans2)
            {
                end++;
            }
            if (s1 == ans3 || s2 == ans3 || s3 == ans3 || s4 == ans3)
            {
                end++;
            }

            if (end == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
