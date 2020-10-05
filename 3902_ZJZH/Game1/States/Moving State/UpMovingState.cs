using Game1.Command;
<<<<<<< HEAD:Game1/States/Moving State/UpMovingState.cs
using Microsoft.Xna.Framework.Graphics;
=======
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f:Game1/UpMovingState.cs

namespace Game1
{
    public class UpMovingState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public UpMovingState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new UpMovingLinkSprite();

        }
        //link has already faced up so no code for MoveUp()

        public void TakeDamage()
        {
            game.Link = new DamagedLink((Link)Link, game);

            //remains to be discussed
        }
        public void MoveUp()
        {

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.

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
            Link.State = new UpIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
            Link.State = new UpWoodenSwordState(Link, game);
        }
        public void UseItem()
        {
<<<<<<< HEAD:Game1/States/Moving State/UpMovingState.cs
            Link.State = new UpUseItemState(Link, game);
=======
            
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f:Game1/UpMovingState.cs
        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GetSprite.Draw(spriteBatch);

        }
    }
}