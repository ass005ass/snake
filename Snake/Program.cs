using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Drow();

            Point p2 = new Point(4,5,'#');
            p2.Drow();

            HorizontalLine HLine = new HorizontalLine(5, 10, 8,'+');
            HLine.Drow();

            VerticalLine VLine = new VerticalLine(12, 8, 13, '*');
            VLine.Drow();

            Console.ReadLine();

        }
    }
}
