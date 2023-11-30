using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room10 : RoomSecondary
    {
        public Room10(Game1 game1) : base(game1, 9) 
        {
            roomLayout[5, 8] = this;
        }

        public override void SwitchToNorthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room13(game1));
            mapY -= 1;
        }
        public override void SwitchToSouthRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room6(game1));
            for (int i = 0; i < gameObjectLists[5].Count; i++)
            {
                IGameObject obj = gameObjectLists[5][i];
                if (obj is NorthDoor)
                {
                    if (((NorthDoor)obj).IsBombWall)
                    {
                        ((NorthDoor)obj).Damage();
                    }
                    break;
                }
            }
            mapY += 1;
        }
        public override void SwitchToEastRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room11(game1));
            mapX += 1;
        }
        public override void SwitchToWestRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room9(game1));
            mapX -= 1;
        }

    }
}
