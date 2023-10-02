﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    public class SetUseBlueBoomerangCommand : ICommand
    {
        private Game1 game;
        public SetUseBlueBoomerangCommand(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            game.Link.UseBlueBoomerang();
        }
    }
}
