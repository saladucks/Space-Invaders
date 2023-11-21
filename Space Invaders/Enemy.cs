using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Space_Invaders
{
    public class Enemy : Sprite
    {
        public Enemy() : base()
        {

        }

        public Enemy(Vector2 spritePosition, Rectangle spriteBoundingBox, Color spriteColour)
            : base(spritePosition, spriteBoundingBox, spriteColour)
        {
            _spriteBoundingBox = spriteBoundingBox;
            _spritePosition = spritePosition;
            _spriteColour = spriteColour;
        }

        

        public void Update(GameTime gameTime, int rightSide)
        {

        }
    }
}
