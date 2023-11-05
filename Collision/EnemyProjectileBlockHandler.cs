using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;
using Sprint2_Attempt3.Enemy.Projectile.GoriyaProjectiles;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.WallBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Collision
{
    public class EnemyProjectileBlockHandler
    {
        public static void HandleEnemyProjectileBlockCollision(IProjectile projectile, IGameObject block, ICollision side)
        {
            if (projectile is GoriyaBoomerang)
            {

            }
            if (projectile is AquamentusFireball)
            {
                ((IEnemyProjectile)projectile).Collided();
                //CollisionDetector.GameObjectList.Remove(projectile);
            }
        }
    }
}
