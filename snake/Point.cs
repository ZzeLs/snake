using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class Point
    {
        public int x = 1;
        public int y = 3;
        public char sym;
        public Point()
        {            
        }
        public Point(int X, int Y, char Sym)
        {
            x = X;
            y = Y;
            sym = Sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
