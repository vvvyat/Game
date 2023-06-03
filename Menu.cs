namespace FishWorld
{
    public class Menu
    {
        public Button[] LevelButtons { get; }

        public Menu()
        {
            LevelButtons = GetMenu();
        }

        public Button[] GetMenu()
        {
            var res = new Button[3];
            for (var i = 0; i < res.Length; i++)
                res[i] = new Button(340 + i * 160, 160);
            return res;
        }
    }
}