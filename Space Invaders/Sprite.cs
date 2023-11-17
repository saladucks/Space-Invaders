using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Space_Invaders
{
    public class Sprite
    {
        protected Texture2D _spriteTexture;
        protected Vector2 _spritePosition;
        protected Rectangle _spriteBoundingBox;
        protected Color _spriteColour;
        protected int _spriteMovementX = 5, _spriteMovementY = 5, _spriteMovementZ = 10;
        protected bool _bulletFired = false;
        //protected bool _spriteLeft = false, _spriteRight = false;

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

        public virtual void Update(GameTime gameTime,  int rightSide)
        {
            //if (_spriteLeft == true)
            //{
            //    _spritePosition.X -= _spriteMovementX;
            //}
            //if (_spriteRight == true)
            //{
            //    _spritePosition.X += _spriteMovementX;
            //}
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_spriteTexture, Position, _spriteColour);
        }

        public Vector2 Position
        {
            get { return _spritePosition; }
            set { _spritePosition = value; }
        }

        public Rectangle BoundingBox
        {
            get { return _spriteBoundingBox; }
            set { _spriteBoundingBox = value; }
        }


    }
}
