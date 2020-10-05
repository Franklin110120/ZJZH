﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class DownMovingLinkSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 10;

        public DownMovingLinkSprite()
        {
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

<<<<<<< HEAD
            GlobalDefinitions.Position.Y = GlobalDefinitions.Position.Y + (float)5; //change the y axis position of Link
=======
            GlobalDefinitions.Position.Y = GlobalDefinitions.Position.Y + (float)1; //change the y axis position of Link
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
            if (GlobalDefinitions.Position.Y == 0)
            {
                GlobalDefinitions.Position.Y = (float)GlobalDefinitions.GraphicsHeight;
            }

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame < 5)
            {
                sourceRectangle = new Rectangle(0, 0, 96, 96);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);//I don't understand why the width of destinationRectangle has to be like this.
            }


            else
            {
                sourceRectangle = new Rectangle(96, 0, 192, 96);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 192, 96);
            }

            spriteBatch.Draw(Texture2DStorage.GetDownMovingLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
    }
}
