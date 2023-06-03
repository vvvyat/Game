namespace FishWorld
{
    public class EndScreen
    {
        public Button Menu { get; }
        public Button ResetLevel { get; }

        public EndScreen()
        {
            Menu = new Button(420, 300);
            ResetLevel = new Button(580, 300);
        }
    }
}