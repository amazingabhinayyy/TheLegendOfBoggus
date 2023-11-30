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

namespace Sprint2_Attempt3.Dungeon
{
    public abstract class RoomSecondary : IRoom
    {
        protected static List<List<IGameObject>> gameObjectLists = new List<List<IGameObject>>(18);
        //protected static int[] enemiesKilledList = new int[18];
        protected static IRoom[,] roomLayout = new IRoom[12, 12];
        protected static int mapY = 11;
        protected static int mapX = 5;

        //public static int[] EnemiesKilledList { get { return enemiesKilledList; } set { enemiesKilledList = value; } }
        public List<List<IGameObject>> GameObjectLists { get { return gameObjectLists; } set { gameObjectLists = value; } }
        protected static int currentRoomNumber;
        public int RoomNumber { get; }

        protected static Boolean varHoldingTrue = true;
        protected Boolean spawned = false;
        public static bool ClockUsed { get; set; } = false;
        protected IDungeonRoom room;
        protected Game1 game1;
        protected CollisionManager collisionManager;

        public RoomSecondary(Game1 game, int roomNum) {
            this.game1 = game;
            room = new DungeonRoom();
            currentRoomNumber = roomNum;
            RoomNumber = roomNum;
            spawned = false;

            for(int i = 0; i < 18; i++)
            {
                gameObjectLists.Add(null);
            }

            if (gameObjectLists[currentRoomNumber] == null)
            {
                
                gameObjectLists[currentRoomNumber] = RoomGenerator.Instance.LoadFile(currentRoomNumber);
                //gameObjectLists[roomNumber] = RoomGenerator.Instance.LoadFile(roomNumber);

                gameObjectLists[currentRoomNumber].Add(this.game1.link);
                if (roomNum != 15)
                {
                    gameObjectLists[currentRoomNumber].AddRange(Globals.WallBlocks);
                }
                InventoryController.VisitRoom(roomNum);
            }              
            
            if (game1.link is DamageLinkDecorator)
            {
                ((DamageLinkDecorator)game1.link).RemoveDecorator();
            }

            ClockUsed = false;
            collisionManager = new CollisionManager(game1, game1.link);
        
       
            if (TransitionHandler.Instance.TransitionGameObjectList.Count == 0)
            {
                CollisionManager.GameObjectList = gameObjectLists[currentRoomNumber];
            }
            TransitionHandler.Instance.TransitionGameObjectList = gameObjectLists[currentRoomNumber];

            
        }

        public void SwitchToNextRoom() {
            if (currentRoomNumber < gameObjectLists.Count - 1)
            {
                currentRoomNumber++;
            }
            else
            {
                currentRoomNumber = 0;
            }
            room = new DungeonRoom();

            if (gameObjectLists[currentRoomNumber] == null)
            {
                gameObjectLists[currentRoomNumber] = RoomGenerator.Instance.LoadFile(currentRoomNumber);
                gameObjectLists[currentRoomNumber].Add(this.game1.link);
                if (currentRoomNumber != 15)
                {
                    gameObjectLists[currentRoomNumber].AddRange(Globals.WallBlocks);
                }
                else {
                    room = new WhiteStairRoom();
                }
                InventoryController.VisitRoom(currentRoomNumber);
            }

            if (game1.link is DamageLinkDecorator)
            {
                ((DamageLinkDecorator)game1.link).RemoveDecorator();
            }
            ClockUsed = false;
            InventoryController.VisitRoom(currentRoomNumber);
            TransitionHandler.Instance.TransitionGameObjectList = new List<IGameObject>();
            CollisionManager.GameObjectList = gameObjectLists[currentRoomNumber];
            game1.link.Items.Clear();
        }

        public void SwitchToPrevRoom()
        {
            if (currentRoomNumber <= 0)
            {
                currentRoomNumber= gameObjectLists.Count-1;
            }
            else
            {
                currentRoomNumber--;
            }
            room = new DungeonRoom();
            if (gameObjectLists[currentRoomNumber] == null)
            {
                gameObjectLists[currentRoomNumber] = RoomGenerator.Instance.LoadFile(currentRoomNumber);
                gameObjectLists[currentRoomNumber].Add(this.game1.link);
                if (currentRoomNumber != 15)
                {
                    gameObjectLists[currentRoomNumber].AddRange(Globals.WallBlocks);
                }
                else
                {
                    room = new WhiteStairRoom();
                }
                InventoryController.VisitRoom(currentRoomNumber);
            }
            
            if (game1.link is DamageLinkDecorator)
            {
                ((DamageLinkDecorator)game1.link).RemoveDecorator();
            }
            ClockUsed = false;
            InventoryController.VisitRoom(currentRoomNumber);
            TransitionHandler.Instance.TransitionGameObjectList = new List<IGameObject>();
            CollisionManager.GameObjectList = gameObjectLists[currentRoomNumber];
            game1.link.Items.Clear();
        }
        public virtual void Update() {
            if (!TransitionHandler.Instance.Start)
            {
                if(!game1.deathAnimationActive)
                    collisionManager.Update();

                for (int i = 0; i < gameObjectLists[currentRoomNumber].Count; i++)
                {
                    IGameObject obj = gameObjectLists[currentRoomNumber][i];
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
            else
            {
                room.Draw(spriteBatch, color);
                List<IEnemy> enemyList = new List<IEnemy>();

                foreach (IGameObject obj in gameObjectLists[currentRoomNumber])
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
        public static void ResetRooms() {
            //enemiesKilledList = new int[18];
            for (int i = 0; i < 18; i++)
            {
                gameObjectLists[i] = RoomGenerator.Instance.LoadFile(i);
                if (i != 15)
                    gameObjectLists[i].AddRange(Globals.WallBlocks);
                else
                    gameObjectLists[i].AddRange(Globals.Room16WallBlocks);
            }
            mapX = 5;
            mapY = 11;
        }
        public static int GetCurrentRoomNumber() { 
            return currentRoomNumber;
        }
        public DungeonRoom getDungeonRoom()
        {
            return (DungeonRoom)room;
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
