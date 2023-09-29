using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Zol;

namespace Sprint2_Attempt3
{
    internal class SwitchToPreviousEnemy : ICommand
    {

        private Game1 game1;
        private static IEnemy[] enemies = Globals.enemies; 
        private static int enemyIndex = 0;

        public SwitchToPreviousEnemy(Game1 game) {
            this.game1 = game;
        }

        public void Execute()
        {
            if(enemyIndex >=1)
            {
                game1.enemy = enemies[enemyIndex - 1];
                enemyIndex--;
            }
            else
            {
                enemyIndex = enemies.Length - 1;
                game1.enemy = enemies[enemies.Length-1];
            }
            game1.enemy.Spawn();
        }

    }
}
