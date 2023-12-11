using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
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
        private Bullets myBullet;
        private Enemy myEnemy;
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

            _playerTexture = Content.Load<Texture2D>("PlaceHolder"); // loads player texture
            _bulletTexture = Content.Load<Texture2D>("BulletPlaceHolder"); // loads bullet texture
            _enemyTexture = Content.Load<Texture2D>("EnemyPlaceHolder"); // loads enemy texture

            myPlayer = new Player(_playerTexture, new Vector2(_graphics.PreferredBackBufferWidth / 2 - _playerTexture.Width / 2, _graphics.PreferredBackBufferHeight - _playerTexture.Height),
            new Rectangle(), Color.PaleVioletRed); // loads player

            myBullet = new Bullets(_bulletTexture, new Vector2(_graphics.PreferredBackBufferWidth / 2 - 10 / 2, _graphics.PreferredBackBufferHeight - 10), 
                new Rectangle(_graphics.PreferredBackBufferWidth / 2 - 10 / 2, _graphics.PreferredBackBufferHeight - 10, _bulletTexture.Width, _bulletTexture.Height),
                Color.MistyRose); // loads bullet

            SetEnemies(); // calls set enemies
        }

        public void SetEnemies()
        {
            myEnemyArray = new Enemy[6,3]; // creates new array
            int enemyPositionX; // creates variable for the enemy's position on the x-axis
            int enemyPositionY; // creates variable for the enemy's psoition on the y-axis

            for (int i = 0; i < myEnemyArray.GetLength(0); i++) // loops while i is smaller than the width of the array
            {
                for (int j = 0; j < myEnemyArray.GetLength(1); j++) // loops while j is smaller than the height of the array
                {
                    enemyPositionX = i * _enemyTexture.Width; // multiplies width of enemy by the number across the enemy is
                    enemyPositionY = j * _enemyTexture.Height; // multiplies height of the enemy by the number down the enemy is
                    myEnemyArray[i, j] = new Enemy(_enemyTexture, new Vector2(enemyPositionX + 30 + i * 40, enemyPositionY + 50 + j * 40),
                        new Rectangle(enemyPositionX + 30 + i * 40, enemyPositionY + 50 + j * 40, _enemyTexture.Width, _enemyTexture.Height), Color.PaleVioletRed, true); // loads the enemies
                }
            }
        }


        protected override void Update(GameTime gameTime)
        {
            
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            myPlayer.Update(gameTime, _graphics.PreferredBackBufferHeight); // calls the update of the player

            myBullet.Update(gameTime, _graphics.PreferredBackBufferHeight, myPlayer);
            myBullet.BoundingBox = new Rectangle((int)myBullet.Position.X, (int)myBullet.Position.Y, _bulletTexture.Width, _bulletTexture.Height); // sets the bounding box for the bullet

            foreach (Enemy e in myEnemyArray) // cycles through every enemy in the array
            {
                e.Update(gameTime, _graphics.PreferredBackBufferHeight, myBullet, myPlayer); // calls the update for every enemy
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightPink); // makes the background pink

            _spriteBatch.Begin(); 

            foreach (Enemy e in myEnemyArray) // cycles through every enemy in the array
            {
                if (e.IsDrawn) // condition for if the enemy is drawn
                {
                    e.Draw(_spriteBatch); // draws every enemy in enemy
                }
            }

            myPlayer.Draw(_spriteBatch); // draws the player

            myBullet.Draw(_spriteBatch); // draws the bullet

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}