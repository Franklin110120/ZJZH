<<<<<<< HEAD
﻿using Game1.Command;
using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class UpUseItemState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public IProjectile Arrow { get; set; }
        public UpUseItemState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new UpUseItemSprite();
            

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
    internal class UpUseItemState : ILinkState
    {
        private Link link;

        public UpUseItemSprite GetSprite { get; set; }
        public UpUseItemState(Link link)
        {
            this.link = link;
            GetSprite = new UpUseItemSprite(link.position);

>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }
        //link has already faced up so no code for MoveUp()
        public void MoveUp()
        {
<<<<<<< HEAD

=======
            
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }

        public void MoveDown()
        {
<<<<<<< HEAD

=======
            
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f

        }

        public void MoveLeft()
        {
<<<<<<< HEAD

=======
            
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }

        public void MoveRight()
        {
<<<<<<< HEAD

=======
            
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }

        public void Stop()
        {
<<<<<<< HEAD
            Link.State = new UpIdleState(Link, game);
        }
        public void Attack()
        {

=======
            link.state = new UpIdleState(link);
        }
        public void Attack()
        {
            
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }



        public void UseItem()
        {
<<<<<<< HEAD

=======
            
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }


        public void Update()
        {
            GetSprite.Update();
<<<<<<< HEAD
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GetSprite.Draw(spriteBatch);

            if (Link.Item == 1)
            {
                this.game.ProjectileFactory.AddArrow(GlobalDefinitions.Position, new Vector2(0, -1));
            }
            if (Link.Item == 2)
            {
                this.game.ProjectileFactory.AddBomb(GlobalDefinitions.Position, new Vector2(0, -1));
            }
            if (Link.Item == 3)
            {
                this.game.ProjectileFactory.AddBoomer(GlobalDefinitions.Position,new Vector2(0, -1));
            }


        }
    }
}
=======
        }
    }
}
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
