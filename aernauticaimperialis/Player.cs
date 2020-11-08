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
        }
    }
}