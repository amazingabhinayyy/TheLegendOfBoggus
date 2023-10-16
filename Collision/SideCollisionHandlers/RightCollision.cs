using Sprint2_Attempt3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.Collision.SideCollisionHandlers
{
    public class RightCollision : ICollision
    {
        public RightCollision() { }
        public void LinkEnemyKnockback(Link link)
        {
            link.position.X += 100;
        }
    }
}
