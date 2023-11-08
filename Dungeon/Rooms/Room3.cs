﻿using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room3 : RoomSecondary
    {
        public Room3(Game1 game1) : base(game1, 2) { }

        public override void SwitchToWestRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, new Room1(game1));
           
        }

    }
}
