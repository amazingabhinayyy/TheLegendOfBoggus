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
            roomLayout[mapX, mapY] = new RandomRooms(game1, roomNum);
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }

    }
}
