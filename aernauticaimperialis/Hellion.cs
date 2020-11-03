using System.Collections.Generic;

namespace aernauticaimperialis {
    public class Hellion : AImperialis {
        private const int POINTCOST = 26;
        
        public Hellion(int speed, int altitude) 
            : base(2, speed, 3, 2, 8, 7, 2, 5, altitude) {
        }
        
        Dictionary<EDistanceType, EWeaponOrientationType> _weapons = new Dictionary<EDistanceType, EWeaponOrientationType>();
    }
}