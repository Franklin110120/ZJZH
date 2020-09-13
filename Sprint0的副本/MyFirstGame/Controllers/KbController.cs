using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    
    class KbController : IController
    {
        private Game1 game;

        public KbController (Game1 game)
        {
            this.game = game;
        }
        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad0) || Keyboard.GetState().IsKeyDown(Keys.D0))
            {
                game.Exit();
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.NumPad1) || Keyboard.GetState().IsKeyDown(Keys.D1))
            {
                game.Sprite = new NMNASprite(game.Texture);
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.NumPad2) || Keyboard.GetState().IsKeyDown(Keys.D2))
            {
                game.Sprite = new NMASprite(game.Texture);
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.NumPad3) || Keyboard.GetState().IsKeyDown(Keys.D3))
            {
                game.Sprite = new MNASprite(game.Texture, game.Location);
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.NumPad4) || Keyboard.GetState().IsKeyDown(Keys.D4))
            {
                game.Sprite = new MASprite(game.Texture, game.Location);
            }
        }
    }
}
