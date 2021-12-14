using System;
using System.Runtime.InteropServices;
using System.Threading;
using static System.Console;
using static System.ConsoleColor;

namespace Aquarium
{
    internal class Program
    {
        public static class FishAquarium
        {
            private static readonly byte ConsoleWidthSize = 120;
            private static readonly byte ConsoleHeightSize = 30;
            private static readonly ConsoleColor WaterColor = Cyan;
            private static readonly ConsoleColor SeaWeedColor = Green;
            [DllImport(dllName:"kernel32.dll", ExactSpelling = true)]
            private static extern IntPtr GetConsoleWindow();
            [DllImport(dllName:"user32.dll", CharSet = CharSet.Auto)]
            private static extern bool EnableScrollBar(IntPtr hWnd, int wSBflags, int wArrows);
            public static void Console_ScrollBar_Settings()
            {
                SetWindowSize(width: ConsoleWidthSize, height: ConsoleHeightSize);
                IntPtr handle = GetConsoleWindow();
                EnableScrollBar(handle, wSBflags:3, wArrows:3);
            }
            public static void Water(byte left = 0, byte top = 5)
            {
                SetCursorPosition(left, top);

                ForegroundColor = WaterColor;

                byte count = 0;
                byte[] str1 = new byte[120];
                string[] str2 = { "^^^^ ^^^  ^^^   ^^^ ^^^^" };
                string[] str3 = { "^^^^     ^^^^    ^^^  ^^" };
                string[] str4 = { "^^   ^^^^   ^^^   ^^^^^^" };

                for (byte i = 0; i < str1.Length; i++) Write("~");

                while (count < 5)
                {
                    count++;
                    foreach (string item1 in str2) Write($"{item1}"); 
                    foreach (string item2 in str3) Write($"{item2}"); 
                    foreach (string item3 in str4) Write($"{item3}");
                }
                ResetColor();
            }
            public static void Castle(byte left = 15, byte top = 16)
            {
                string flag = "~~";
                string iCastle = @$"           
                                                                                            T{flag}
                                                                                            |
                                                                                           /^\
                                                                                          /   \
                                                                              _   _   _  /     \  _   _   _
                                                                             [ ]_[ ]_[ ]/ _   _ \[ ]_[ ]_[ ]
                                                                             |_=__-_ =_|_[ ]_[ ]_|_=-___-__|
                                                                              | _- =  | =_ = _    |= _=   |
                                                                              |= -[]  |- = _ =    |_-=_[] |
                                                                              | =_    |= - ___    | =_ =  |
                                                                              |=  []- |-  /| |\   |=_ =[] |
                                                                              |- =_   | =| | | |  |- = -  |
                                                                              |_______|__|_|_|_|__|_______|";
                int posY = ConsoleWidthSize - left;
                int posX = ConsoleHeightSize - top;
                SetCursorPosition(posY, posX);
                Write($"{iCastle}");
            }
            public static void SeaWeed()
            {
                for (int i = 0; ; i++)
                {
                    ForegroundColor = SeaWeedColor;
                    CursorVisible = false;
                    char[] seaWeed = { '(', ')' };
                    foreach (char item in seaWeed)
                    {
                        Thread.Sleep(100);
                        SetCursorPosition(5, 27);
                        Write(item);
                        Thread.Sleep(50);
                        SetCursorPosition(5, 26);
                        Write(item);
                        Thread.Sleep(100);
                        SetCursorPosition(5, 25);
                        Write(item);
                        Thread.Sleep(50);
                        SetCursorPosition(5, 24);
                        Write(item);
                        Thread.Sleep(100);
                        SetCursorPosition(5, 23);
                        Write(item);
                    }
                }
            }
        }
        static void Main()
        {
            FishAquarium.Console_ScrollBar_Settings();
            FishAquarium.Water();
            FishAquarium.Castle();
            FishAquarium.SeaWeed();
            DateTimer.TimerDate();
            ReadKey(intercept:false);
        }
    }
}


