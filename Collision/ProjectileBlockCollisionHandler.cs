using Sprint2_Attempt3.Player.LinkProjectiles;
using Sprint2_Attempt3.WallBlocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Collision
{
    public class ProjectileBlockCollisionHandler
    {
        public static void HandleProjectileBlockCollision(IProjectile projectile, IGameObject block, ICollision side)
        {
            if (projectile is IBoomerang)
            {
                ((IBoomerang)projectile).ReverseDirection();
            }
            else if (projectile is IArrow)
            {
                ((IArrow)projectile).DestroyArrow();
            }
            else if(projectile is IFire)
            {

            }
        }
    }
}
