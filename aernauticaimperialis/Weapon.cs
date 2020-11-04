using System.Collections.Generic;

namespace aernauticaimperialis {
    public class Weapon {
        private int _damage;

        private readonly Dictionary<EDistanceType, int> _distances = null;
        private readonly List<EWeaponOrientationType> _orientations = null;

        public int Damage {
            get => _damage;
            set => _damage = value;
        }

        public Dictionary<EDistanceType, int> Distances {
            get => _distances;
        }

        public List<EWeaponOrientationType> Orientations {
            get => _orientations;
        }

        public Weapon(int damage, Dictionary<EDistanceType, int> distances, List<EWeaponOrientationType> orientations) {
            _damage = damage;
            _distances = distances;
            _orientations = orientations;
        }
    }
}