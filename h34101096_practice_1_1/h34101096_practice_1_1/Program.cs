using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h34101096_practice_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int sum = 0;
            double takeout = 0.0;
            string[] item = new string[] { "食" , "衣" , "住" , "行" , "育樂" };
            int[] cost = new int[] { 0 , 0 , 0 , 0 , 0 };

            do
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)計算比例 (4)剩餘金額 (5)退出程式");
                Console.Write("輸入數字選擇功能: ");
                int user = int.Parse(Console.ReadLine());

                if (user == 1)
                {
                    Console.Write("輸入金額: ");
                    int moneyIn = int.Parse(Console.ReadLine());
                    sum += moneyIn;
                    Console.WriteLine();
                }

                if (user == 2)
                {
                    Console.WriteLine("(1){0} (2){1} (3){2} (4){3} (5){4}" , item[0] , item[1] , item[2] , item[3] , item[4]);
                    Console.Write("輸入數字選擇支出項目: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("輸入金額: ");
                    int money = int.Parse(Console.ReadLine());
                    if (number == 1)
                    {
                        cost[0] += money;
                    }
                    else if (number == 2)
                    {
                        cost[1] += money;
                    }
                    else if (number == 3)
                    {
                        cost[2] += money;
                    }
                    else if (number == 4)
                    {
                        cost[3] += money;
                    }
                    else
                    {
                        cost[4] += money;
                    }
                    sum -= money;
                    takeout += money;
                    Console.WriteLine();
                }

                if (user == 3)
                {
                    if (takeout != 0)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("{0}: {1}%", item[i], cost[i] * 100 / takeout);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("{0}: 0%", item[i]);
                        }
                    }
                    Console.WriteLine();
                }

                if (user == 4)
                {
                    Console.WriteLine("剩餘金額為: {0}", sum);
                    Console.WriteLine();
                }

                if (user == 5)
                {
                    start = 0;
                }
            }while (start == 1);
        }
    }
}