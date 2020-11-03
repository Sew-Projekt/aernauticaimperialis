using System.Text;

namespace aernauticaimperialis {
    public class Map
    {
        public Map[,,] _map;

        public GameEngine _gameEngine;

        public GameEngine GameEngine
        {
            get => _gameEngine;
            set => _gameEngine = value;
        }

        public Map[,,] Map1
        {
            get => _map;
            set => _map = value;
        }

        public Map(int x, int y, int z)
        {
            _map = new Map[x, y, z];
        }

        public void Render()
        {
            StringBuilder builder = new StringBuilder();
            int count = 0;
        }
        
        public bool IsPointLegal(Point p) {
            if (p.X < 0 || p.Y < 0 || p.X >= _map.GetLength(0) || p.Y >= _map.GetLength(1) || p.Z < 0 || p.Z >= _map.GetLength(2)) {
                return false;
            }

            return true;
        }
    }
}