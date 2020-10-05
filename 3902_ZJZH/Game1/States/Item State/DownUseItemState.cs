<<<<<<< HEAD
﻿using Game1.Command;
using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class DownUseItemState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public IProjectile Arrow { get; set; }
        public DownUseItemState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new DownUseItemSprite();
            

        }

        public void TakeDamage()
        {
            game.Link = new DamagedLink((Link)Link, game);

            //remains to be discussed
=======
﻿using Game1.Sprite;
using Game1.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game1.State
{
    internal class DownUseItemState : ILinkState
    {
        private Link link;

        public DownUseItemSprite GetSprite { get; set; }
        public DownUseItemState(Link link)
        {
            this.link = link;
            GetSprite = new DownUseItemSprite(link.position);

>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }
        //link has already faced up so no code for MoveUp()
        public void MoveUp()
        {
            
        }

        public void MoveDown()
        {
            

        }

        public void MoveLeft()
        {
            
        }

        public void MoveRight()
        {
            
        }

        public void Stop()
        {
<<<<<<< HEAD
            Link.State = new DownIdleState(Link,game);
=======
            link.state = new DownIdleState(link);
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }
        public void Attack()
        {
            
        }



        public void UseItem()
        {
            
        }


        public void Update()
        {
            GetSprite.Update();
<<<<<<< HEAD
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GetSprite.Draw(spriteBatch);
            if(Link.Item == 1)
            {
                this.game.ProjectileFactory.AddArrow(GlobalDefinitions.Position, new Vector2(0, 1));
            }
            if (Link.Item == 2)
            {
                this.game.ProjectileFactory.AddBomb(GlobalDefinitions.Position, new Vector2(0, 1));
            }
            if (Link.Item == 3)
            {
                this.game.ProjectileFactory.AddBoomer(GlobalDefinitions.Position, new Vector2(0, 1));
            }




=======
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }
    }
}
