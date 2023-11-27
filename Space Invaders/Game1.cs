using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Space_Invaders
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private int _bulletPositionX, _bulletPositionY;
        private int _playerPositionX, _playerPositionY;
        private Player myPlayer;
        private Bullets myBullets;
        private Enemy[,] myEnemyArray;
        private Texture2D _playerTexture;
        private Texture2D _bulletTexture;
        private Texture2D _enemyTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 950;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _playerTexture = Content.Load<Texture2D>("PlaceHolder");
            _bulletTexture = Content.Load<Texture2D>("BulletPlaceHolder");
            _enemyTexture = Content.Load<Texture2D>("PlaceHolder");

            myPlayer = new Player(_playerTexture, new Vector2(_graphics.PreferredBackBufferWidth / 2 - _playerTexture.Width / 2, _graphics.PreferredBackBufferHeight - _playerTexture.Height),
            new Rectangle(), Color.PaleVioletRed);

            myBullets = new Bullets(_bulletTexture, new Vector2(_graphics.PreferredBackBufferWidth / 2 - 10 / 2, _graphics.PreferredBackBufferHeight - 10), 
                new Rectangle(), Color.PaleVioletRed);

            SetEnemies();
        }

        public void SetEnemies()
        {
            myEnemyArray = new Enemy[4,3];
            int enemyPositionX = 0;
            int enemyPositionY = 0;

            for (int i = 0; i < myEnemyArray.GetLength(0); i++)
            {
                for (int j = 0; j < myEnemyArray.GetLength(1); j++)
                {
                    enemyPositionX = i * _enemyTexture.Width;
                    enemyPositionY = j * _enemyTexture.Height;
                    myEnemyArray[i, j] = new Enemy(_enemyTexture, new Vector2(enemyPositionX, enemyPositionY),
                        new Rectangle(enemyPositionX, enemyPositionY, _enemyTexture.Width, _enemyTexture.Height), Color.LavenderBlush);
                }
            }
        }


        protected override void Update(GameTime gameTime)
        {
            
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            myPlayer.Update(gameTime, _graphics.PreferredBackBufferHeight);

            myBullets.Update(gameTime, _graphics.PreferredBackBufferHeight, myPlayer);

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightPink);

            _spriteBatch.Begin();

            foreach (Enemy e in myEnemyArray)
            {
                e.Draw(_spriteBatch);
            }

            myPlayer.Draw(_spriteBatch);

            myBullets.Draw(_spriteBatch);

            for (int i = 0; i < myEnemyArray.GetLength(0); i++)
            {
                for (int j = 0; j < myEnemyArray.GetLength(1); j++)
                {
                    myEnemyArray[i, j].Draw(_spriteBatch);
                }
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}