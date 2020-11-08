using System.Collections.Generic;

namespace aernauticaimperialis {
    public class DefaultMoveBehaviour : IMoveBehaviour {
        public DefaultMoveBehaviour() {
        }

        public void Move(Aircraft aircraft, Point destination) {
            List<Point> route = aircraft.CalculateRoute(destination);
            MovementCost costs = aircraft.CalculateMovementCost(route);
            if (SpinBehaviour.IsSpin(aircraft)) {
                SpinBehaviour.HandlingTest(aircraft);
            }
            aircraft.SetLocation(aircraft);
        }
    }
}