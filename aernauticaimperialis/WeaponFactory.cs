using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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

        public static Weapon CreatePortTurret()
        {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 2;
            distances[EDistanceType.MEDIUM] = 1;
            distances[EDistanceType.LONG] = 0;
            
            Weapon weapon = new Weapon(5, distances, new List<EWeaponOrientationType>() {EWeaponOrientationType.LEFT, EWeaponOrientationType.UP});

            return weapon;
        }

        public static Weapon CreateStarbordTurret()
        {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 2;
            distances[EDistanceType.MEDIUM] = 1;
            distances[EDistanceType.LONG] = 0;
            
            Weapon weapon = new Weapon(5, distances, new List<EWeaponOrientationType>() {EWeaponOrientationType.RIGHT, EWeaponOrientationType.UP});

            return weapon;
        }

        public static Weapon CreateLascannon()
        {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 0;
            distances[EDistanceType.MEDIUM] = 2;
            distances[EDistanceType.LONG] = 1;
            
            Weapon weapon = new Weapon(2, distances,
                new List<EWeaponOrientationType>() {EWeaponOrientationType.FRONT});

            return weapon;
        }

        public static Weapon CreateDorsalTurret()
        {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 3;
            distances[EDistanceType.MEDIUM] = 2;
            distances[EDistanceType.LONG] = 0;
            
            Weapon weapon = new Weapon(5, distances,
                new List<EWeaponOrientationType>() {EWeaponOrientationType.ALLROUND, EWeaponOrientationType.UP});

            return weapon;
        }

        public static Weapon CreateRearTurret()
        {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 3;
            distances[EDistanceType.MEDIUM] = 2;
            distances[EDistanceType.LONG] = 0;
            
            Weapon weapon = new Weapon(5, distances,
                new List<EWeaponOrientationType>() {EWeaponOrientationType.REAR});

            return weapon;
        }

        public static Weapon CreateBombBay()
        {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 8;
            distances[EDistanceType.MEDIUM] = 0;
            distances[EDistanceType.LONG] = 0;
            
            Weapon weapon = new Weapon(2, distances,
                new List<EWeaponOrientationType>() {EWeaponOrientationType.REAR});

            return weapon;
        }

        public static Weapon CreateTwinMultiLasers()
        {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 4;
            distances[EDistanceType.MEDIUM] = 6;
            distances[EDistanceType.LONG] = 2;
            
            Weapon weapon = new Weapon(5, distances,
                new List<EWeaponOrientationType>() {EWeaponOrientationType.FRONT});

            return weapon;
        }

        public static Weapon CreateQuadAutocannon()
        {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 2;
            distances[EDistanceType.MEDIUM] = 6;
            distances[EDistanceType.LONG] = 0;
            
            Weapon weapon = new Weapon(4, distances,
                new List<EWeaponOrientationType>() {EWeaponOrientationType.FRONT});

            return weapon;
        }

        public static Weapon CreateTwinLascannon()
        {
            Dictionary<EDistanceType, int> distances = new Dictionary<EDistanceType, int>();
            distances[EDistanceType.SHORT] = 0;
            distances[EDistanceType.MEDIUM] = 2;
            distances[EDistanceType.LONG] = 1;
            
            Weapon weapon = new Weapon(2, distances,
                new List<EWeaponOrientationType>() {EWeaponOrientationType.FRONT});

            return weapon;
        }
    }
}