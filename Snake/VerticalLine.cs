using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yLeft, int yReight, char sym)
        {
            pList = new List<Point>();
            for (int y = yLeft; y <= yReight; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Drow();
            }
        }
    }
}
