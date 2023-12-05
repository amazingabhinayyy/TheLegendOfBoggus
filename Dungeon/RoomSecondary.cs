﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Blocks.Block;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.WallBlocks;
using System;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon
{
    public abstract class RoomSecondary : IRoom
    {
        private static IRoom[] rooms = new IRoom[19];
        public List<IGameObject> gameObjectList { get; set; }
        protected static IRoom[,] roomLayout;
        protected static int mapY = 11;
        protected static int mapX = 5;
        protected static int numRoomsLoaded = 0;

        public static int currentRoomNumber { get; protected set; }
        public int RoomNumber { get; }

        //protected static Boolean varHoldingTrue = true;
        protected Boolean spawned = false;
        public static bool ClockUsed { get; set; } = false;
        public IDungeonRoom room { get; protected set; }
        protected Game1 game1;
        protected static CollisionManager collisionManager;

        public RoomSecondary(Game1 game, int roomNum)
        {
            this.game1 = game;
            room = new DungeonRoom();
            //currentRoomNumber = roomNum;
            RoomNumber = roomNum;
            spawned = false;
            gameObjectList = new List<IGameObject>();
            numRoomsLoaded++;

            gameObjectList = RoomGenerator.Instance.LoadFile(RoomNumber);
            gameObjectList.Add(this.game1.link);
            if (roomNum != 15)
            {
                gameObjectList.AddRange(IWall.WallBlocks);
            }

            if (game1.link is DamageLinkDecorator)
            {
                ((DamageLinkDecorator)game1.link).RemoveDecorator();
            }

            collisionManager = new CollisionManager(game1, game1.link);


            if (TransitionHandler.Instance.TransitionGameObjectList.Count == 0)
            {
                CollisionManager.GameObjectList = gameObjectList;
            }
            TransitionHandler.Instance.TransitionGameObjectList = gameObjectList;

            if (Room16TransitionHandler.Instance.TransitionGameObjectList.Count == 0)
            {
                CollisionManager.GameObjectList = gameObjectList;
            }
            Room16TransitionHandler.Instance.TransitionGameObjectList = gameObjectList;

        }

        public virtual void Update() {
            if (Room16TransitionHandler.Instance.Start)
            {
                Room16TransitionHandler.Instance.Update();
            }
            else if (!TransitionHandler.Instance.Start)
            {
                if(!game1.deathAnimationActive)
                    collisionManager.Update();

                for (int i = 0; i < gameObjectList.Count; i++)
                {
                    IGameObject obj = gameObjectList[i];
                    if (obj is IEnemy)
                    {
                        if (!spawned)
                        {
                            ((IEnemy)obj).Spawn();
                        }
                        if (!ClockUsed || ((IEnemy)obj).State is DeathAnimationState)
                            ((IEnemy)obj).Update();

                    }
                    else if (obj is IItem)
                    {
                        ((IItem)obj).Update();
                    }
                    else if (obj is IBlock)
                        ((IBlock)obj).Update();
                }
                spawned = true;

                game1.link.Update();
                RoomConditionCheck();
            }
        }
        public void Draw(SpriteBatch spriteBatch, Color color) {
            if (TransitionHandler.Instance.Start)
            {
                TransitionHandler.Instance.Draw(spriteBatch);
            }
            else if (Room16TransitionHandler.Instance.Start)
            {
                Room16TransitionHandler.Instance.Draw(spriteBatch);

            }
            else
            {
                room.Draw(spriteBatch, color);
                List<IEnemy> enemyList = new List<IEnemy>();

                foreach (IGameObject obj in gameObjectList)
                {
                    if (obj is IItem && color.Equals(Color.White))
                        ((IItem)obj).Draw(spriteBatch);
                    else if (obj is IBlock)
                        ((IBlock)obj).Draw(spriteBatch, color);
                    else if (obj is IDoor)
                        ((IDoor)obj).Draw(spriteBatch, color);
                    else if (obj is IEnemy && color.Equals(Color.White))
                        enemyList.Add((IEnemy)obj);

                }
                foreach (IEnemy enemy in enemyList)
                    enemy.Draw(spriteBatch);

                game1.link.Draw(spriteBatch, Color.White);
            }
        }
        public void ResetRooms() {
            numRoomsLoaded = 0;
            game1.room = LoadRooms(game1);

            mapX = 5;
            mapY = 11;
        }
        public static IRoom LoadRooms(Game1 game1)
        {
            roomLayout = new IRoom[12, 12];
            rooms = new IRoom[18] {new Room1(game1), new Room2(game1), new Room3(game1), new Room4(game1), new Room5(game1), new Room6(game1), new Room7(game1), new Room8(game1), new Room9(game1), new Room10(game1), new Room11(game1), new Room12(game1), new Room13(game1), new Room14(game1), new Room15(game1), new Room16(game1), new Room17(game1), new Room18(game1)};
            currentRoomNumber = rooms[0].RoomNumber;
            return rooms[0];
        }
        public void SwitchRoom()
        {
            TransitionHandler.Instance.Start = true;
            TransitionHandler.Instance.Transition(this, roomLayout[mapX, mapY]);
            currentRoomNumber = roomLayout[mapX, mapY].RoomNumber;
            MapController.VisitRoom(currentRoomNumber);
            game1.room = roomLayout[mapX, mapY];
            ClockUsed = false;

            TransitionHandler.Instance.TransitionGameObjectList = roomLayout[mapX, mapY].gameObjectList;
            Room16TransitionHandler.Instance.TransitionGameObjectList = roomLayout[mapX, mapY].gameObjectList;
        }
        public DungeonRoom getDungeonRoom()
        {
            return (DungeonRoom)room;
        }

        public IDungeonRoom getIDungeonRoom()
        {
            return (IDungeonRoom)room;
        }
        public void SetDecorator(IRoom room)
        {
            game1.room = room;
        }
        protected static bool allEnemiesKilledInRoom(List<IEnemy> enemies)
        {
            bool enemiesKilled = true;
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].exists)
                {
                    enemiesKilled = false;
                    break;
                }
            }
            return enemiesKilled;
        }
        public virtual void SwitchToNorthRoom() { }
        public virtual void SwitchToSouthRoom() { }
        public virtual void SwitchToEastRoom() { }
        public virtual void SwitchToWestRoom() { }
        public virtual void SwitchToLowerRoom() { }
        public virtual void SwitchToUpperRoom() { }
        public virtual void RoomConditionCheck() { }

    }
}
