using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.WallBlocks
{
    public  class SouthWestCollisionBlock : IWall
    {
        Rectangle wall;
        public SouthWestCollisionBlock()
        {
            wall = new Rectangle(453, 393, 347, 87);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
