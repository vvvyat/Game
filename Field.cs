using System.Collections.Generic;
using System.Linq;

using Rectangle = System.Drawing.Rectangle;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace FishWorld
{
    public class Field
    {
        private int _objectSize = 80;
        private int _windowHeight = 480;
        private int _windowWidth = 1080;
        private int _playerSpeed = 8;
        private int _mapSpeed = 10;

        public int Level { get; }
        public List<Obstacle> Map { get; set; }
        public Vector2 PlayerPosition { get; set; }
        public int Score { get; set; }

        public Field(int level)
        {
            Level = level;
            Map = GetMap();
            PlayerPosition = new Vector2(_objectSize, _windowHeight / 2 - _objectSize / 2);
            Score = 0;
        }

        public List<Obstacle> GetMap()
        {
            var res = new List<Obstacle>();
            var map = FishWorld.Map.Maps[Level];
            for (var i = 0; i < map.GetLength(0); i++)
                for (var j = 0; j < map.GetLength(1); j++)
                {
                    var position = new Vector2(_windowWidth + j * _objectSize, i * _objectSize);
                    var type = map[i, j] switch
                    {
                        'к' => TypeOfObstacle.Stone,
                        'в' => TypeOfObstacle.Seaweed,
                        'ж' => TypeOfObstacle.Pearl,
                        _ => TypeOfObstacle.EmptySpace,
                    };
                    if (type != TypeOfObstacle.EmptySpace)
                        res.Add(new Obstacle(position, type));
                }
            return res
                .OrderBy(e => e.Position.X)
                .ToList();
        }

        public void UpdatePlayerPosition(Move move)
        {
            var newY = move switch
            {
                Move.Up => PlayerPosition.Y - _playerSpeed,
                Move.Down => PlayerPosition.Y + _playerSpeed,
            };

            if (newY < 0) newY = 0;
            if (newY > _windowHeight - _objectSize) newY = _windowHeight - _objectSize;

            PlayerPosition = new Vector2(PlayerPosition.X, newY);
        }

        public void UpdateMap()
        {
            foreach (var e in Map)
            {
                var newPositionX = e.Position.X - _mapSpeed - (Level - 1) * 4;
                e.Position = new Vector2(newPositionX, e.Position.Y);
            }
        }

        public List<Obstacle> GetConflicts()
        {
            var res = new List<Obstacle>();
            var map = new List<Obstacle>();
            var delta = 30;
            var player = new Rectangle((int)PlayerPosition.X + 20, (int)PlayerPosition.Y, _objectSize * 2 - delta * 2, _objectSize - delta);
            foreach (var e in Map)
            {
                var obst = new Rectangle((int)e.Position.X, (int)e.Position.Y, _objectSize, _objectSize);
                if (player.IntersectsWith(obst))
                {
                    res.Add(e);
                    if (e.Type != TypeOfObstacle.Pearl)
                        map.Add(e);
                }
                else map.Add(e);
            }
            Map = map;
            return res;
        }

        public bool IsPlayerAlive()
        {
            foreach (var e in GetConflicts())
                if (e.Type == TypeOfObstacle.Stone)
                    return false;
            return true;
        }

        public bool IsLevelPassed()
        {
            return Map[^1].Position.X <= - _objectSize;
        }

        public void UpdateScore()
        {
            foreach (var e in GetConflicts())
                Score += e.Type == TypeOfObstacle.Pearl ? 10 : 0;
        }

        public void UpdatePlayerSpeed()
        {
            foreach (var e in GetConflicts())
                _playerSpeed = e.Type == TypeOfObstacle.Seaweed ? 4 : 8;
        }
    }
}