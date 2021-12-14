using System.Threading;
using static System.Console;
using static System.ConsoleColor;
using static System.DateTime;

namespace Aquarium
{
    public class DateTimer
    {
        public static void TimerDate()
        {
            ForegroundColor = Blue;
            for (int i = 0; ; i++)
            {
                CursorVisible = false;
                SetCursorPosition(0, 28);
                Thread.Sleep(1000);
                Write(" {0:F}", Now);
            }
        }
    }
}
