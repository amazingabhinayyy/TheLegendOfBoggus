using Microsoft.Xna.Framework;
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
using System.Reflection.Metadata.Ecma335;

namespace Sprint2_Attempt3.Dungeon
{
    public abstract class RoomSecondary : IRoom
    {
        protected static List<IGameObject>[] gameObjectLists = new List<IGameObject>[18];
        protected static int[] enemiesKilledList = new int[18];
        protected static Boolean[] uniqueEventsForRooms = { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };
        public static bool UniqueEventsForRooms { get { return uniqueEventsForRooms[roomNumber]; } set { uniqueEventsForRooms[roomNumber] = value; } }
        public static int[] EnemiesKilledList { get { return enemiesKilledList; } set { enemiesKilledList = value; } }
        public List<IGameObject>[] GameObjectLists { get { return gameObjectLists; } set { gameObjectLists = value; } }
        protected static int roomNumber;

        private int enemyKillCount = 0;
        public  int EnemyKillCount { get { return enemyKillCount; } set { enemyKillCount = value; } }
        protected static Boolean varHoldingTrue = true;
        protected Boolean spawned = false;
        public static bool ClockUsed { get; set; } = false;
        protected IDungeonRoom room;
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
                if (roomNum != 15)
                {
                    gameObjectLists[roomNumber].AddRange(Globals.WallBlocks);
                }
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
            room = new DungeonRoom();

            if (gameObjectLists[roomNumber] == null)
            {
                gameObjectLists[roomNumber] = RoomGenerator.Instance.LoadFile(roomNumber);
                gameObjectLists[roomNumber].Add(this.game1.link);
                if (roomNumber != 15)
                {
                    gameObjectLists[roomNumber].AddRange(Globals.WallBlocks);
                }
                else {
                    room = new WhiteStairRoom();
                }
                InventoryController.VisitRoom(roomNumber);
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
            InventoryController.VisitRoom(roomNumber);
            TransitionHandler.Instance.TransitionGameObjectList = new List<IGameObject>();
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];
            game1.link.Items.Clear();
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
            room = new DungeonRoom();
            if (gameObjectLists[roomNumber] == null)
            {
                gameObjectLists[roomNumber] = RoomGenerator.Instance.LoadFile(roomNumber);
                gameObjectLists[roomNumber].Add(this.game1.link);
                if (roomNumber != 15)
                {
                    gameObjectLists[roomNumber].AddRange(Globals.WallBlocks);
                }
                else
                {
                    room = new WhiteStairRoom();
                }
                InventoryController.VisitRoom(roomNumber);
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
            InventoryController.VisitRoom(roomNumber);
            TransitionHandler.Instance.TransitionGameObjectList = new List<IGameObject>();
            CollisionDetector.GameObjectList = gameObjectLists[roomNumber];
            game1.link.Items.Clear();
        }
        public virtual void Update() {
            if (!TransitionHandler.Instance.Start)
            {
                collisionDetector.Update();

                for (int i = 0; i < gameObjectLists[roomNumber].Count; i++)
                {
                    IGameObject obj = gameObjectLists[roomNumber][i];
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

        public void Draw(SpriteBatch spriteBatch, Color color) {
            if (TransitionHandler.Instance.Start)
            {
                TransitionHandler.Instance.Draw(spriteBatch);
            }
            else
            {
                //room.Draw(spriteBatch);

                room.Draw(spriteBatch, color);

                foreach (IGameObject obj in gameObjectLists[roomNumber])
                {
                    if (obj is IEnemy && color.Equals(Color.White))
                        ((IEnemy)obj).Draw(spriteBatch);
                    else if (obj is IItem && color.Equals(Color.White))
                        ((IItem)obj).Draw(spriteBatch);
                    else if (obj is IBlock)
                        ((IBlock)obj).Draw(spriteBatch, color);
                    else if (obj is IDoor)
                        ((IDoor)obj).Draw(spriteBatch, color);

                }

                game1.link.Draw(spriteBatch, Color.White);
            }
        }

        public static void ResetRooms() {
            enemiesKilledList = new int[18];
            for (int i = 0; i < 18; i++)
            {
                gameObjectLists[i] = RoomGenerator.Instance.LoadFile(i);
                if (i != 15)
                    gameObjectLists[i].AddRange(Globals.WallBlocks);
                else
                    gameObjectLists[i].AddRange(Globals.Room16WallBlocks);
            }
        }




        public static int GetCurrentRoomNumber() { 
            return roomNumber;
        }
        public DungeonRoom getDungeonRoom()
        {
            return (DungeonRoom)room;
        }
        public void SetDecorator(IRoom room)
        {
            game1.room = room;
        }
        public virtual void SwitchToNorthRoom() { }
        public virtual void SwitchToSouthRoom() { }
        public virtual void SwitchToEastRoom() { }
        public virtual void SwitchToWestRoom() { }
        public virtual void SwitchToLowerRoom() { }
        public virtual void SwitchToUpperRoom() { }

    }
}
