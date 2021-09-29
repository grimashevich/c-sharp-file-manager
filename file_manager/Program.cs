using System;

namespace file_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = new SymLine('+', 5, 10, 110);
            var l2 = new SymLine('+', 50, 5, 20, LineType.Vertical);
            l1.Draw();
            l2.Draw();
            Console.ReadKey();
            l1.Clear();
            Console.ReadKey();
            
        }
        
    }
}