using System;
using System.Collections.Generic;
using System.Net;

namespace aernauticaimperialis {
    public class Aircraft : Point{
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

        public Aircraft(int x, int y, int z, int structure, int maxThrottle, int minSpeed, int maxSpeed, int maxManeuver, int handling, int maxAltitude, int costs, EPlayerType playerType) : base(x, y, z) {
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
            CurrentSpeed = CurrentThrottle + CurrentSpeed;
        }

        public MovementCost CalculateMovementCost(List<Point> points) {
            int speedCount = 0;
            int maneuverCount = 0;
            foreach (Point p in points) {
                if (p.X != this.Position.X && p.Y != this.Position.Y) 
                    maneuverCount++;
                if (p.X != this.Position.X || p.Y != this.Position.Y || p.Z != this.Position.Z)
                    speedCount++;
            }
            return new MovementCost(maneuverCount, speedCount, points.Count + 1);
        }

        public void SetLocation(Point destination) {
            this.Position.X = destination.X;
            this.Position.Y = destination.Y;
            this.Position.Z = destination.Z;
        }
    }
}