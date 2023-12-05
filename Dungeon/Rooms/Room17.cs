using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room17 : RoomSecondary
    {
        public Room17(Game1 game1) : base(game1, 16) { }

        public override void SwitchToEastRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room18(game1));
        }

        public override void SwitchToLowerRoom()
        {
            Room16TransitionHandler.Instance.Start = true;
            Room16TransitionHandler.Instance.Transition(this, new Room16(game1));
        }
    }
}
