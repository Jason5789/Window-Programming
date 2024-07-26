using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h34101096_practice_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int sum = 0;
            int user, moneyIn, end2, end3, end4, end5, end6;
            double takeout = 0.0;
            string[] item = new string[5];
            int[] cost = new int[] { 0, 0, 0, 0, 0 };

            do
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6)查詢支出 (7)剩餘金額 (8)退出程式");
                Console.Write("輸入數字選擇功能: ");

                try
                {
                    user = int.Parse(Console.ReadLine());
                }
                catch
                {
                    user = -1;
                }

                if (user == 1)
                {
                    Console.Write("輸入金額: ");
                    try
                    {
                        moneyIn = int.Parse(Console.ReadLine());
                        if (moneyIn < 0)
                        {
                            Console.WriteLine("收入不可為負數");
                        }
                        else
                        {
                            sum += moneyIn;
                        }
                        
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("請輸入數字");
                    }
                }

                else if (user == 2)
                {
                    for (end2 = 0; end2 < item.Length; end2++)
                    {
                        if (item[end2] == null)
                        {
                            end2--;
                            break;
                        }
                        Console.Write("({0}){1} ", end2 + 1, item[end2]);
                    }

                    if (end2 == -1)
                    {
                        Console.WriteLine("請新增支出項目");
                    }
                    else
                    {
                        Console.Write("\n輸入數字選擇支出項目: ");
                        int number = int.Parse(Console.ReadLine());

                        if (number > end2 + 1 ||  number <= 0)
                        {
                            Console.WriteLine("此數字不在範圍中");
                        }
                        else
                        {
                            Console.Write("輸入金額: ");
                            int money = int.Parse(Console.ReadLine());

                            if (money > sum)
                            {
                                Console.WriteLine("存款不足");
                            }
                            else
                            {
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
                            }

                            
                        }
                    }
                }

                else if (user == 3)
                {
                    
                    if (item[0] != null && item[1] != null && item[2] != null && item[3] != null && item[4] != null)
                    {
                        Console.WriteLine("已無法再新增支出項目");
                    }
                    else
                    {
                        end3 = 1;
                        Console.Write("輸入項目名稱: ");
                        string name = Console.ReadLine();
                        foreach (string word in item)
                        {
                            if (name == word)
                            {
                                Console.WriteLine("支出項目已存在");
                                end3 = 0;
                            }
                        }

                        if (end3 == 1)
                        {
                            for (int i = 0; i < item.Length; i++)
                            {
                                if (item[i] == null)
                                {
                                    item[i] = name;
                                    break;
                                }
                            }
                        }
                    }
                }

                else if (user == 4)
                {
                    if (item[0] == null && item[1] == null && item[2] == null && item[3] == null && item[4] == null)
                    {
                        Console.WriteLine("已無法再刪除支出項目");
                    }
                    else
                    {
                        Console.Write("輸入項目名稱: ");
                        string deleteName = Console.ReadLine();

                        if (deleteName != item[0] && deleteName != item[1] && deleteName != item[2] && deleteName != item[3] && deleteName != item[4])
                        {
                            Console.WriteLine("此項目不存在");
                        }
                        else
                        {
                            for (end4 = 0; end4 < item.Length; end4++)
                            {
                                if (deleteName == item[end4])
                                {
                                    item[end4] = null;
                                    for(int i = end4; i < item.Length-1; i++)
                                    {
                                        item[i] = item[i + 1];
                                        item[i + 1] = null;
                                        cost[i] = cost[i + 1];
                                        cost[i + 1] = 0;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                else if (user == 5)
                {
                    if (takeout != 0)
                    {
                        for (end5 = 0; end5 < item.Length; end5++)
                        {
                            if (item[end5] == null)
                            {
                                break;
                            }
                            Console.WriteLine("{0}: {1}%", item[end5], cost[end5] * 100 / takeout);
                        }
                    }
                    else
                    {
                        end5 = 0;
                        while (item[end5] != null)
                        {
                            Console.WriteLine("{0}: 0%", item[end5++]);
                        }
                    }
                }

                else if (user == 6)
                {
                    Console.WriteLine("目前總支出: {0}", takeout);
                    Console.Write("輸入要查詢的項目: ");
                    string searchName = Console.ReadLine();

                    if (searchName != item[0] && searchName != item[1] && searchName != item[2] && searchName != item[3] && searchName != item[4])
                    {
                        Console.WriteLine("此項目不存在");
                    }
                    else
                    {
                        for (end6 = 0; end6 < item.Length; end6++)
                        {
                            if (searchName == item[end6])
                            {
                                Console.WriteLine("{0}: {1}", item[end6], cost[end6]);
                                break;
                            }
                        }
                    }
                }

                else if (user == 7)
                {
                    Console.WriteLine("剩餘金額為: {0}", sum);
                }

                else if (user == 8)
                {
                    start = 0;
                }

                else
                {
                    Console.WriteLine("請輸入1~8之間的數!");
                }

                Console.WriteLine();
            } while (start == 1);
        }
    }
}
