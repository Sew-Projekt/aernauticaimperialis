namespace aernauticaimperialis {
    public class Player {
        private Aircraft _aircraft;
        private static int _points = 150;

        private readonly EPlayerType _playerType;
        private int _achievedPoints;

        public EPlayerType PlayerType => _playerType;
        
        public int AchievedPoints {
            get => _achievedPoints;
            set => _achievedPoints = value;
        }

        public Player(EPlayerType playerType) {
            _playerType = playerType;
            _points = _points - _aircraft.Costs; //Is falsch,
                                                 //weil wir ja ned immer neuen Player erstellen,
                                                 //wenn flugzeug erstellen
        }
    }
}