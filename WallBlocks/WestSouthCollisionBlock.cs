using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.WallBlocks
{
    public class WestSouthCollisionBlock : IWall    
    {
        Rectangle wall;
        public WestSouthCollisionBlock()
        {
            wall = new Rectangle(700, 287, 99, 106);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
