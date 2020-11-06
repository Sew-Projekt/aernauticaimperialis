using System.Collections.Generic;

namespace aernauticaimperialis {
    public class DefaultMoveBehaviour : IMoveBehaviour {
        private Aircraft _aircraft;
        public DefaultMoveBehaviour(Aircraft aircraft) {
            _aircraft = aircraft;
        }

        public void Move(Point destination) {
            /*List<Point> route = _aircraft.CalculateRoute(destination);
            MovementCost costs = _aircraft.CalculateMovementCost(route);
            for (int i = 0; i < costs.FieldCount; i++) {
                _aircraft.SetLocation(route[i]);
            }

            if (Spinbehaviour.IsSpin(_aircraft)) {
                _aircraft.MoveBehaviour = new Spinbehaviour(_aircraft);
            }
        }*/
        }

        
    }
}