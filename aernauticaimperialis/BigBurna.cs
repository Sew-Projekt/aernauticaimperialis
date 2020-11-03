using System.Collections.Generic;

namespace aernauticaimperialis {
    public class BigBurna : AOrk {
        private const int POINTCOST = 22;
        
        public BigBurna(int speed, int altitude) 
            : base(3, speed, 2, 3, 7, 4, 4, 4, altitude) {
        }
        
        Dictionary<EDistanceType, EWeaponOrientationType> _weapons = new Dictionary<EDistanceType, EWeaponOrientationType>();
    }
}