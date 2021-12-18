using System.Threading;
using static System.Console;

namespace Aquarium
{
    class RandomGrass
    {
        public static void Grass(string[] array, int left, int top, int speed)
        {
            SetCursorPosition(left, top);

            for (int i = 0; i < array.GetLength(0); i++)
            { 
                WriteLine($"{array[i]}");
            }
            Speed(speed);
        }
        public static void Speed(int speed)
        {
            Thread.Sleep(speed);
        }
    }
}

