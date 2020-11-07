using System.Collections.Generic;

namespace aernauticaimperialis {
    public class DefaultMoveBehaviour : IMoveBehaviour {
        public DefaultMoveBehaviour() {
        }

        public void Move(Aircraft aircraft,Point destination) {
            List<Point> route = aircraft.CalculateRoute(destination);
            MovementCost costs = aircraft.CalculateMovementCost(route);
            /*if (!SpinBehaviour.IsSpin(aircraft)) {
                aircraft.SetLocation(destination);
                return;
            }*/
            aircraft.SetLocation(destination);
            return;

            //SpinBehaviour.HandlingTest(aircraft);
        }
    }
}
