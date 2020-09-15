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
	public class KeyboardController : IController
	{
		private Game1 game;
		public KeyboardController(Game1 game) {
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
				game.sprite = new StandingSprite(game.standing,1,1) ;
			}
			else if (Keyboard.GetState().IsKeyDown(Keys.NumPad2) || Keyboard.GetState().IsKeyDown(Keys.D2))
			{
				game.sprite = new AnimatedSprite(game.running, 1, 3);
			}
			else if (Keyboard.GetState().IsKeyDown(Keys.NumPad3) || Keyboard.GetState().IsKeyDown(Keys.D3))
			{
				game.sprite = new MovingSprite(game.dead, 1, 1);
			}
			else if (Keyboard.GetState().IsKeyDown(Keys.NumPad4) || Keyboard.GetState().IsKeyDown(Keys.D4))
			{
				game.sprite = new RunandMoveSprite(game.running, 1, 3);
			}

			
		}
	}
}
