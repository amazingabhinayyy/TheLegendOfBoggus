using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.WallBlocks
{
    internal class EastSouthCollisionBlock : IWall
    {
        Rectangle wall;
        public EastSouthCollisionBlock()
        {
            wall = new Rectangle(0, 287, 98, 106);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
