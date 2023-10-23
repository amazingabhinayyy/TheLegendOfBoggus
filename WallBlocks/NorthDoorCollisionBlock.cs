using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class NorthDoorCollisionBlock : IWall
    {
        Rectangle wall;
        public NorthDoorCollisionBlock()
        {
            wall = new Rectangle(0, 0, 800, 40);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
