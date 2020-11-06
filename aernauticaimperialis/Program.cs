using System;

namespace aernauticaimperialis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Map map = new Map();

            
            AircraftFactory.CreateHellion(new Point(4, 2, 3), 1);
            AircraftFactory.CreateBigBurna(new Point(2, 4, 2), 2);
            
            map.Render();
            Console.ReadLine();
        }
    }
}