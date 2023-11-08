﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Sprint2_Attempt3.Dungeon
{
    public abstract class RoomSecondary : IRoom
    {
        protected static List<IGameObject>[] gameObjectLists = new List<IGameObject>[18];
        protected static int roomNumber;
        protected static int enemyKillCount = 0;
        protected Boolean spawned = false;
        public static bool ClockUsed { get; set; } = false;
        protected DungeonRoom room;
        protected Game1 game1;
        protected CollisionDetector collisionDetector;

        public RoomSecondary(Game1 game, int roomNum) {
            this.game1 = game;
            room = new DungeonRoom();
            roomNumber = roomNum;
            spawned = false;
            if (gameObjectLists[roomNumber] == null)
            {
                
                gameObjectLists[roomNumber] = RoomGenerator.Instance.LoadFile(roomNumber);
                //gameObjectLists[roomNumber] = RoomGenerator.Instance.LoadFile(roomNumber);

                gameObjectLists[roomNumber].Add(this.game1.link);
                InventoryController.VisitRoom(roomNum);
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
               
            
            if (game1.link is DamageLinkDecorator)
            {
                ((DamageLinkDecorator)game1.link).RemoveDecorator();
            }

            ClockUsed = false;
            collisionDetector = new CollisionDetector(game1, game1.link);
            if (TransitionHandler.Instance.TransitionGameObjectList.Count == 0)
            {
                CollisionDetector.GameObjectList = gameObjectLists[roomNumber];
            }
            TransitionHandler.Instance.TransitionGameObjectList = gameObjectLists[roomNumber];

            
        }

        public void SwitchToNextRoom() {
            if (roomNumber < gameObjectLists.Length - 1)
            {
                roomNumber++;
            }
            else
            {
                roomNumber = 0;
            }
            ClockUsed = false;
            InventoryController.VisitRoom(roomNumber);
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];
        }

        public void SwitchToPrevRoom()
        {
            if (roomNumber <= 0)
            {
                roomNumber= gameObjectLists.Length-1;
            }
            else
            {
                roomNumber--;
            }
            ClockUsed = false;
            InventoryController.VisitRoom(roomNumber);
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];
        }
        public void Update() {
            if (!TransitionHandler.Instance.Start)
            {
                collisionDetector.Update();

                for (int i = 0; i < gameObjectLists[roomNumber].Count; i++)
                {
                    IGameObject obj = gameObjectLists[roomNumber][i];
                    if (obj is IEnemy)
                    {
                        if (!ClockUsed || ((IEnemy)obj).State is DeathAnimationState)
                            ((IEnemy)obj).Update();
                        if (!spawned)
                        {
                            ((IEnemy)obj).Spawn();
                        }
                    }
                    else if (obj is IItem)
                    {
                        ((IItem)obj).Update();
                        if (((IItem)obj).exists)
                        {
                            ((IItem)obj).Spawn();
                        }
                    }
                }
                spawned = true;

                game1.link.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch) {
            if (TransitionHandler.Instance.Start)
            {
                TransitionHandler.Instance.Draw(spriteBatch);
            }
            else
            {
                room.Draw(spriteBatch);

                foreach (IGameObject obj in gameObjectLists[roomNumber])
                {
                    if (obj is IEnemy)
                        ((IEnemy)obj).Draw(spriteBatch);
                    else if (obj is IItem)
                        ((IItem)obj).Draw(spriteBatch);
                    else if (obj is IBlock)
                        ((IBlock)obj).Draw(spriteBatch);
                    else if (obj is IDoor)
                        ((IDoor)obj).Draw(spriteBatch);
                }

                game1.link.Draw(spriteBatch, Color.White);
            }
        }

        public static int GetCurrentRoomNumber() { 
            return roomNumber;
        }
        public DungeonRoom getDungeonRoom()
        {
            return room;
        }
        public virtual void SwitchToNorthRoom() { }
        public virtual void SwitchToSouthRoom() { }
        public virtual void SwitchToEastRoom() { }
        public virtual void SwitchToWestRoom() { }
        
    }
}
