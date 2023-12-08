using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


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
            Position = new Vector2(owner.Position.X + 195 / 2, owner.Position.Y);
        }

        public void Update(GameTime gameTime, int rightSide, Player myPlayer, Enemy[] myEnemyArray)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                _bulletFired = true;
            }

            if (_bulletFired == true)
            {
                Position = new Vector2(Position.X, Position.Y - _spriteMovementY);
                
            }

            if (!_bulletFired || Position.Y <= 0)
            {
                Position = new Vector2(myPlayer.Position.X + 195/2, myPlayer.Position.Y);
                _bulletFired = false;
            }

        }

    }
}
