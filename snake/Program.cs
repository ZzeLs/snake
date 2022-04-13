using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 3;
            char sym = '*';

            Draw(x,y,sym);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2,y2,sym2);
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
