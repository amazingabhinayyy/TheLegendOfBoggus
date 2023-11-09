using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class Room16Wall1 : IWall
    {
        public bool EnemyWalkable { get; } = true;
        Rectangle wall;
        public Room16Wall1()
        {
            wall = new Rectangle(602, 277 + Globals.YOffset, 398, 53);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
