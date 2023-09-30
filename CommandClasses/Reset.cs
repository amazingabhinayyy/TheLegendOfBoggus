﻿using Sprint2_Attempt3.Block;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class Reset : ICommand
    {
        private Game1 game1;
        public Reset(Game1 game) { 
            this.game1= game;
        }

        public void Execute()
        {
            game1.enemy = new Keese(200, 200);
            game1.enemy.Spawn();
            game1.Link = new Link();
            game1.Block = new BlueFloorBlock(Globals.BlockStartPosition);
        }
    }
}
