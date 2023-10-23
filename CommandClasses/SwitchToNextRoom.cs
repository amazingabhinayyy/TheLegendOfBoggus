using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Dungeon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class SwitchToNextRoom : ICommand
    {
        Game1 game1;
        private static IRoom[] rooms;
        private static int roomCount = 0;
        public SwitchToNextRoom(Game1 game1) { 
                this.game1 = game1;
            rooms = new IRoom[] {
                new Room1(game1),
                new Room2(game1),
                new Room3(game1),
                new Room4(game1),
                new Room5(game1),
                new Room6(game1),
                new Room7(game1),
                new Room8(game1),
                new Room9(game1),
                new Room10(game1),
                new Room11(game1),
                new Room12(game1),
                new Room13(game1),
                new Room14(game1),
                new Room15(game1),
                new Room16(game1),
                new Room17(game1),
                new Room18(game1)
            };
        }
        public void Execute()
        {
            this.game1.room.SwitchToNextRoom();
        }
    }
}
