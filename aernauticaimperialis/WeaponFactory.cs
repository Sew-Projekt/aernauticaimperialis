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

        public static Weapon CreateTurretBigShootas()
        {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 3;
            distances[EDistanceType.MEDIUM] = 1;
            distances[EDistanceType.LONG] = 0;
            
            Weapon turretbigshoota = 
                new Weapon(5, distances, 
                    new List<EWeaponOrientationType>(){EWeaponOrientationType.REAR, EWeaponOrientationType.RIGHT, EWeaponOrientationType.LEFT, EWeaponOrientationType.UP});

            return turretbigshoota;
        }

        public static Weapon CreateTailGun()
        {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 1;
            distances[EDistanceType.MEDIUM] = 0;
            distances[EDistanceType.LONG] = 0;
            
            Weapon tailgun = new Weapon(6, distances,
                new List<EWeaponOrientationType>() {EWeaponOrientationType.REAR});

            return tailgun;
        }
    }
}