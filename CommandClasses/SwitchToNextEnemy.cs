using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Zol;
using Sprint2_Attempt3.Enemy.Dodongo;

namespace Sprint2_Attempt3
{
    internal class SwitchToNextEnemy : ICommand
    {
        private Game1 game1;
        private static IEnemy[] enemies = { new Keese(), new Rope(), new Gel(), new Zol(), new SpikeTrap(), new Dodongo() };
        private static int enemyIndex = 0;

        public SwitchToNextEnemy(Game1 game)
        {
            this.game1 = game;
        }

        public void Execute()
        {
            if (enemyIndex < enemies.Length - 1)
            {
                game1.enemy = enemies[enemyIndex + 1];
                enemyIndex++;
            }
            else
            {
                enemyIndex = 0;
                game1.enemy = enemies[0];
            }
            game1.enemy.Spawn();
        }
    }
}