﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Sprint2_Attempt3.Blocks;

namespace Sprint2_Attempt3.Blocks.BlockSprites
{
    public class BlackBlock : BlockSecondary
    {
        private static Rectangle src = new Rectangle(0, 17, 16, 16);
        public BlackBlock(Rectangle Position)
        {
            position = Position;
            sourceRectangle = src;
            isWalkable = false;
        }
    }
}
