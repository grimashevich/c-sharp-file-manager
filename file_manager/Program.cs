using System;

namespace file_manager
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                var sq = new SymRectangle(5 + i, 5 + i, 10, 10);
                sq.Draw();
            }
            Console.ReadKey();
            
        }
        
    }
}