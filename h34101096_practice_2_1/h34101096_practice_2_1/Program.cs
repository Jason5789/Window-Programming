using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h34101096_practice_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int play = 1;
            int number, day, start, end;
            int con1,con2, point;
            string enter1, enter2, classno;
            string[,] timetable = new string[8,7];

            do
            {
                Console.WriteLine("(1)新增課程 (2)刪除課程 (3)列印課表 (4)計算學分 (5)離開程式");
                Console.Write("請輸入數字選擇功能: ");
                number = int.Parse(Console.ReadLine());

                if (number == 1)
                {
                    con1 = 1;
                    Console.WriteLine("請輸入要加入的課程，格式為<課程代號 星期 開始節 結束節>");
                    enter1 = Console.ReadLine();

                    string[] input = enter1.Split(' ');

                    classno = input[0];
                    day = Convert.ToInt32(input[1]);
                    start = Convert.ToInt32(input[2]);
                    end = Convert.ToInt32(input[3]);

                    for (int i = start; i <= end; i++)
                    {
                        if (timetable[i-1,day-1] != null)
                        {
                            Console.WriteLine("課程衝堂!");
                            con1 = 0;
                            break;
                        }
                    }

                    if (con1 == 1)
                    {
                        foreach(string name in timetable)
                        {
                            if (name == classno)
                            {
                                Console.WriteLine("課程重複!");
                                con1 = 0;
                                break;
                            }
                        }
                    }

                    if (con1 == 1)
                    {
                        for (int i = start; i <= end; i++)
                        {
                            timetable[i-1, day-1] = classno;
                        }
                        Console.WriteLine("成功加入課程!");
                    }
                    
                }

                if (number == 2)
                {
                    con2 = 1;
                    Console.Write("請輸入要要刪除的課程代號:");
                    enter2 = Console.ReadLine();

                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (timetable[i, j] == enter2)
                            {
                                timetable[i, j] = null;
                                con2 = 0;
                            }
                        }
                    }

                    if (con2 == 0)
                    {
                        Console.WriteLine("成功刪除課程: {0}",enter2);
                    }
                    else
                    {
                        Console.WriteLine("課程 {0} 不在課表中",enter2);
                    }

                }

                if (number == 3)
                {
                    String table = String.Format("{0,-6}{1,-6}{2,-6}{3,-6}{4,-6}{5,-6}{6,-6}{7,-6}","","Sun","Mon","Tue","Wed","Thu","Fri","Sat");
                    for(int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (j == 0)
                            {
                                table += String.Format("\n{0,-6}", i + 1);
                            }
                            table += String.Format("{0,-6}", timetable[i, (j + 6) % 7]);
                        }
                    }

                    Console.WriteLine(table);
                }

                if (number == 4)
                {
                    point = 56;

                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (timetable[i, j] == null)
                            {
                                point--;
                            }
                        }
                    }

                    Console.WriteLine(point);
                }

                if (number == 5)
                {
                    play = 0;
                }

                Console.WriteLine();
            } while (play == 1);
        }
    }
}
