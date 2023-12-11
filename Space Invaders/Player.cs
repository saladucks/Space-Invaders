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
            _spriteTexture = spriteTexture;
            _spritePosition = spritePosition;
            _spriteBoundingBox = spriteBoundingBox;
            _spriteColour = spriteColour;
        }

        public void FireBullet(GameTime gameTime, int rightSide)
        {
            _currentKey = Keyboard.GetState(); // sets pressed key to currentkey

            if (_currentKey.IsKeyUp(Keys.Space) && _pastKey.IsKeyDown(Keys.Space)) // condition for if space is up and it was pressed down originally
            {
                _bulletFired = true; // bullet is fired
            }

            _pastKey = _currentKey;
        }

        public override void Update(GameTime gameTime, int rightSide)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.A)) // condition for if A is pressed
            {
                //_spriteLeft = true;
                Position = new Vector2(Position.X - _spriteMovementX, Position.Y); // causes the player to move left
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D)) // condition for if D is pressed    
            {
                //_spriteRight = true;
                Position = new Vector2(Position.X + _spriteMovementX, Position.Y); // causes the player to move right
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
