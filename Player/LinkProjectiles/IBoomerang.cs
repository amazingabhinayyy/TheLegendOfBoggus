using Sprint2_Attempt3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkProjectiles
{
    public interface IBoomerang : ILinkProjectile
    {
        public void ReverseDirection();

    }
}
