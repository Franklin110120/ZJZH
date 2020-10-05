using Game1.Command;
using Game1.Sprite_;
<<<<<<< HEAD
using Microsoft.Xna.Framework.Graphics;
=======
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f

namespace Game1
{
    public class LeftMovingState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public LeftMovingState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new LeftMovingLinkSprite();

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

        public void MoveDown()
        {
            Link.State = new DownMovingState(Link, game);
        }
<<<<<<< HEAD

        public void MoveLeft()
        {
        }


        public void MoveRight()
        {
            Link.State = new RightMovingState(Link, game);
        }

        public void Stop()
        {
            Link.State = new LeftIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
            Link.State = new LeftWoodenSwordState(Link, game);
        }
        public void UseItem()
        {
            Link.State = new LeftUseItemState(Link, game);
        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GetSprite.Draw(spriteBatch);

=======

        public void MoveLeft()
        {
        }


        public void MoveRight()
        {
            Link.State = new RightMovingState(Link, game);
        }

        public void Stop()
        {
            Link.State = new LeftIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
            Link.State = new LeftWoodenSwordState(Link, game);
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