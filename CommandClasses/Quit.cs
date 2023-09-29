
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3
{
    internal class Quit : ICommand
    {
        private Game1 game1;
        public Quit(Game1 game1) {
            this.game1 = game1;
        }

        public void Execute() {
            this.game1.Exit();
        }
    }
}
