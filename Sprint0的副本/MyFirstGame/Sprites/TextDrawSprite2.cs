using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class TextDrawSprite2: ITextSprite
    {
        private SpriteFont author;
        public TextDrawSprite2(SpriteFont author)
        {
            this.author  = author ;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(author, "Program made by Mingzhe Han", new Vector2(200, 290), Color.Black);

            spriteBatch.End();
        }
    }
}
