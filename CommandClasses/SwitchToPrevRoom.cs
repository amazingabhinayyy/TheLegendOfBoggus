using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Dungeon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class SwitchToPrevRoom : ICommand
    {
        Game1 game1;

            public SwitchToPrevRoom(Game1 game1) { 
                this.game1 = game1;

        }
        public void Execute()
        {
            this.game1.room.SwitchToPrevRoom();
        }
    }
}
