using System;
using System.Collections.Generic;
using System.Linq;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3
{
    
    internal class SwitchToNextBlock : ICommand
    {
        private Game1 game1;
        private static int blockIndex;

        public SwitchToNextBlock(Game1 game)
        {
            this.game1 = game;
        }

        public void Execute()
        {
            blockIndex = game1.KeyController.BlockIndex;
            if (blockIndex < Globals.blocks.Length - 1)
            {
                game1.Block = Globals.blocks[blockIndex + 1];
                blockIndex++;
            }
            else
            {
                blockIndex = 0;
                game1.Block = Globals.blocks[blockIndex];
            }
            game1.KeyController.BlockIndex = blockIndex;
        }
    }
}