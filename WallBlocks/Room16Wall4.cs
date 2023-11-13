﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class Room16Wall4 : IWall
    {
        public bool EnemyWalkable { get; } = true;
        Rectangle wall;
        public Room16Wall4()
        {
            wall = new Rectangle(200, 0 + Globals.YOffset, 600, 210);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
