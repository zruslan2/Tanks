using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WordOfTanks;
using System.IO;

namespace Day7__Tanks_
{
    public class fight
    {
        public static void Fight(bool b, Tank t1, Tank t2)
        {
            Console.SetWindowSize(114, 21);
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            string[] tank_T = new string[14];
            string path = @"t1.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                for (int i = 0; i < 13; i++)
                {
                    tank_T[i] = sr.ReadLine();
                }
            }
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(tank_T[i]);
            }
            Console.SetCursorPosition(0, 16);
            Console.WriteLine(t1.GetName());
            Console.SetCursorPosition(0, 17);
            Console.WriteLine(t1.GetParam());
            string[] tank_P = new string[14];
            string path1 = @"t2.txt";
            using (StreamReader sr = new StreamReader(path1, System.Text.Encoding.Default))
            {
                for (int i = 0; i < 13; i++)
                {
                    tank_P[i] = sr.ReadLine();
                }
            }
            for (int i = 0; i < 13; i++)
            {
                Console.SetCursorPosition(70, i);
                Console.WriteLine(tank_P[i]);
            }
            Console.SetCursorPosition(70, 16);
            Console.WriteLine(t2.GetName());
            Console.SetCursorPosition(70, 17);
            Console.WriteLine(t2.GetAmmunition());
            Console.SetCursorPosition(70, 18);
            Console.WriteLine(t2.GetArmor());
            Console.SetCursorPosition(70, 19);
            Console.WriteLine(t2.GetManeuverability());
            Console.SetCursorPosition(0, 14);
            for (int i = 0; i < 114; i++)
            {
                Console.Write("X");
            }
            Console.SetCursorPosition(0, 15);
            for (int i = 0; i < 114; i++)
            {
                Console.Write("X");
            }
            Console.CursorVisible = false;
            //Console.Read();
            if (b == true)
            {
                int x = 42, y = 3;
                Console.SetCursorPosition(x, y);
                Console.Write(":::");
                System.Threading.Thread.Sleep(1000);
                for (int i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("   ");
                    x += 4;
                    Console.SetCursorPosition(x, y);
                    Console.Write(":::");
                    System.Threading.Thread.Sleep(400);
                }
                for (int k = 0; k < 4; k++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 0; i < 13; i++)
                    {
                        Console.SetCursorPosition(70, i);
                        Console.WriteLine(tank_P[i]);
                    }
                    System.Threading.Thread.Sleep(400);
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 0; i < 13; i++)
                    {
                        Console.SetCursorPosition(70, i);
                        Console.WriteLine(tank_P[i]);
                    }
                    System.Threading.Thread.Sleep(200);
                }
                for (int i = 0; i < 13; i++)
                {
                    Console.SetCursorPosition(70, i);
                    Console.WriteLine("                                          ");
                }
            }
            else
            {
                int x = 66, y = 3;
                Console.SetCursorPosition(x, y);
                Console.Write(":::");
                System.Threading.Thread.Sleep(1000);
                for (int i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("   ");
                    x -= 4;
                    Console.SetCursorPosition(x, y);
                    Console.Write(":::");
                    System.Threading.Thread.Sleep(400);
                }
                for (int k = 0; k < 4; k++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 0; i < 13; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine(tank_T[i]);
                    }
                    System.Threading.Thread.Sleep(400);
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 0; i < 13; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine(tank_T[i]);
                    }
                    System.Threading.Thread.Sleep(200);
                }
                for (int i = 0; i < 13; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine("                                          ");
                }
                System.Threading.Thread.Sleep(500);
            }
        }

    }
}
