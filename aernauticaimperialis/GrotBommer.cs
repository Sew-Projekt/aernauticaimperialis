using System.Collections.Generic;

namespace aernauticaimperialis {
    public class GrotBommer : AOrk {
        private const int POINTCOST = 28;
        
        public GrotBommer(int speed, int altitude) 
            : base(6, speed, 1, 2, 4, 3, 5, 4, altitude) {
        }
        
        Dictionary<EDistanceType, EWeaponOrientationType> _weapons = new Dictionary<EDistanceType, EWeaponOrientationType>();
    }
}