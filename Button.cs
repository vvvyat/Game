using Microsoft.Xna.Framework.Input;

namespace FishWorld
{
    public class Button
    {
        public int X { get; }
        public int Y { get; }

        public Button(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool IsButtonPressed()
        {
            var mouseState = Mouse.GetState();
            return (mouseState.X < X + 80 && mouseState.X > X && mouseState.Y < Y + 80 &&
                mouseState.Y > Y && mouseState.LeftButton == ButtonState.Pressed);
        }
    }
}
