using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int choose = 0;
            ConsoleKey a;
            do
            {
                Console.WindowHeight = 40;
                Console.WindowWidth = 100;
                Console.Clear();
                Console.WriteLine("  ███  █    █    ██    ████        ██      ██    █      █    ███\n█        █    █  █    █     █         █        █    █  ██  ██  █\n  ██    ████  █    █     █         █  ██  █    █  █  █  █  ████\n      █  █    █  █    █     █         █    █  ████  █  █  █  █\n███    █    █    ██       █           ██    █    █  █  █  █    ███   -Version 0.1");
                switch (choose)
                {
                    case 0:
                        Console.WriteLine("-> New Game");
                        Console.WriteLine("   Load Game");
                        Console.WriteLine("   Quit Game");
                        break;
                    case 1:
                        Console.WriteLine("   New Game");
                        Console.WriteLine("-> Load Game");
                        Console.WriteLine("   Quit Game");
                        break;
                    case 2:
                        Console.WriteLine("   New Game");
                        Console.WriteLine("   Load Game");
                        Console.WriteLine("-> Quit Game");
                        break;
                }

                a = Console.ReadKey().Key;
                if (a == ConsoleKey.DownArrow)
                {
                    choose++;
                }
                if (a == ConsoleKey.UpArrow)
                {
                    choose--;
                }
                if (choose < 0)
                {
                    choose = 2;
                }
                if (choose > 2)
                {
                    choose = 0;
                }
            } while (a != ConsoleKey.Enter);
            if (choose == 0)
            {
                Newgame();
            }
        }
        static void Newgame()
        {
            status now = new status(2100, 1, 1, 0, 0, "UTC+0", "南極洲");
            firsttalk(now);
            radar();
        }
        static void printdate(int year, int month, int day)
        {
            Console.WriteLine("日期：{0}年{1}月{2}日", year, month, day);
        }
        static void printtime(int hour, int minute)
        {
            Console.WriteLine("時間：{0}時{1}分", hour, minute);
        }
        static void presskeycontinue()
        {
            Console.WriteLine("按任意鍵繼續");
            Console.ReadKey();
        }
        static void jumpconsole(int lines)
        {
            for (int a = 0; a < lines; a++)
            {
                Console.WriteLine();
            }
        }
        static void talk(status now, string man, string input)
        {
            Console.Clear();
            printdate(now.year, now.month, now.day);
            printtime(now.hour, now.minute);
            Console.WriteLine("地點：{0}", now.place);
            jumpconsole(33);
            if (man.Equals(""))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0}：", man);
            }
            Console.WriteLine("\t{0}", input);
            presskeycontinue();
        }
        static void firsttalk(status now)
        {
            Console.Clear();
            Console.WriteLine("Game starting...");
            
            talk(now, "旗亞夫斯基", "我在哪裡？");
            talk(now, "旗亞夫斯基", "這裡怎麼有一台機器？");
            talk(now, "旗亞夫斯基", "上面有光點在動！");
            talk(now, "", "嗡～嗡～嗡～");
            talk(now, "旗亞夫斯基", "這好像是飛機聲");
            talk(now, "旗亞夫斯基", "原來這是台雷達");
            talk(now, "", "轟～轟～轟～");
            talk(now, "旗亞夫斯基", "他丟炸彈下來了！");
            talk(now, "旗亞夫斯基", "旁邊有個大砲，趕快把那死飛機炸了");
        }
        static void radar()
        {

        }
    }
}
