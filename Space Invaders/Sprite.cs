using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Space_Invaders
{
    public class Sprite
    {
        protected Texture2D _spriteTexture;
        protected Vector2 _spritePosition;
        protected Rectangle _spriteBoundingBox;
        protected Color _spriteColour;

        public Sprite()
        {

        }

        public Sprite(Texture2D spriteTexture, Vector2 spritePosition, Rectangle spriteBoundingBox, Color spriteColour)
        {
            _spriteBoundingBox = spriteBoundingBox;
            _spriteTexture = spriteTexture;
            _spritePosition = spritePosition;
            _spriteColour = spriteColour;
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_spriteTexture, _spritePosition, _spriteColour);
        }

        public Vector2 Position
        {
            get { return _spritePosition; }
            set { _spritePosition = value; }
        }

        public Rectangle BoundingBox
        {
            get { return BoundingBox; }
            set { BoundingBox = value; }
        }


    }
}
