using System;
using System.Collections.Generic;
using System.Net;

namespace aernauticaimperialis {
    public class Aircraft : Point {
        private int _structure;
        private int _currentSpeed;
        private int _currentThrottle;
        private readonly int _maxThrottle;
        private readonly int _minSpeed;
        private readonly int _maxSpeed;
        private readonly int _maxManeuver;
        private readonly int _handling;
        private readonly int _maxAltitude;
        private int _costs;
        private readonly List<Weapon> _weapons = new List<Weapon>();
        private EPlayerType _playerType;
        private Point _position;
        private string _name;

        public string Name {
            get => _name;
            set => _name = value;
        }

        public Point Position {
            get => _position;
            set => _position = value;
        }

        public EPlayerType PlayerType {
            get => _playerType;
            set => _playerType = value;
        }

        public List<Weapon> Weapons => _weapons;

        public int Structure {
            get => _structure;
            set => _structure = value;
        }

        public int CurrentSpeed {
            get => _currentSpeed;
            set => _currentSpeed = value;
        }

        public int CurrentThrottle {
            get => _currentThrottle;
            set => _currentThrottle = value;
        }

        public int MaxThrottle => _maxThrottle;

        public int MinSpeed => _minSpeed;

        public int MaxSpeed => _maxSpeed;

        public int MaxManeuver => _maxManeuver;

        public int Handling => _handling;

        public int MaxAltitude => _maxAltitude;

        public int Costs {
            get => _costs;
            set => _costs = value;
        }

        public Aircraft(string name,int x, int y, int z, int structure, int maxThrottle, int minSpeed, int maxSpeed,
            int maxManeuver, int handling, int maxAltitude, int costs, EPlayerType playerType) : base(x, y, z) {
            _structure = structure;
            _maxThrottle = maxThrottle;
            _minSpeed = minSpeed;
            _maxSpeed = maxSpeed;
            _maxManeuver = maxManeuver;
            _handling = handling;
            _maxAltitude = maxAltitude;
            _costs = costs;
            _fieldType = EFieldType.AIRCRAFT;
            _playerType = playerType;
            _position = new Point(x, y, z);
            _name = name;
        }

        public MovementCost CalculateMoveCost(List<Point> route)
        {
            int maneuverCost = 0;
            int speedCost = 0;
            int fieldCost = 0;
            if (route.Count <= 1) //wtf pani
                return new MovementCost(1, 1, 1);

            int prevIndex = 0;
            Point previous = route[prevIndex];
            int currIndex = 1;
            Point current = route[currIndex];

            for (int i = 0; i <= route.Count; i++)
            {
                fieldCost++;
                if (previous.X != current.X)
                {
                    if (previous.Y != current.Y)
                    {
                        maneuverCost++;
                        speedCost++;
                    }

                    speedCost++;
                }

                if (previous.X == current.X && previous.Y != current.Y)
                {
                    speedCost++;
                }

                if (previous.Z != current.Z)
                {
                    speedCost++;
                }

                if (currIndex + 1 >= route.Count)
                {
                    break;
                }

                previous = route[++prevIndex];
                current = route[++currIndex];
            }

            return new MovementCost(maneuverCost, speedCost, fieldCost);
        }
        public void SetLocation(Point destination) {
            this.Position.X = destination.X;
            this.Position.Y = destination.Y;
            this.Position.Z = destination.Z;
        }
    }
}