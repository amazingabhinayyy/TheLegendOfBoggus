using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Sprint2;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3
{
    
    internal class SwitchToNextBlock : ICommand
    {
        private Game1 game;
        public SwitchToNextBlock(Game1 g) {
            this.game = g;
    }

        public void Execute()
        {
            game.Block.CreatePlainTile();
        }
    }
}