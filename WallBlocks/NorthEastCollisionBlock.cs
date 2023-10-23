using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.WallBlocks
{
    public class NorthEastCollisionBlock : IWall
    {
        Rectangle wall;
        public NorthEastCollisionBlock()
        {
            wall = new Rectangle(0, 0, 348, 62);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
