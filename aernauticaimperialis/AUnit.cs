namespace aernauticaimperialis {
    public class AUnit {
        protected int _structure;
        protected int _speed;
        protected int _maxThrottle;
        protected int _minSpeed;
        protected int _maxSpeed;
        protected int _maxManeuver;
        protected int _handling;
        protected int _maxAltitude;

        protected int _altitude;

        public AUnit(int structure, int speed, int maxThrottle, int minSpeed, int maxSpeed, int maxManeuver, int handling, int maxAltitude) {
            _structure = structure;
            _speed = speed;
            _maxThrottle = maxThrottle;
            _minSpeed = minSpeed;
            _maxSpeed = maxSpeed;
            _maxManeuver = maxManeuver;
            _handling = handling;
            _maxAltitude = maxAltitude;
            
        }
    }
}