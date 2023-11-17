using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Space_Invaders
{
    public class Player : Sprite
    {
        private int lives = 3;

        public Player() : base()
        {
        
        } 

        public Player(Texture2D spriteTexture, Vector2 spritePosition, Rectangle spriteBoundingBox, Color spriteColour) 
            : base(spriteTexture, spritePosition, spriteBoundingBox, spriteColour)
        {
            _spritePosition = spritePosition;
            _spriteBoundingBox = spriteBoundingBox;
            _spriteColour = spriteColour;
            _spriteTexture = spriteTexture;
        }

        public void FireBullet()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                
            }
        }

        public override void Update(GameTime gameTime, int rightSide)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                //_spriteLeft = true;
                Position = new Vector2(Position.X - _spriteMovementX, Position.Y);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                //_spriteRight = true;
                Position = new Vector2(Position.X + _spriteMovementX, Position.Y);
            }

            //base.Update(gameTime, rightSide);

        }

        public int Lives
        {
            get { return lives; }
            set { lives = value; }
        }
    }
}
