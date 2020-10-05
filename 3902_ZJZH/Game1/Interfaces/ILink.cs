using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public interface ILink
    {
<<<<<<< HEAD
         ILinkState State { get; set; }
        int Item { get; set; }
=======
        ILinkState State { get; set; }
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f

        void TakeDamage();
        void MoveLeft();
        void MoveUp();

        void MoveDown();
        void MoveRight();
        void Stop();
        void Attack();
        void Update();
<<<<<<< HEAD
        void UseItem(int Item);
=======
        void UseItem();

        void Reset();
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
    }
}
