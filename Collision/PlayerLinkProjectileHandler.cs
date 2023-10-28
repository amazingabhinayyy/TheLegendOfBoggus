using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Collision
{
    public class PlayerLinkProjectileHandler
    {
        public PlayerLinkProjectileHandler() { }
        public static void HandlePlayerLinkProjectileCollision(ILink link, ILinkProjectile linkProjectile, ICollision side)
        {
            if (linkProjectile is IBoomerang)
            {
                link.Items.Remove(linkProjectile);
                CollisionDetector.GameObjectList.Remove(linkProjectile);
            }
        }
    }
}
