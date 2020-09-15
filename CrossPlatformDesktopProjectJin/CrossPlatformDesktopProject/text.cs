using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Mario;

namespace CrossPlatformDesktopProject
{

    public class text
    {
        private SpriteFont textFont;
        
        public text(SpriteFont spriteFont)
        {

            this.textFont = spriteFont;
        }
        

        

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            

            spriteBatch.Begin();
            spriteBatch.DrawString(this.textFont, "Credits\nProgram Made By: Tianyu Jin\nSprite From: http://www.mariouniverse.com/wp-content/img/sprites/nes/smb/mario.png", new Vector2(10, 300), Color.Black);
            
            spriteBatch.End();
        }
    }
}
