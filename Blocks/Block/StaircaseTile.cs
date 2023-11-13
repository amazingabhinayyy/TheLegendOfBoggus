﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Blocks;

namespace Sprint2_Attempt3.Blocks.BlockSprites
{
    public class StaircaseTile : BlockSecondary
    {
        public StaircaseTile(Rectangle Position)
        {
            position = Position;
            sourceRectangle = Globals.staircaseScr;
            isWalkable = true;
        }
    }
}