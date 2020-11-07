using System.Collections.Generic;

namespace aernauticaimperialis {
    public class DefaultMoveBehaviour : IMoveBehaviour {
        private Aircraft _aircraft;
        public DefaultMoveBehaviour(Aircraft aircraft) {
            _aircraft = aircraft;
        }

        public void Move(Aircraft aircraft,Point destination) {
            List<Point> route = aircraft.CalculateRoute(destination);
            MovementCost costs = aircraft.CalculateMovementCost(route);
            if (!SpinBehaviour.IsSpin(aircraft)) {
                aircraft.SetLocation(destination);
            }

            SpinBehaviour.HandlingTest(aircraft);
        }
    }
}
