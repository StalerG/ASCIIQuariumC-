using System;
using static System.Console;
using static System.ConsoleColor;
using static System.DateTime;

namespace Aquarium
{
    class DateTimer
    {
        private static readonly ConsoleColor timerConsoleColor = DarkCyan;

        public static void TimerDate(int left, int top)
        {
            CursorVisible = false;
            ForegroundColor = timerConsoleColor;

            SetCursorPosition(left, top);
            Write("<< {0:F} >>", Now);
        }
    }
}