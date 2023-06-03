using Microsoft.Xna.Framework;
using System;

namespace FishWorld
{
    public class Obstacle
    {
        public Vector2 Position { get; set; }

        public TypeOfObstacle Type { get; }

        public Obstacle(Vector2 position, TypeOfObstacle type)
        {
            Position = position;
            Type = type;
        }
    }
}
