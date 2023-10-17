using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Collision
{
    internal class PlayerEnemyHandler
    {
        public static void HandlePlayerEnemyCollision(ILink link, IEnemy enemy, ICollision side)
        {
            if(enemy is Hand)
            {
               // link.Leave();
            } else {
                //link.Knockback();
                link.GetDamaged();
            }
        }
    }
}
