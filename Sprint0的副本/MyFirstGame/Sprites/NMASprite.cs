using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MyFirstGame
{
    class NMASprite : ISprite
    {
        private Texture2D texture;

        private int currentFrame = 0;
        private int totalFrame = 8;

        public Texture2D Texture
        {
            get
            {
                return this.texture;
            }

            set
            {
                this.texture = value;
            }
        }
        public NMASprite(Texture2D texture)
        {

            this.Texture = texture;

        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(0, 0, 52, 62);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 52, 62);
            }
            else if (currentFrame == 1)
            {
                sourceRectangle = new Rectangle(52, 0, 46, 62);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 46, 62);
            }
            else if (currentFrame == 2)
            {
                sourceRectangle = new Rectangle(98, 0, 58, 62);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 58, 62);
            }
            else if (currentFrame == 3)
            {
                sourceRectangle = new Rectangle(156, 0, 55, 62);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 55, 62);
            }

            else if (currentFrame == 4)
            {
                sourceRectangle = new Rectangle(211, 0, 55, 62);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 55, 62);
            }

            else if (currentFrame == 5)
            {
                sourceRectangle = new Rectangle(266, 0, 58, 62);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 58, 62);
            }

            else if (currentFrame == 6)
            {
                sourceRectangle = new Rectangle(324, 0, 48, 62);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 48, 62);
            }

            else
            {
                sourceRectangle = new Rectangle(372, 0, 50, 62);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, 50, 62);
            }

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
