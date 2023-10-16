using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Dungeon.Rooms.DungeonRooms;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.Stalfos;
using Sprint2_Attempt3.Items;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon
{
    public class Room1 : RoomSecondary
    {
        public Room1(Game1 game1) {
            this.game1 = game1;
            this.room = new DungeonRoom1();
            gameObjects = RoomGenerator.Instance.LoadFile(0);
            foreach (IEnemy enemy in gameObjects) {
                enemy.Spawn();
            }
        }

    }
}
