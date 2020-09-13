using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class MsController:IController 
    {
        private Game1 game;
        private float interfaceWidth;
        private float interfaceHeight;

        public MsController (Game1 game)
        {
            this.game = game;
            this.interfaceWidth = game.InterfaceWidth ;
            this.interfaceHeight = game.InterfaceHeight ;
        }
        public void Update()
        {
           
            if (Mouse.GetState().RightButton == ButtonState.Pressed)
            {
                game.Exit();
            }


            if (Mouse.GetState ().LeftButton == ButtonState.Pressed)
            {

                float xPos = Mouse.GetState ().X ;
                float yPos = Mouse.GetState ().Y ;
                if (xPos <= interfaceWidth / 2 && yPos <= interfaceHeight / 2)
                {
                    game.Sprite = new NMNASprite(game.Texture);
                }
                else if (xPos >= interfaceWidth / 2 && yPos <= interfaceHeight / 2)
                {
                    game.Sprite = new NMASprite(game.Texture);
                }
                else if (xPos <= interfaceWidth / 2 && yPos >= interfaceHeight / 2)
                {
                    game.Sprite = new MNASprite(game.Texture, game.Location);
                }
                else if (xPos >= interfaceWidth / 2 && yPos >= interfaceHeight / 2)
                {
                    game.Sprite = new MASprite(game.Texture, game.Location);
                }
            }
            

        }
    }
}
