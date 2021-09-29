using System.Collections.Generic;

namespace file_manager
{
    public class Figure
    {
        protected List<Point> pList;
        
        public void Draw()
        {
            foreach (var p in pList)
                p.Draw();
        }

        public void Clear()
        {
            foreach (var p in pList)
                p.Clear();
        }
    }
}