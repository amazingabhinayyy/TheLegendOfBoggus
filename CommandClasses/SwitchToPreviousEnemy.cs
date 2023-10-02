using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Enemy;

namespace Sprint2_Attempt3
{
    internal class SwitchToPreviousEnemy : ICommand
    {

        private Game1 game1;
        private static IEnemy[] enemies = Globals.enemies; 
        private static int enemyIndex;

        public SwitchToPreviousEnemy(Game1 game) {
            this.game1 = game;
        }

        public void Execute()
        {
            enemyIndex = game1.KeyController.EnemyIndex;
            if (enemyIndex >=1)
            {
                game1.enemy = enemies[enemyIndex - 1];
                enemyIndex--;
            }
            else
            {
                enemyIndex = enemies.Length - 1;
                game1.enemy = enemies[enemies.Length-1];
            }
            game1.KeyController.EnemyIndex = enemyIndex;
            game1.enemy.Spawn();
        }

    }
}
