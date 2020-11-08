using System;

namespace aernauticaimperialis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Map map = new Map();
            DefaultMoveBehaviour moveBehaviour = new DefaultMoveBehaviour();

            Aircraft hellion1 = AircraftFactory.CreateHellion(new Point(4, 2, 3), 1);
            Aircraft bigburna1 = AircraftFactory.CreateBigBurna(new Point(2, 4, 2), 2);
            
            moveBehaviour.Move(bigburna1, new Point(3, 4, 3));
            //moveBehaviour.Move(hellion1, new Point(5, 2, 2));
            map.Render();
            Console.ReadLine();
        }
    }
}