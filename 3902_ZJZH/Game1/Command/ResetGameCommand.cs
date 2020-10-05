using Microsoft.Xna.Framework;
using System;

namespace Game1.Command
{
    class ResetGameCommand : ICommand
    {
        private MainStage gameInstance;

        public ResetGameCommand(Game instance)
        {
            gameInstance = (MainStage) instance ?? throw new ArgumentNullException(nameof(instance));
        }

        public void Execute()
        {
<<<<<<< HEAD

        }
        public void Stop()
        {

=======
            gameInstance.ResetState();
            gameInstance.ResetElapsedTime();
        }

        public void Stop()
        {
            // Do nothing
>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
        }
    }
}