using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Player.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Collision
{
    internal class EnemyItemCollisionHandler
    {
        public EnemyItemCollisionHandler() { }

        public static void HandleItemEnemyCollision(IEnemy enemy, ILinkItem item, ICollision side)
        {
            if(item is IBoomerang)
            {
                
            }
            else
            {
                enemy.Kill();
            }
        }
    }
}
