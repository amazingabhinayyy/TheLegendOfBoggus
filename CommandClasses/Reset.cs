using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.CommandClasses
{
    internal class Reset : ICommand
    {
        public Game1 game1;

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
