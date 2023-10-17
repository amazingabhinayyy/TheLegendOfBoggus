﻿using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms.DungeonRooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            game1.link = new Link(game1);
            game1.room = new Room1(game1);
        }
    }
}
