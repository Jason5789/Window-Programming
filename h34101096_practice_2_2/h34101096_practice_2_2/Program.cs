using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h34101096_practice_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int round = 0;
            int circle = 0;
            int cross = 0;
            int x, y;
            string put;
            string[,] board = new string[8, 8];
            for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        board[i, j] = "-";
                    }
                }

            do
            {
                Console.Clear();
                String table = String.Format("{0,-2}{1,-2}{2,-2}{3,-2}{4,-2}{5,-2}{6,-2}{7,-2}{8,-2}", "", "A", "B", "C", "D", "E", "F", "G", "H");
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (j == 0)
                        {
                            table += String.Format("\n{0,-2}", i + 1);
                        }
                        table += String.Format("{0,-2}", board[i, j]);
                    }
                }
                Console.WriteLine(table);


                Console.Write("輪到玩家");
                if (round % 2 == 0)
                {
                    Console.Write("O");
                }
                else
                {
                    Console.Write("X");
                }
                Console.WriteLine(" 請輸入要下的位置");
                put = Console.ReadLine();

                switch(put.Substring(0, 1))
                {
                    case "A":
                        y = 0;
                        break;
                    case "B":
                        y = 1;
                        break;
                    case "C":
                        y = 2;
                        break;
                    case "D":
                        y = 3;
                        break;
                    case "E":
                        y = 4;
                        break;
                    case "F":
                        y = 5;
                        break;
                    case "G":
                        y = 6;
                        break;
                    default:
                        y = 7;
                        break;
                }
                x = int.Parse(put.Substring(1, 1)) - 1;

                if (board[x, y] != "-")
                {
                    Console.WriteLine("此位置已有棋子! 按任意鍵繼續遊戲");
                    Console.ReadKey();
                }
                else
                {
                    if (round % 2 == 0)
                    {
                        int con;
                        board[x, y] = "O";
                        circle++;

                        con = 0;
                        for (int i = 0; i < x; i++)
                        {

                            if (board[i, y] == "O")
                            {
                                con = 1;
                            }
                            if (con == 1 && board[i, y] == "X")
                            {
                                board[i, y] = "O";
                                circle++;
                                cross--;
                            }
                        }

                        con = 0;
                        for (int i = 7; i > x; i--)
                        {
                            if (board[i, y] == "O")
                            {
                                con = 1;
                            }
                            if (con == 1 && board[i, y] == "X")
                            {
                                board[i, y] = "O";
                                circle++;
                                cross--;
                            }
                        }

                        con = 0;
                        for (int i = 0; i < y; i++)
                        {
                            if (board[x, i] == "O")
                            {
                                con = 1;
                            }
                            if (con == 1 && board[x, i] == "X")
                            {
                                board[x, i] = "O";
                                circle++;
                                cross--;
                            }
                        }

                        con = 0;
                        for (int i = 7; i > y; i--)
                        {
                            if (board[x, i] == "O")
                            {
                                con = 1;
                            }
                            if (con == 1 && board[x, i] == "X")
                            {
                                board[x, i] = "O";
                                circle++;
                                cross--;
                            }
                        }
                        round++;
                    }
                    else
                    {
                        int con;
                        board[x, y] = "X";
                        cross++;

                        con = 0;
                        for (int i = 0; i < x; i++)
                        {
                                
                            if (board[i, y] == "X")
                            {
                                con = 1;
                            }
                            if (con == 1 && board[i, y] == "O")
                            {
                                board[i, y] = "X";
                                cross++;
                                circle--;
                            }
                        }

                        con = 0;
                        for (int i = 7; i > x; i--)
                        {
                            if (board[i, y] == "X")
                            {
                                con = 1;
                            }
                            if (con == 1 && board[i, y] == "O")
                            {
                                board[i, y] = "X";
                                cross++;
                                circle--;
                            }
                        }

                        con = 0;
                        for (int i = 0; i < y; i++)
                        {
                            if (board[x, i] == "X")
                            {
                                con = 1;
                            }
                            if (con == 1 && board[x, i] == "O")
                            {
                                board[x, i] = "X";
                                cross++;
                                circle--;
                            }
                        }

                        con = 0;
                        for (int i = 7; i > y; i--)
                        {
                            if (board[x, i] == "X")
                            {
                                con = 1;
                            }
                            if (con == 1 && board[x, i] == "O")
                            {
                                board[x, i] = "X";
                                cross++;
                                circle--;
                            }
                        }
                        round++;
                    }
                }
            } while (round < 64);

            Console.Clear();
            String final = String.Format("{0,-2}{1,-2}{2,-2}{3,-2}{4,-2}{5,-2}{6,-2}{7,-2}{8,-2}", "", "A", "B", "C", "D", "E", "F", "G", "H");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0)
                    {
                        final += String.Format("\n{0,-2}", i + 1);
                    }
                    final += String.Format("{0,-2}", board[i, j]);
                }
            }
            Console.WriteLine(final);

            if (circle > cross)
            {
                Console.WriteLine("遊戲結束 玩家O獲勝!");
            }
            if (circle < cross)
            {
                Console.WriteLine("遊戲結束 玩家X獲勝!");
            }

            Console.ReadKey();
        }
    }
}
