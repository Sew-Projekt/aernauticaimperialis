using System;

namespace aernauticaimperialis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Map map = new Map();

            Aircraft hellion1 = AircraftFactory.CreateHellion(new Point(4, 2, 3), 3);
            Aircraft bigburna1 = AircraftFactory.CreateBigBurna(new Point(2, 4, 2), 2);
            
            DefaultMoveBehaviour moveBehaviour = new DefaultMoveBehaviour();
            moveBehaviour.Move(bigburna1, new Point(2, 4, 3));
            moveBehaviour.Move(hellion1, new Point(5, 5, 2));

            map.Render();
            Console.ReadLine();
        }
    }
}