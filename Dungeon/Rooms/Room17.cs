﻿using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room17 : RoomSecondary
    {
        public Room17(Game1 game1) : base(game1, 16) 
        {
            roomLayout[4, 6] = this;
        }

        public override void SwitchToEastRoom()
        {
            mapX += 1;
            SwitchRoom(mapX, mapY);
        }

        public override void SwitchToLowerRoom()
        {
            mapY += 1;
            Room16TransitionHandler.Instance.Start = true;
            Room16TransitionHandler.Instance.Transition(this, roomLayout[mapX, mapY]);
            currentRoomNumber = roomLayout[mapX, mapY].RoomNumber;
            MapController.VisitRoom(currentRoomNumber);
            game1.room = roomLayout[mapX, mapY];
            ClockUsed = false;
            Room16TransitionHandler.Instance.TransitionGameObjectList = roomLayout[mapX, mapY].gameObjectList;
        }
    }
}
