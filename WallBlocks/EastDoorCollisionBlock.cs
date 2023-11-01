using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class EastDoorCollisionBlock : IWall
    {
        Rectangle wall;
        public EastDoorCollisionBlock()
        {
            wall = new Rectangle(0, 0 + Globals.YOffset, 50, 550);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
