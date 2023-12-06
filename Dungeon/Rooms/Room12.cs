﻿using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class Room12 : RoomSecondary
    {
        HandCreator handCreator;
        private bool firstTime;
        public Room12(Game1 game1) : base(game1, 11) 
        {
            roomLayout[7, 8] = this;
            handCreator = new HandCreator();
            gameObjectList.Add(handCreator);
            firstTime= true;
        }
        public override void Update()
        {
            if (FadingTransitionHandler.Instance.Start)
            {
                firstTime = true;
                FadingTransitionHandler.Instance.Update();
            }
            else if (!PanningTransitionHandler.Instance.Start)
            {
                if (firstTime)
                {
                    for (int k = (gameObjectList.Count - 1); k >= 0; k--)
                    {
                        IGameObject obj = gameObjectList[k];
                        if (obj is Hand)
                        {
                            gameObjectList.RemoveAt(k);
                        }
                        else if (obj is HandCreator)
                        {
                            ((HandCreator)obj).Clear();
                        }
                    }
                    firstTime = false;
                }
                List<Hand> handList = handCreator.AddHands();
                for (int j = 0; j < handList.Count; j++)
                {
                    gameObjectList.Add(handList[j]);
                }
                for (int i = 0; i < gameObjectList.Count; i++)
                {
                    IGameObject obj = gameObjectList[i];
                    if (obj is IEnemy)
                    {
                        if (!spawned)
                            ((IEnemy)obj).Spawn();
                        if (!ClockUsed || ((IEnemy)obj).State is DeathAnimationState)
                            ((IEnemy)obj).Update();
                    }
                    else if (obj is IItem)
                        ((IItem)obj).Update();
                    else if (obj is IBlock)
                        ((IBlock)obj).Update();
                    else if (obj is HandCreator)
                        ((HandCreator)obj).Update();
                }
                spawned = true;
                game1.link.Update();
                RoomConditionCheck();
            }
        }
        public override void SwitchToNorthRoom()
        {
            firstTime = true;
            mapY -= 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }
        public override void SwitchToWestRoom()
        {
            firstTime = true;
            mapY -= 1;
            SwitchRoom(mapX, mapY, PanningTransitionHandler.Instance);
        }

    }
}
/*Enemy,Hand,120,132,
Enemy,Hand,342,243,
Enemy,Hand,534,312,
Enemy,Hand,120,321,
Enemy,Hand,321,231,
Enemy,Hand,456,187,
Enemy,Hand,345,276,
Enemy,Hand,608,157,
*/
