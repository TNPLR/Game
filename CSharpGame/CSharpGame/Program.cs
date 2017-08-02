using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
                        Console.WriteLine("-> 新遊戲");
                        Console.WriteLine("   讀取遊戲");
                        Console.WriteLine("   離開遊戲");
                        break;
                    case 1:
                        Console.WriteLine("   新遊戲");
                        Console.WriteLine("-> 讀取遊戲");
                        Console.WriteLine("   離開遊戲");
                        break;
                    case 2:
                        Console.WriteLine("   新遊戲");
                        Console.WriteLine("   讀取遊戲");
                        Console.WriteLine("-> 離開遊戲");
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
            else if (choose == 1)
            {
                
            }
        }
        static void Newgame()
        {
            status now = new status(2099, 12, 31, 17, 1, "UTC+8", "新北市淡水區");
            firsttalk(ref now);
            now.setstatus(2100, 1, 1, 0, 0, "UTC+0", "安卡地加州");
            secondtalk(ref now);
            
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
        static void firsttalk(ref status now)
        {
            Console.Clear();
            foreach (char chars in "旗亞夫斯基今天到淡水遊玩，\n在淡水老街吃了道地名產「阿給」。\n當旗亞夫斯基陶醉在老街的懷舊時，\n突然被一群不明的黑衣男子抓走，\n他們迅速的將旗亞夫斯基抓到小艇上後，\n小艇便以高速往前推進。\n不久，\n小艇闖進了一個很大的涵洞，\n深處有個亮光，\n沉沉睡去。\n小艇衝進了另一個世界……")
            {                
                Console.Write(chars);
                Thread.Sleep(100);
                if (chars == '\0') break;
            }
            
            /*
            Console.WriteLine("旗亞夫斯基今天到淡水遊玩，");
            Thread.Sleep(1000);
            Console.WriteLine("在淡水老街吃了道地名產「阿給」。");
            Thread.Sleep(1000);
            Console.WriteLine("當旗亞夫斯基陶醉在老街的懷舊時，");
            Thread.Sleep(3000);
            Console.WriteLine("突然被一群不明的黑衣男子抓走，");
            Thread.Sleep(3000);
            Console.WriteLine("他們迅速的將旗亞夫斯基抓到小艇上後，");
            Thread.Sleep(3000);
            Console.WriteLine("小艇便以高速往前推進。");
            Thread.Sleep(3000);
            Console.WriteLine("不久，");
            Thread.Sleep(3000);
            Console.WriteLine("小艇闖進了一個很大的涵洞，");
            Thread.Sleep(3000);
            Console.WriteLine("深處有個亮光，");
            Thread.Sleep(3000);
            Console.WriteLine("旗亞夫斯基開始感到頭暈，");
            Thread.Sleep(3000);
            Console.WriteLine("沉沉睡去。");
            Thread.Sleep(3000);
            Console.WriteLine("小艇衝進了另一個世界……");
            */
            presskeycontinue();
        }
        static void secondtalk(ref status now)
        {
            talk(now, "旗亞夫斯基緩緩的張開眼睛，心裡想著", "「我在哪裡？」");
            talk(now, "旗亞夫斯基往右看", "「這個似乎是一臺機器，上面的控制按鈕在閃動。」");
            talk(now, "", "「這個不就是所謂的軍用雷達？」");
            talk(now, "旗亞夫斯基慢慢的走出幽暗的小房間，突然聽見一個巨大的聲響", "「轟～轟～轟～」");
            talk(now, "", "「Wt？這聲音好大！好像是飛機聲欸欸。」");
            talk(now, "", "「蹦！！！」");
            talk(now, "旗亞夫斯基", "「怎麼了？怎麼了？」");
            talk(now, "遠方傳出廣播", "「（空襲警報音效）（空襲警報音效）」");
            talk(now, "廣播聲", "「空襲警報！空襲警報！敵軍投射炸彈，基地北方100公尺處，全員就位！」");
            talk(now, "廣播聲", "「重複一遍，敵軍投射炸彈，基地北方100公尺處，全員就位！」");
            talk(now, "旗亞夫斯基轉身躲在角落", "「什麼空襲警報？現在到底發生了什麼事！？」");
            talk(now, "一顆砲彈突然打在小房間附近，衝擊力讓小房間的一半倒塌，", "「轟隆隆！！！」");
            talk(now, "一陣混亂中，旗亞夫斯基為了保命，衝向一小臺戰鬥機", "「以前我曾是空軍的特種部隊，雖然事隔多年，至少我還會一些戰機操控技術。」");
            plane planea = new plane("enemy", 0, 0, 0, 0, 0, 15, 3);
            plane planeb = new plane("myplane", 0, 0, 0, 0, 0, 15, 15);
            planeb.me = true;
            List<Transportation> list = new List<Transportation>();
            missile missileA = new missile(0, 2, 0, 0, 0, -1, -1);

            list.Add(planeb);
            list.Add(planea);

            radarA(list);
            list.Add(missileA);
            int count = 0;
            for (;;)
            {

                if (count > 0)
                {
                    Console.WriteLine("彈藥裝填中");
                    Thread.Sleep(1000);
                    count--;
                }
                else
                {
                    int cmd = 0;

                    Console.Write("Angle 0 ~ 359: ");
                    cmd = Convert.ToInt32(Console.ReadLine());
                    missileA.isflying = true;
                    missileA.heading = cmd;
                    list[2].latitude = list[0].latitude;
                    list[2].longitude = list[0].longitude;
                    count = 10;
                }
                missileA.fly();
                if (missileA.longitude == planea.longitude & missileA.latitude == planea.latitude)
                {
                    list.RemoveAt(2);
                    list.RemoveAt(1);
                    radarA(list);
                    Console.WriteLine("你擊敗了飛機");
                    break;
                }
                if (list[2].longitude < 0 | list[2].latitude < 0 | list[2].longitude > 30 | list[2].latitude > 30)
                {
                    list[2].latitude = -1;
                    list[2].longitude = -1;
                    list[2].isflying = false;
                }
                radarA(list);
            }
            Console.ReadKey();
        }
        static void radarA(List<Transportation> listofplane)
        {           
            Console.Clear();
            List<double> planesx = new List<double>();
            List<double> planesy = new List<double>();
            for (int a = 0; a < listofplane.Count; a++)
            {
                planesx.Add(listofplane[a].longitude);
            }
            for (int a = 0; a < listofplane.Count; a++)
            {
                planesy.Add(listofplane[a].latitude);
            }
            string tmpstring = "";
            string statusstring = "編號\t\t類型\t\t敵我\n";
            for (int tmp = 0; tmp < 30; tmp++)
            {
                for(int j = 0; j < 30; j++)
                {
                    bool flynow = true;
                    string planetype = "";
                    bool continuecheck = false;
                    int planeNo = -1;
                    for(int k = 0; k < listofplane.Count; k++)
                    {
                        if (planesx[k] == j & planesy[k] == tmp)
                        {
                            planeNo = k + 1;
                            planetype = listofplane[k].name;
                            flynow = listofplane[k].isflying;
                            continuecheck = true;
                        }
                    }
                    if(continuecheck == true)
                    {
                        if (planetype == "myplane")
                        {
                            tmpstring += "A" + planeNo;
                            statusstring += "A" + planeNo + "\t\t" + "飛機\t\t" + "友軍\n";
                        }
                        else if (planetype == "missile")
                        {
                            if (flynow)
                            {
                                tmpstring += " *";
                            }
                            else
                            {
                                tmpstring += " .";
                            }
                        }
                        else
                        {
                            tmpstring += "?" + planeNo;
                            statusstring += "?" + planeNo + "\t\t" + "不明\t\t" + "不明\n";
                        }
                        
                    }    
                    else
                    {
                        tmpstring += " .";
                    }
                }
                tmpstring += "\n";
            }
            Console.Write(tmpstring);
            Console.Write(statusstring);
        }
    }
}
