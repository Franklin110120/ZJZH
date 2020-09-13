using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class TextDrawSprite3: ITextSprite
    {
        private SpriteFont url;
        public TextDrawSprite3(SpriteFont url)
        {
            this.url = url;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(url, "http://www.mariouniverse.com/wp-content/img/sprites/nes/smb/mario-luigi.gif", new Vector2(200, 310), Color.Black);

            spriteBatch.End();
        }
    }
}
