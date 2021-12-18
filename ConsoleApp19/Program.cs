using System;
using static Aquarium.DateTimer;
using static Aquarium.Program.FishAquarium;
using static Aquarium.RandomGrass;
using static System.Console;
using static System.ConsoleColor;

namespace Aquarium
{
    internal class Program
    {
        public class FishAquarium
        {
            private static int counter;

            public FishAquarium()
            {
                counter = 0;
            }
            private static readonly ConsoleColor IBlue = Blue;
            private static readonly ConsoleColor IGreen = Green;
            public static void Water(int left = 0, int top = 5)
            {
                SetCursorPosition(left: left, top: top);
                ForegroundColor = IBlue;

                int[] sea = new int[120];
                for (int i = 0; i < sea.Length; i++) Write(value: "~");

                string[] str2 = { "^^^^ ^^^  ^^^   ^^^ ^^^^" };
                string[] str3 = { "^^^^     ^^^^    ^^^  ^^" };
                string[] str4 = { "^^   ^^^^   ^^^   ^^^^^^" };

                while (counter < 5)
                {
                    counter++;
                    foreach (string item1 in str2) Write($"{item1}");
                    foreach (string item2 in str3) Write($"{item2}");
                    foreach (string item3 in str4) Write($"{item3}");
                }
                ResetColor();
            }
            public static void Castle(byte left = 0, byte top = 14)
            {
                string[] iCastle = {
                    $@"
                                                                                         T~~
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
                                                                           |_______|__|_|_|_|__|_______|" };

                foreach (var item in iCastle)
                {
                    SetCursorPosition(left: left, top: top);
                    Write($"{item}");
                }
                ResetColor();
            }
            public static void SeaGrass()
            {
                ForegroundColor = IGreen;
                string[] grass_img = { "( ", "   )", "  (  ", "   )" };
                Grass(grass_img, left: 2, top: 24, speed: 75);
            }
        }
        static void Main()
        {
            Water();
            Castle();

            while (true)
            {
                SeaGrass();
                TimerDate(1, 28);
            }
        }
    }
}


