using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Enemy.Keese;

namespace Sprint2_Attempt3
{
    internal class Reset : ICommand
    {
        private Game1 game1;
        public Reset(Game1 game)
        {
            this.game1 = game;
        }

        public void Execute() {
            this.game1.enemy = new Keese();
            this.game1.enemy.Spawn();
        }
    }
}
