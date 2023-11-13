﻿using Sprint2_Attempt3.Sounds;
using System;
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
            SoundFactory.PlaySound(SoundFactory.Instance.arrowBoomerang);
            this.game = game;
        }
        public void Execute()
        {
            game.link.UseBlueBoomerang();
        }
    }
}
