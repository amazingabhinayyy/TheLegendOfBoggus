using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles;
using Sprint2_Attempt3.Items.ItemClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Sprint2_Attempt3.Enemy.Dodongo;

namespace Sprint2_Attempt3.Collision
{
    internal class EnemyLinkProjectileCollisionHandler
    {
        public EnemyLinkProjectileCollisionHandler() { }

        public static void HandleLinkProjectileEnemyCollision(IEnemy enemy, ILinkProjectile item, ICollision side, List<IGameObject> objects )
        {
            if(item is IBoomerang)
            {
                enemy.Stun();
                ((IBoomerang)item).ReverseDirection();
            }
            else if(item is IArrow)
            {
                enemy.Kill();
                IArrow arrow = (IArrow)item;
                arrow.DestroyArrow();
            }
            else if(item is IBomb && enemy is Dodongo)
            {
                ((Dodongo)enemy).ChangeAttackedStatus();
                ((IBomb)item).RemoveBomb();
            }
            else if(!(item is Bomb))
            {
                enemy.Kill();
            }
        }
    }
}
