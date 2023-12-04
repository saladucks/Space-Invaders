using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Space_Invaders
{
    public class Sprite : Game
    {
        protected Texture2D _spriteTexture;
        public KeyboardState _currentKey;
        public KeyboardState _pastKey;
        protected Vector2 _spritePosition;
        protected Rectangle _spriteBoundingBox;
        protected Color _spriteColour;
        protected int _spriteMovementX = 5, _spriteMovementY = 15;
        public bool _bulletFired;
        protected bool _bulletState;

        public Sprite()
        {

        }

        public Sprite(Texture2D spriteTexture, Vector2 spritePosition, Rectangle spriteBoundingBox, Color spriteColour)
        {
            _spriteTexture = spriteTexture;
            _spriteBoundingBox = spriteBoundingBox;
            _spritePosition = spritePosition;
            _spriteColour = spriteColour;
        }


        public virtual void Update(GameTime gameTime,  int rightSide)
        {

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
