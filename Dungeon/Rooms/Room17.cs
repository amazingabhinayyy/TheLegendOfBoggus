using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room17 : RoomSecondary
    {
        public Room17(Game1 game1)
        {
            this.game1 = game1;
            room = new DungeonRoom();
            roomNumber = 16;
            if (gameObjectLists[roomNumber] == null)
            {
                gameObjectLists[roomNumber] = RoomGenerator.Instance.LoadFile(roomNumber);
            }

            foreach (IGameObject obj in gameObjectLists[roomNumber])
            {
                if (obj is IEnemy)
                {
                    ((IEnemy)obj).Spawn();
                }
                else if (obj is IItem)
                {
                    if (((IItem)obj).exists)
                    {
                        ((IItem)obj).Spawn();
                    }
                }
            }
        }
        public override void SwitchToNorthRoom()
        {
            roomNumber = 1;
        }
        public override void SwitchToSouthRoom()
        {
            roomNumber = 1;
        }
        public override void SwitchToEastRoom()
        {
            roomNumber = 1;
        }
        public override void SwitchToWestRoom()
        {
            roomNumber = 1;
        }

    }
}
