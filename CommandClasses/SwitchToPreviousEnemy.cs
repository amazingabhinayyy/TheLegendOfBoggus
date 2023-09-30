using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3
{
    internal class SwitchToPreviousEnemy : ICommand
    {

        private Game1 game1; 
        private static int enemyIndex;

        public SwitchToPreviousEnemy(Game1 game) {
            this.game1 = game;
        }

        public void Execute()
        {
            enemyIndex = game1.KeyController.EnemyIndex;
            if (enemyIndex >=1)
            {
                game1.enemy = Globals.enemies[enemyIndex - 1];
                enemyIndex--;
            }
            else
            {
                enemyIndex = Globals.enemies.Length - 1;
                game1.enemy = Globals.enemies[Globals.enemies.Length-1];
            }
            game1.KeyController.EnemyIndex = enemyIndex;
            game1.enemy.Spawn();
        }

    }
}
