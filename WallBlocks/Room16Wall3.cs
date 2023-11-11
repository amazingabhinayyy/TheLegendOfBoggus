﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.WallBlocks
{
    public class Room16Wall3 : IWall
    {
        public bool EnemyWalkable { get; } = true;
        Rectangle wall;
        public Room16Wall3()
        {
            wall = new Rectangle(200, 0 + Globals.YOffset, 152, 330);
        }
        public Rectangle GetHitBox()
        {
            return wall;
        }
        public void Update() { }
    }
}
