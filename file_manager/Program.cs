using System;

namespace file_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var sq = new SymRectangle(3, 3, 50, 20);
            var l1 = new SymLineIn('║', 43, 3, 20, LineType.Vertical);
            
            sq.Draw();
            l1.Draw();
            Console.ReadKey();
            
        }
        
    }
}