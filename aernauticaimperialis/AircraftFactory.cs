using System.Linq;

namespace aernauticaimperialis {
    public class AircraftFactory {
        public static Aircraft CreateBigBurna(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 3, 2, 3, 7, 4, 4,4, 22);
            a.Weapons.Add(WeaponFactory.CreateQuadBigShootas());
            a.Weapons.Add(WeaponFactory.CreateTurretBigShootas());
            a.Weapons.Add(WeaponFactory.CreateTailGun());
            return a;
        }

        public static Aircraft Vulture(Point p) {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 2, 2, 3, 8, 5, 3, 4, 23);
            a.Weapons.Add(WeaponFactory.CreateQuadBigShootas());
            return a;
        }

        public static Aircraft GrotBommer(Point p)
        {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 6, 1, 2, 4, 3, 5, 4, 28);
            a.Weapons.Add(WeaponFactory.CreateQuadBigShootas());
            a.Weapons.Add(WeaponFactory.CreatePortTurret());
            a.Weapons.Add(WeaponFactory.CreateStarbordTurret());

            return a;
        }

        public static Aircraft BlueDevil(Point p)
        {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 5, 1, 2, 5, 3, 3, 5, 26);
            a.Weapons.Add(WeaponFactory.CreateLascannon());
            a.Weapons.Add(WeaponFactory.CreateDorsalTurret());
            a.Weapons.Add(WeaponFactory.CreateRearTurret());
            a.Weapons.Add(WeaponFactory.CreateBombBay());

            return a;
        }

        public static Aircraft Hellion(Point p)
        {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 2, 3, 2, 8, 7, 2, 5, 26);
            a.Weapons.Add(WeaponFactory.CreateTwinMultiLasers());
            return a;
        }

        public static Aircraft Executioner(Point p)
        {
            Aircraft a = new Aircraft(p.X, p.Y, p.Z, 3, 2, 2, 7, 6, 3, 5, 23);
            a.Weapons.Add(WeaponFactory.CreateQuadAutocannon());
            a.Weapons.Add(WeaponFactory.CreateTwinLascannon());

            return a;
        }
    }
}