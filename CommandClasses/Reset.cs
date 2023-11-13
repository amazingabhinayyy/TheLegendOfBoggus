using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
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
            game1.link = new Link(game1);
            game1.linkDead = false;
            game1.gamePaused = false;
            RoomSecondary.ResetRooms();
            game1.room = new Room1(game1);
            //inventoryController = new InventoryController(this);
            game1.collisionDetector = new CollisionManager(game1, (Link)game1.link);
        }
    }
}
