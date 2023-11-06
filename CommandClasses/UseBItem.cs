﻿using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class UseBItem : ICommand
    {
        public Game1 game1;

        public UseBItem(Game1 game)
        {
            this.game1 = game;
        }

        public void Execute()
        {
            InventoryController.UseBItem();
        }
    }
}
