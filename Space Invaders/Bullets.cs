using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Reflection.Metadata;

namespace Space_Invaders
{
    public class Bullets : Sprite
    {
        public Bullets() : base()
        { 

        }

        public Bullets(Texture2D spriteTexture, Vector2 spritePosition, Rectangle spriteBoundingBox, Color spriteColour)
            : base(spriteTexture, spritePosition, spriteBoundingBox, spriteColour)
        {
            _spriteTexture = spriteTexture;
            _spriteBoundingBox = spriteBoundingBox;
            _spritePosition = spritePosition;
            _spriteColour = spriteColour;
        }

        public void ResetBullet(Sprite owner)
        {
            Position = new Vector2(owner.Position.X + 195 / 2, owner.Position.Y); // sets bullet position back to player
        }

        public void Update(GameTime gameTime, int rightSide, Player myPlayer)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space)) // condition for if space is pressed
            {
                _bulletFired = true; // sets _bulletFired to true
            }

            if (_bulletFired == true) // condition for if _bulletFired is true
            {
                Position = new Vector2(Position.X, Position.Y - _spriteMovementY); // position continues to be updated to launch the bullet upwards
                
            }

            if (!_bulletFired || Position.Y <= 0) // condition for if the bullet has not been fired or if the bullet has reached the top of the screen
            {
                ResetBullet(myPlayer); // calls ResetBullet
                _bulletFired = false; // sets the bullet to not being fired
            }

        }

    }
}
