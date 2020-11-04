using System;
using System.Collections.Generic;

namespace aernauticaimperialis {
    public class WeaponFactory {
        public static Weapon CreateQuadBigShootas() {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 8;
            distances[EDistanceType.MEDIUM] = 4;
            distances[EDistanceType.LONG] = 0;

            Weapon bigshoota = new Weapon(5, distances,
                new List<EWeaponOrientationType>() {EWeaponOrientationType.FRONT});

            return bigshoota;
        }
    }
}