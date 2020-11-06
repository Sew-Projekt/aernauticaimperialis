namespace aernauticaimperialis {
    public class SpinBehaviour : ISpinBehaviour {
        private Aircraft _aircraft;

        public SpinBehaviour(Aircraft aircraft) {
            _aircraft = aircraft;
        }

        public bool IsSpin(Aircraft aircraft) {
            if (aircraft.CurrentSpeed < aircraft.MinSpeed || aircraft.CurrentSpeed > aircraft.MaxSpeed) {
                return false;
            }

            return true;
        }
    }
}