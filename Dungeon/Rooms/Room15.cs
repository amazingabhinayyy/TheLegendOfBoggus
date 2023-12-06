﻿using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room15 : RoomSecondary
    {
        public Room15(Game1 game1) : base(game1, 14) 
        {
            roomLayout[8, 7] = this;
        }

        public override void SwitchToWestRoom()
        {
            mapX -= 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToSouthRoom()
        {
            mapY += 1;
            int roomNum = RandomRoomCreator.Instance.CreateRandomRoom(roomLayout, mapX, mapY);
            gameObjectList = RoomGenerator.Instance.LoadFile(roomNum);
            roomLayout[mapX, mapY] = new RandomRooms(game1, roomNum);
            PanningTransitionHandler.Instance.Start = true;
            PanningTransitionHandler.Instance.Transition(this, roomLayout[mapX, mapY]);
        }

        public override void SwitchToNorthRoom()
        {
            mapY -= 1;
            locationMapTrackerRec.Y -= positionMapYUpdaterValue;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);

        }

    }
}
