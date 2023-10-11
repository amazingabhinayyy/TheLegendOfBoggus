using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3
{
    internal class SwitchToNextDungeonRoom : ICommand
    {
        private Game1 game1;
        private static int roomIndex;

        public SwitchToNextDungeonRoom(Game1 game)
        {
            this.game1 = game;
        }

        public void Execute()
        {
            roomIndex = game1.keyController.RoomIndex;
            if (roomIndex < Globals.rooms.Length - 1)
            {
                game1.dungeonRoom = Globals.rooms[roomIndex + 1];
                roomIndex++;
            }
            else
            {
                roomIndex = 0;
                game1.dungeonRoom = Globals.rooms[0];
            }
            game1.keyController.RoomIndex = roomIndex;
            game1.enemy.Spawn();
        }
    }
}