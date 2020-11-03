using System;

namespace aernauticaimperialis {
    public class Point {
        protected int _x;
        protected int _y;
        protected int _z;
        
        public int X {
            get => _x;
            set => _x = value;
        }
        public int Y {
            get => _y;
            set => _y = value;
        }
        public int Z {
            get => _z;
            set => _z = value;
        }
        
        public Point(int x, int y, int z) {
            _x = x;
            _y = y;
            _z = z;
        }

        public override bool Equals(object obj)
        {
            Point p = (Point) obj;
            
            if (p.X == X && p.Y == Y && p.Z == Z)
            {
                return true;
            }

            return false;
        }
    }
}