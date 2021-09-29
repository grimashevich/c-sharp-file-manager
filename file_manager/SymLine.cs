using System.Collections.Generic;

namespace file_manager
{

    public class SymLine: Figure
    {
        /*Горизонтальная линия, создается слева направо*/
        
        int len;
        LineType dir;

        public SymLine(char sym, int x, int y, int len, LineType _dir = LineType.Horizontal)
        {
            dir = _dir;
            pList = new List<Point>();
            if (dir == LineType.Horizontal)
            {
                for (int i = x; i < x + len; i++)
                {
                    Point p = new Point(i, y, sym);
                    pList.Add(p);
                }
                return;
            }
            for (int i = y; i < y + len; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }
    }
}