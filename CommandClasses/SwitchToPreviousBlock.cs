using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Enemy;

namespace Sprint2_Attempt3
{
    internal class SwitchToPreviousBlock : ICommand
    {
        private Game1 game1;
        private static int blockIndex;

        public SwitchToPreviousBlock(Game1 game)
        {
            this.game1 = game;
        }

        public void Execute()
        {
            blockIndex = game1.KeyController.BlockIndex;
            if (blockIndex >= 1)
            {
                game1.Block = Globals.blocks[blockIndex - 1];
                blockIndex--;
            }
            else
            {
                blockIndex = Globals.blocks.Length - 1;
                game1.Block = Globals.blocks[Globals.blocks.Length - 1];
            }
            game1.KeyController.BlockIndex = blockIndex;
        }
    }
}