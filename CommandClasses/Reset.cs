using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System.Collections.Generic;
using System.Net.Mime;

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
            RoomSecondary.ResetRooms();
            TransitionHandler.Instance.TransitionGameObjectList = new List<IGameObject>();
            game1.Reset();
            //inventoryController = new InventoryController(this);
        }
    }
}
