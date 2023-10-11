using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Enemy;

namespace Sprint2_Attempt3
{
    internal class SwitchToPreviousDungeonRoom : ICommand
    {

        private Game1 game1;
        private static int roomIndex;

        public SwitchToPreviousDungeonRoom(Game1 game) {
            this.game1 = game;
        }

        public void Execute()
        {
            roomIndex = game1.keyController.RoomIndex;
            if (roomIndex >=1)
            {
                game1.dungeonRoom = Globals.rooms[roomIndex - 1];
                roomIndex--;
            }
            else
            {
                roomIndex = Globals.rooms.Length - 1;
                game1.dungeonRoom = Globals.rooms[Globals.rooms.Length-1];
            }
            game1.keyController.RoomIndex = roomIndex;
            game1.enemy.Spawn();
        }

    }
}
