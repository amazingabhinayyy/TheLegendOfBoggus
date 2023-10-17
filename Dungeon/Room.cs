using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.Stalfos;
using Sprint2_Attempt3.Items;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Dungeon
{
    public class Room : RoomSecondary
    {
        public Room(Game1 game1) {
            this.game1 = game1;
            gameObjects = new List<IGameObject>() {
                new Keese(200,200),
                new Rope(300, 250),
                new Goriya(250, 200),
                new Stalfos(400, 250),
               
            };
            foreach (IEnemy enemy in gameObjects) {
                enemy.Spawn();
            }
        }

    }
}
