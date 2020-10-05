﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite_
{
    public class RightMovingLinkSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 10;

        public RightMovingLinkSprite()
        {


        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

<<<<<<< HEAD
            GlobalDefinitions.Position.X = GlobalDefinitions.Position.X + (float)3; //change the y axis position of Link
=======
            GlobalDefinitions.Position.X = GlobalDefinitions.Position.X + (float)1; //change the y axis position of Link
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
            if (GlobalDefinitions.Position.X == 0)
            {
                GlobalDefinitions.Position.X = (float)GlobalDefinitions.GraphicsWidth;
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

            spriteBatch.Draw(Texture2DStorage.GetRightMovingLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
    }
}
