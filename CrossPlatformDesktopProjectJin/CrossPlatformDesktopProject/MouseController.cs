using Mario;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CrossPlatformDesktopProject
{
    
    class MouseController : IController
    {
		private Game1 game;
		
		public MouseController(Game1 game)
		{
			this.game = game;
			
		}

		public void Update()
        {
			if (Mouse.GetState().RightButton == ButtonState.Pressed) {
				game.Exit();
			}
			if (Mouse.GetState().LeftButton == ButtonState.Pressed) {

				float x = Mouse.GetState().X;
				float y = Mouse.GetState().Y;

				if (x < 400 && y < 200)
				{
					game.sprite = new StandingSprite(game.standing, 1, 1);
				}
				else if (x < 400 && y > 200) 
				{
					game.sprite = new MovingSprite(game.dead, 1, 1);
				}
				else if (x > 400 && y < 200)
				{
					
					game.sprite = new AnimatedSprite(game.running, 1, 3);
				}
				else if (x > 400 && y > 200)
				{
					game.sprite = new RunandMoveSprite(game.running, 1, 3);
				}
			}
		}
    }
}
