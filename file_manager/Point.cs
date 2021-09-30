using System;

namespace file_manager
{
    public class Point
    {
        public char sym;
        public int x;
        public int y;
        
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}