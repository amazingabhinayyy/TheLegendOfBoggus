using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class SwitchToPreviousBlock : ICommand
    {
        private Game1 game;
        public SwitchToPreviousBlock(Game1 game) {
            this.game = game;
        }

        public void Execute()
        {
            game.Block.diamondTile();
        }
    }
}