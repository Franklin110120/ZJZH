using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class TextDrawSprite1: ITextSprite
    {
        private SpriteFont credit;
        public TextDrawSprite1 (SpriteFont credit){
            this.credit = credit;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(credit, "Credits", new Vector2(200, 270), Color.Black);

            spriteBatch.End();
        }

    }
}
