namespace aernauticaimperialis {
    public class Executioner : AImperialis {
        private const int POINTCOST = 23;
        
        public Executioner(int speed, int altitude) 
            : base(3, speed, 2, 2, 7, 6, 3, 5, altitude) {
        }
    }
}