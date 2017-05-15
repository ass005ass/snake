using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            //Отрисовка рамки.

            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine ReightLine = new VerticalLine(0, 24, 78, '+');

            wallList.Add(UpLine);
            wallList.Add(DownLine);
            wallList.Add(LeftLine);
            wallList.Add(ReightLine);

        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }

            return false;
        }

        public void Drow()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}
