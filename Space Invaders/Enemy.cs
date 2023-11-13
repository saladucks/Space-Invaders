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

        public Enemy(Texture2D spriteTexture, Vector2 spritePosition, Rectangle spriteBoundingBox, Color spriteColour)
            : base(spriteTexture, spritePosition, spriteBoundingBox, spriteColour)
        {
            _spriteBoundingBox = spriteBoundingBox;
            _spriteTexture = spriteTexture;
            _spritePosition = spritePosition;
            _spriteColour = spriteColour;
        }
    }
}
