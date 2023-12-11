using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct2D1;
using System.Diagnostics;

namespace Space_Invaders
{
    public class Enemy : Sprite
    {
        private Rectangle[,] boundingBoxArray = new Rectangle[6,3];
        private bool _isDrawn;
        public Enemy() : base()
        {

        }

        public Enemy(Texture2D spriteTexture, Vector2 spritePosition, Rectangle spriteBoundingBox, Color spriteColour, bool drawn)
            : base(spriteTexture, spritePosition, spriteBoundingBox, spriteColour)
        {
            _spriteTexture = spriteTexture;
            _spriteBoundingBox = spriteBoundingBox;
            _spritePosition = spritePosition;
            _spriteColour = spriteColour;
            _isDrawn = drawn;
        }

        public bool IsDrawn
        { 
            get { return _isDrawn; }
            set { _isDrawn = value; }
        }

        public void Update(GameTime gameTime, int rightSide, Bullets myBullet, Player myPlayer)
        {
            if (IsDrawn) // condition for if the enemy is drawn
            {
                if (BoundingBox.Intersects(myBullet.BoundingBox)) // condition for if the bullet and enemy are intersecting
                { 
                    IsDrawn = false; // sets isDrawn to false
                    myBullet._bulletFired = false; // sets _bulletFired to false
                    myBullet.ResetBullet(myPlayer); // calls ResetBullet
                }
            }
        }
    }
}
