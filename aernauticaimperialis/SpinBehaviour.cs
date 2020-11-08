namespace aernauticaimperialis {
    public class SpinBehaviour {
        private Aircraft _aircraft;

        public SpinBehaviour(Aircraft aircraft) {
            _aircraft = aircraft;
        }

        public static bool IsSpin(Aircraft aircraft) {
            if (aircraft.CurrentSpeed < aircraft.MinSpeed || aircraft.CurrentSpeed > aircraft.MaxSpeed 
                                                          || aircraft.Position.Z > aircraft.MaxAltitude) {
                return true;
            }
            
            return false;
        }
        
        public static bool HandlingTest(Aircraft aircraft) {
            if (Dice.GetInstance().RollDice() >= aircraft.Handling) {
                Logger.GetInstance().Info("Handlingtest successful");
                return true;
            }
            Logger.GetInstance().Info("Handlingtest not successful, try again");
            return false;
        }
    }
}