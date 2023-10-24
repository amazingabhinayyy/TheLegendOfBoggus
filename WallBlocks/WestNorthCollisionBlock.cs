using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class WestNorthCollisionBlock : IWall
    {
        Rectangle wall;
        public WestNorthCollisionBlock()
        {
            wall = new Rectangle(0, 87, 105, 110);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
