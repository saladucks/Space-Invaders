using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Space_Invaders
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _playerTexture;
        private Player myPlayer;
        private Bullets myBullets;
        private Enemy[,] myEnemyArray;

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

            myPlayer = new Player(new Vector2(_graphics.PreferredBackBufferWidth / 2, _graphics.PreferredBackBufferHeight - 90),
                new Rectangle(), Color.PaleVioletRed);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            
            myPlayer.LoadContent(Content);
        }

        public void SetEnemies()
        {
            myEnemyArray = new Enemy[]
        }


        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            myPlayer.Update(gameTime, _graphics.PreferredBackBufferHeight);

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightPink);

            _spriteBatch.Begin();

            myPlayer.Draw(_spriteBatch);
            //myBullets.Draw(_spriteBatch);

            

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}