using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room7 : RoomSecondary
    {
        public Room7(Game1 game1) : base(game1, 6) { }
        public override void SwitchToNorthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room11(game1));
            for (int i = 0; i < gameObjectLists[10].Count; i++)
            {
                IGameObject obj = gameObjectLists[10][i];
                if (obj is SouthDoor)
                {
                    if (((SouthDoor)obj).IsBombWall)
                    {
                        ((SouthDoor)obj).Damage();
                    }
                    break;
                }
            }
        }
        public override void SwitchToWestRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room6(game1));
        }

    }
}
