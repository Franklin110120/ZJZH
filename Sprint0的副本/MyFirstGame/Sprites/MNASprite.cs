using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class MNASprite : ISprite
    {
        private Texture2D texture;
        private int interfaceHeight = 400;
        private float yLocation;
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
        public MNASprite(Texture2D texture, Vector2 location)
        {

            this.Texture = texture;
            yLocation  = location.Y;
        }

        public void Update()
        {

            yLocation  = yLocation-(float)1;
            if (yLocation == 0)
            {
                yLocation  = (float)interfaceHeight;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {

           

            Rectangle sourceRectangle = new Rectangle(0, 0, 52, 62); ;
            Rectangle destinationRectangle = new Rectangle((int)location.X , (int)yLocation , 52, 62);

            
         
            
            

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
