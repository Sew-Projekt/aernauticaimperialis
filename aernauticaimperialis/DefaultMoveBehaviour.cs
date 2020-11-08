using System.Collections.Generic;

namespace aernauticaimperialis {
    public class DefaultMoveBehaviour : IMoveBehaviour {
        public DefaultMoveBehaviour() {
        }

        /*public void Move(Aircraft aircraft, Point destination) {
            List<Point> route = aircraft.CalculateRoute(destination);
            MovementCost costs = aircraft.CalculateMovementCost(route);
            if (SpinBehaviour.IsSpin(aircraft)) {
                SpinBehaviour.HandlingTest(aircraft);
            }
            aircraft.SetLocation(aircraft);
        }*/

        public void Move(Aircraft aircraft, Point destination) {
            List<Point> route = aircraft.CalculateRoute(destination);
            MovementCost costs = aircraft.CalculateMoveCost(route);

            if (SpinBehaviour.IsSpin(aircraft)) {
                if (!SpinBehaviour.HandlingTest(aircraft)) {
                    --aircraft.Position.Z;
                }
                else {
                    if (aircraft.MaxAltitude < aircraft.Position.Z)
                        aircraft.Position.Z--;
                    aircraft.CurrentSpeed = aircraft.MinSpeed;
                }

                if (aircraft.Position.Z == 0) {
                    GameEngine.AircraftList.Remove(aircraft);
                    return;
                }
                
            }

            if (costs.SpeedCost <= aircraft.CurrentSpeed) {
                aircraft.SetLocation(destination);
                Logger.GetInstance().Info(aircraft.Name + " is moved");
                return;
            }

            Logger.GetInstance().Info(aircraft.Name + " is not moved");
        }
    }
}