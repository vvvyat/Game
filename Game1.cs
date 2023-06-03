using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FishWorld
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private GameState _gameState;
        private Menu _menu = new Menu();
        private EndScreen _endScreen = new EndScreen();
        private Field _field;
        private int _objectSize = 80;
        private int _currentSeaweedSprite = 0;
        private int _currentFishSprite = 0;
        private int _seaweedSpriteSize = 3;
        private int _fishSpriteSize = 4;
        private int _currentTime = 0;
        private int _period = 400;

        SoundEffectInstance music;
        SoundEffectInstance gameMusic;
        SpriteFont score;
        SpriteFont message;
        Texture2D fish;
        Texture2D stone;
        Texture2D seaweed;
        Texture2D pearl;
        Texture2D menuButton;
        Texture2D resetButton;
        Texture2D levels;
        Texture2D background;
        Texture2D endScreen;
        Texture2D sand;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 1080;
            _graphics.PreferredBackBufferHeight = 480;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            music = Content.Load<SoundEffect>("music").CreateInstance();
            gameMusic = Content.Load<SoundEffect>("gameMusic").CreateInstance();
            fish = Content.Load<Texture2D>("fish");
            stone = Content.Load<Texture2D>("stone");
            seaweed = Content.Load<Texture2D>("seaweed");
            pearl = Content.Load<Texture2D>("pearl");
            levels = Content.Load<Texture2D>("levels");
            menuButton = Content.Load<Texture2D>("menu");
            resetButton = Content.Load<Texture2D>("reset");
            background = Content.Load<Texture2D>("background");
            sand = Content.Load<Texture2D>("sand");
            endScreen = Content.Load<Texture2D>("endScreen");
            message = Content.Load<SpriteFont>("message");
            score = Content.Load<SpriteFont>("score");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);

            switch (_gameState)
            {
                case GameState.Menu:
                    UpdateMenu(gameTime);
                    break;
                case GameState.Game:
                    UpdateGame(gameTime);
                    break;
                case GameState.End:
                    UpdateEndOfGame(gameTime);
                    break;
            }
        }

        void UpdateMenu(GameTime gameTime)
        {
            music.Play();

            for (var i = 0; i < _menu.LevelButtons.Length; i++)
                if (_menu.LevelButtons[i].IsButtonPressed())
                {
                    music.Stop();
                    _field = new Field(i);
                    _gameState = GameState.Game;
                }

            _currentTime += gameTime.ElapsedGameTime.Milliseconds;
            if (_currentTime > _period)
            {
                _currentTime -= _period;
                ++_currentSeaweedSprite;
                if (_currentSeaweedSprite >= _seaweedSpriteSize)
                    _currentSeaweedSprite = 0;
            }
        }

        void UpdateGame(GameTime gameTime)
        {
            gameMusic.Play();

            var kstate = Keyboard.GetState();

            if (kstate.IsKeyDown(Keys.Up) || kstate.IsKeyDown(Keys.W))
                _field.UpdatePlayerPosition(Move.Up);
            if (kstate.IsKeyDown(Keys.Down) || kstate.IsKeyDown(Keys.S))
                _field.UpdatePlayerPosition(Move.Down);

            _field.UpdateMap();
            _field.UpdateScore();
            _field.UpdatePlayerSpeed();

            _currentTime += gameTime.ElapsedGameTime.Milliseconds;
            if (_currentTime > _period)
            {
                _currentTime -= _period;
                ++_currentSeaweedSprite;
                ++_currentFishSprite;
                if (_currentSeaweedSprite >= _seaweedSpriteSize)
                    _currentSeaweedSprite = 0;
                if (_currentFishSprite >= _fishSpriteSize)
                    _currentFishSprite = 0;
            }

            if (!_field.IsPlayerAlive() || _field.IsLevelPassed())
            {
                gameMusic.Stop();
                _gameState = GameState.End;
            }
        }

        void UpdateEndOfGame(GameTime gameTime)
        {
            music.Play();

            if (_endScreen.Menu.IsButtonPressed())
            {
                music.Stop();
                _gameState = GameState.Menu;
            }

            if (_endScreen.ResetLevel.IsButtonPressed())
            {
                music.Stop();
                _field = new Field(_field.Level);
                _gameState = GameState.Game;
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _graphics.ApplyChanges();

            base.Draw(gameTime);

            switch (_gameState)
            {
                case GameState.Menu:
                    DrawMenu(gameTime);
                    break;
                case GameState.Game:
                    DrawGame(gameTime);
                    break;
                case GameState.End:
                    DrawEndOfGame(gameTime);
                    break;
            }
        }

        void DrawMenu(GameTime gameTime)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(background, new Vector2(0, 0), Color.White);
            for (var i = 0; i < _menu.LevelButtons.Length; i++)
                _spriteBatch.Draw(levels, new Vector2(_menu.LevelButtons[i].X, _menu.LevelButtons[i].Y),
                    new Rectangle(i * _objectSize, 0, _objectSize, _objectSize), Color.White);
            for (var i = 0; i < _graphics.PreferredBackBufferWidth / _objectSize; i++)
            {
                var position = new Vector2(20 + i * 80, _graphics.PreferredBackBufferHeight - _objectSize);
                _spriteBatch.Draw(seaweed, position,
                    new Rectangle(_currentSeaweedSprite * _objectSize, 0, _objectSize, _objectSize), Color.White);
            }
            _spriteBatch.End();
        }

        void DrawGame(GameTime gameTime)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(sand, new Vector2(0, 0), Color.White);
            foreach (var e in _field.Map)
                switch (e.Type)
                {
                    case TypeOfObstacle.Seaweed:
                        _spriteBatch.Draw(seaweed, e.Position,
                        new Rectangle(_currentSeaweedSprite * _objectSize, 0, _objectSize, _objectSize), Color.White);
                        break;
                    case TypeOfObstacle.Stone:
                        _spriteBatch.Draw(stone, e.Position, Color.White);
                        break;
                    case TypeOfObstacle.Pearl:
                        _spriteBatch.Draw(pearl, e.Position, Color.White);
                        break;
                    default:
                        break;
                }
            _spriteBatch.Draw(fish, _field.PlayerPosition, 
                new Rectangle(_currentFishSprite * _objectSize * 2, 0, _objectSize * 2, _objectSize), Color.White);
            _spriteBatch.DrawString(score, _field.Score.ToString(), new Vector2(100, 0), new Color(0, 0, 0));
            _spriteBatch.End();
        }

        void DrawEndOfGame(GameTime gameTime)
        {
            _spriteBatch.Begin();
            _spriteBatch.Draw(background, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(endScreen, new Vector2(240, 80), Color.White);
            var text = _field.IsPlayerAlive() ? "Уровень пройден!" : "Проигрыш(";
            var origin = message.MeasureString(text) / 2;
            _spriteBatch.DrawString(message, text, new Vector2(_graphics.PreferredBackBufferWidth / 2, 120), Color.Black, 0f, origin, 1f, SpriteEffects.None, 0f);
            if (_field.IsPlayerAlive())
            {
                text = "Счёт: " + _field.Score.ToString();
                origin = score.MeasureString(text) / 2;
                _spriteBatch.DrawString(score, text, new Vector2(_graphics.PreferredBackBufferWidth / 2, 240), Color.Black, 0f, origin, 1f, SpriteEffects.None, 0f);
            }
            _spriteBatch.Draw(menuButton, new Vector2(_endScreen.Menu.X, _endScreen.Menu.Y), Color.White);
            _spriteBatch.Draw(resetButton, new Vector2(_endScreen.ResetLevel.X, _endScreen.ResetLevel.Y), Color.White);
            _spriteBatch.End();
        }
    }
}