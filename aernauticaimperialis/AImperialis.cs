﻿namespace aernauticaimperialis {
    public abstract class AImperialis : AUnit{
        public AImperialis(int structure, int speed, int maxThrottle, int minSpeed, int maxSpeed, int maxManeuver, int handling, int maxAltitude, int altitude) 
            : base(structure, speed, maxThrottle, minSpeed, maxSpeed, maxManeuver, handling, maxAltitude, altitude) {
        }
    }
}