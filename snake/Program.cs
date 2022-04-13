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
            Point p1 = new Point(1,3,'*');
            //p1.Draw();

            Point p2 = new Point(4,5,'#');
            //p2.Draw();

            List<Point> list = new List<Point>();
            list.Add(p1);
            list.Add(p2);

            foreach (var i in list)
            {
                i.Draw();
            }
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Draw();
            }
        }
    }
}
