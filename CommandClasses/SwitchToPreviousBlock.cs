﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Diagnostics;
using Sprint2;
//using System.Numerics;
//using System.Drawing;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class SwitchToPreviousBlock : ICommand
    {
        private Game1 game1;
        private Block block;
        private int blockIndex;
        public SwitchToPreviousBlock(Game1 game)
        {
            this.game1 = game;

        }

        public void Execute()
        {
            /*
            * TODO:
            * call switch to next item method
            */
            if (game1.blockIndex == 6)
            {
                game1.blockIndex -= 2;
            }
            if (game1.blockIndex >= 0)
            {
                game1.blockIndex--;
            }


            switch (game1.blockIndex)
            {
                case 0:
                    game1.Block.ChangeToPlainTile();
                    break;
                case 1:
                    game1.Block.ChangeToDiamondTile();
                    break;
                case 2:
                    game1.Block.ChangeToSideChunk();
                    break;
                case 3:
                    game1.Block.ChangeToUpChunk();
                    break;
                case 4:
                    game1.Block.ChangeToWhiteBrick(); ;
                    break;
                case 5:
                    game1.Block.ChangeToWhiteStairs();
                    break;
            }
        }

    }
}