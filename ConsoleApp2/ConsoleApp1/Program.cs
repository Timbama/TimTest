using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid();
            Actor actor = new Actor();
            grid.addActor(actor, 2, 0);
            grid.printGrid();

            Console.Read();
        }
    }
}
