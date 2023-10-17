using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Dungeon.Rooms.DungeonRooms;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Stalfos;
using Sprint2_Attempt3.Enemy.Zol;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon
{
    public class Room1 : RoomSecondary
    {
        public Room1(Game1 game1) {
            this.game1 = game1;
            this.room = new DungeonRoom1();
            //gameObjects = RoomGenerator.Instance.LoadFile(0);

            gameObjects = new List<IGameObject> { 
                new Aquamentus(100, 200),
                new Dodongo(120, 300),
                new Gel(140, 400),
                new Goriya(160, 200),
                new Hand(180, 300),
                new Keese(200, 400),
                new Rope(220, 200),
                new SpikeTrap(240, 300),
                new Stalfos(260, 400),
                new Zol(300, 200)
            };
            foreach (IEnemy enemy in gameObjects) {
                enemy.Spawn();
            }
        }

    }
}
