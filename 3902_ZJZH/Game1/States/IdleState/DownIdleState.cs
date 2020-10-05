<<<<<<< HEAD
﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
=======
﻿using Microsoft.Xna.Framework;
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f

namespace Game1
{
    public class DownIdleState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public DownIdleState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new DownIdleLinkSprite();
<<<<<<< HEAD

=======
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }
        //link has already faced up so no code for MoveUp()

        public void TakeDamage()
        {
            game.Link = new DamagedLink((Link)Link, game);

            //remains to be discussed
        }
        public void MoveUp()
        {
            Link.State = new UpMovingState(Link, game);
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.
<<<<<<< HEAD

        public void MoveDown()
        {
            Link.State = new DownMovingState(Link, game);


        }


        public void MoveLeft()
        {
            Link.State = new LeftMovingState(Link, game);

        }


        public void MoveRight()
        {
            Link.State = new RightMovingState(Link, game);

        }

        public void Stop()
        {
            // no-op
        }

        public void Attack()
        {
            Link.State = new DownWoodenSwordState(Link, game);

        }
        public void UseItem()
        {
            Link.State = new DownUseItemState(Link, game);
        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GetSprite.Draw(spriteBatch);

=======

        public void MoveDown()
        {
            Link.State = new DownMovingState(Link, game);
        }


        public void MoveLeft()
        {
            Link.State = new LeftMovingState(Link, game);

        }


        public void MoveRight()
        {
            Link.State = new RightMovingState(Link, game);

        }

        public void Stop()
        {
            // no-op
        }

        public void Attack()
        {
            Link.State = new DownWoodenSwordState(Link, game);

        }
        public void UseItem()
        {

        }

        public void Update()
        {
            GetSprite.Update();
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }
    }
}