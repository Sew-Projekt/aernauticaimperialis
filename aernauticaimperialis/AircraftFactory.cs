﻿using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace aernauticaimperialis {
    public class AircraftFactory {
        
        public static Aircraft CreateBigBurna(Point p, int currentThrottle) {
            Aircraft a = new Aircraft("BigBurna", p.X, p.Y, p.Z, 3, 2, 3, 7, 4, 4, 4, 22, EPlayerType.ORK);
            if (currentThrottle <= a.MaxThrottle && currentThrottle >= a.MaxThrottle * -1) {
                a.Weapons.Add(WeaponFactory.CreateQuadBigShootas());
                a.Weapons.Add(WeaponFactory.CreateTurretBigShootas());
                a.Weapons.Add(WeaponFactory.CreateTailGun());
                GameEngine.AircraftList.Add(a);
            }

            return a;
        }

        public static Aircraft CreateVulture(Point p, int currentThrottle) {
            Aircraft a = new Aircraft("Vulture", p.X, p.Y, p.Z, 2, 2, 3, 8, 5, 3, 4, 23, EPlayerType.ORK);
            if (currentThrottle <= a.MaxThrottle && currentThrottle >= a.MaxThrottle * -1) {
                a.Weapons.Add(WeaponFactory.CreateQuadBigShootas());
                GameEngine.AircraftList.Add(a);
            }

            return a;
        }

        public static Aircraft CreateGrotBommer(Point p, int currentThrottle) {
            Aircraft a = new Aircraft("GrotBommer", p.X, p.Y, p.Z, 6, 1, 2, 4, 3, 5, 4, 28, EPlayerType.ORK);
            if (currentThrottle <= a.MaxThrottle && currentThrottle >= a.MaxThrottle * -1) {
                a.Weapons.Add(WeaponFactory.CreateQuadBigShootas());
                a.Weapons.Add(WeaponFactory.CreatePortTurret());
                a.Weapons.Add(WeaponFactory.CreateStarbordTurret());
                GameEngine.AircraftList.Add(a);
            }

            return a;
        }

        public static Aircraft CreateBlueDevil(Point p, int currentThrottle) {
            Aircraft a = new Aircraft("BlueDevil", p.X, p.Y, p.Z, 5, 1, 2, 5, 3, 3, 5, 26, EPlayerType.IMPERIALIS);
            if (currentThrottle <= a.MaxThrottle && currentThrottle >= a.MaxThrottle * -1) {
                a.Weapons.Add(WeaponFactory.CreateLascannon());
                a.Weapons.Add(WeaponFactory.CreateDorsalTurret());
                a.Weapons.Add(WeaponFactory.CreateRearTurret());
                a.Weapons.Add(WeaponFactory.CreateBombBay());
                GameEngine.AircraftList.Add(a);
            }

            return a;
        }

        public static Aircraft CreateHellion(Point p, int currentThrottle) {
            Aircraft a = new Aircraft("Hellion", p.X, p.Y, p.Z, 2, 3, 2, 8, 7, 2, 5, 26, EPlayerType.IMPERIALIS);
            if (currentThrottle <= a.MaxThrottle && currentThrottle >= a.MaxThrottle * -1) {
                a.Weapons.Add(WeaponFactory.CreateTwinMultiLasers());
                a.CurrentSpeed = currentThrottle + (a.MinSpeed + a.CurrentSpeed);
                GameEngine.AircraftList.Add(a);
            }

            return a;
        }

        public static Aircraft CreateExecutioner(Point p, int currentThrottle) {
            Aircraft a = new Aircraft("Executioner", p.X, p.Y, p.Z, 3, 2, 2, 7, 6, 3, 5, 23, EPlayerType.IMPERIALIS);
            if (currentThrottle <= a.MaxThrottle && currentThrottle >= a.MaxThrottle * -1) {
                a.Weapons.Add(WeaponFactory.CreateQuadAutocannon());
                a.Weapons.Add(WeaponFactory.CreateTwinLascannon());
                GameEngine.AircraftList.Add(a);
            }

            return a;
        }
    }
}