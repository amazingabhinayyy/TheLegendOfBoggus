using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class RandomRooms : RoomSecondary
    {

        public RandomRooms(Game1 game, int roomNum) : base(game, roomNum)
        {
            gameObjectLists.Add(null);
        }
        public override void SwitchToNorthRoom()
        {
            mapY -= 1;
            if (roomLayout[mapX,mapY] == null)
            {
                int roomNum = RandomRoomCreator.Instance.CreateRandomRoom();
                gameObjectLists[roomNum] = RoomGenerator.Instance.LoadFile(roomNum);
                roomLayout[mapX, mapY] = new RandomRooms(game1, roomNum);
            }

            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, roomLayout[mapX, mapY]);
            currentRoomNumber = roomLayout[mapX, mapY].RoomNumber;
            TransitionHandler.Instance.TransitionGameObjectList = gameObjectLists[currentRoomNumber];
        }
        public override void SwitchToSouthRoom()
        {
            mapY += 1;
            if (roomLayout[mapX, mapY] == null)
            {
                int roomNum = RandomRoomCreator.Instance.CreateRandomRoom();
                gameObjectLists[roomNum] = RoomGenerator.Instance.LoadFile(roomNum);
                roomLayout[mapX, mapY] = new RandomRooms(game1, roomNum);
            }
            currentRoomNumber = roomLayout[mapX, mapY].RoomNumber;
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.TransitionGameObjectList = gameObjectLists[currentRoomNumber];
            TransitionHandler.Instance.Transition(this, roomLayout[mapX, mapY]);
        }
        public override void SwitchToEastRoom()
        {
            mapX += 1;
            if (roomLayout[mapX, mapY] == null)
            {
                int roomNum = RandomRoomCreator.Instance.CreateRandomRoom();
                gameObjectLists[roomNum] = RoomGenerator.Instance.LoadFile(roomNum);
                roomLayout[mapX, mapY] = new RandomRooms(game1, roomNum);
            }
            currentRoomNumber = roomLayout[mapX, mapY].RoomNumber;
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.TransitionGameObjectList = gameObjectLists[currentRoomNumber];
            TransitionHandler.Instance.Transition(this, roomLayout[mapX, mapY]);
        }
        public override void SwitchToWestRoom()
        {
            mapX -= 1;
            if (roomLayout[mapX, mapY] == null)
            {
                int roomNum = RandomRoomCreator.Instance.CreateRandomRoom();
                gameObjectLists[roomNum] = RoomGenerator.Instance.LoadFile(roomNum);
                roomLayout[mapX, mapY] = new RandomRooms(game1, roomNum);
            }
            currentRoomNumber = roomLayout[mapX, mapY].RoomNumber;
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.TransitionGameObjectList = gameObjectLists[currentRoomNumber];
            TransitionHandler.Instance.Transition(this, roomLayout[mapX, mapY]);
        }
    }
}
