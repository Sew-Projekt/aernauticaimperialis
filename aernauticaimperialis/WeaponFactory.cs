using System;

namespace aernauticaimperialis {
    public class WeaponFactory {



        public void MakeWeapon(EWeaponType weaponType) {
            switch (weaponType) {
                case EWeaponType.QUAD_AUTOCANNON:
                    break;
                case EWeaponType.TWIN_LASCANNON:
                    break;
                case EWeaponType.QUAD_BIG_SHOOTAS:
                    break;
                case EWeaponType.TURRET_BIG_SHOOTAS:
                    break;
                case EWeaponType.TAIL_GUN:
                    break;
                case EWeaponType.PORT_TURRET:
                    break;
                case EWeaponType.STARBOARD_TURRET:
                    break;
                case EWeaponType.LASCANNON:
                    break;
                case EWeaponType.DORSAL_TURRET:
                    break;
                case EWeaponType.REAR_TURRET:
                    break;
                case EWeaponType.BOMB_BAY:
                    break;
                case EWeaponType.TWIN_MULTILASERS:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(weaponType), weaponType, null);
            }
        }
    }
}