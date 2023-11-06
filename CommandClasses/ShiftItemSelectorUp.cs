﻿using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class ShiftItemSelectorUp : ICommand
    {
        public ShiftItemSelectorUp() { }

        public void Execute()
        {
            InventoryController.ShiftCursorUp();
        }
    }
}
