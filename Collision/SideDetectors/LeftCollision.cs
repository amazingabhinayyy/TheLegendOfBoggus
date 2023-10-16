using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Collision.SideDetectors
{
    public class LeftCollision : ICollision
    {
        public LeftCollision() { }

        public void LinkEnemyKnockback(Link link)
        {
            link.position.X -= 100;
        }
    }
}
