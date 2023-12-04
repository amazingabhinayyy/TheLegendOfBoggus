using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System.Collections.Generic;
using System.Net.Mime;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class Reset : ICommand
    {
        private Game1 game1;
        private IRoom room;

        public Reset(Game1 game, IRoom room) { 
            this.game1= game;
            this.room = room;
        }

        public void Execute()
        {
            //room.ResetRooms();
            TransitionHandler.Instance.TransitionGameObjectList = new List<IGameObject>();
            ///game1.room = new Room1(game1);
            InventoryController.Reset();
            game1.Reset();
            room.ResetRooms();
        }
    }
}
