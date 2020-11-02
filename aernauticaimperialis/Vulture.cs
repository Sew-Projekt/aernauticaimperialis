namespace aernauticaimperialis {
    public class Vulture : AOrk {
        private const int POINTCOST = 23;
        
        public Vulture(int speed, int altitude) 
            : base(2, speed, 2, 3, 8, 5, 3, 4, altitude) {
        }
    }
}