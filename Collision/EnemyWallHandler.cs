using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.WallBlocks;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Dungeon.Doors;

namespace Sprint2_Attempt3.Collision
{
    public class EnemyWallHandler
    {
        //public static void HandleEnemyWallCollision()
        public static void HandleEnemyWallCollision(Rectangle wall, IEnemy enemy)
        {
            ICollision side = CollisionDetector.SideDetector(enemy.GetHitBox(), wall);
            Boolean check = true;
            if (enemy is Hand)
            {
                Hand newHand = (Hand)enemy;
                if (newHand.State is CapturedState)
                {
                    check = false;
                }
            }
            if (check)
            {
                if (side is BottomCollision)
                {
                    enemy.Y = wall.Bottom;
                }
                else if (side is LeftCollision)
                {
                    enemy.X = wall.Left - enemy.Position.Width - 1;
                }
                else if (side is RightCollision)
                {
                    enemy.X = wall.Right + 1;
                }
                else
                {
                    enemy.Y = wall.Top - enemy.Position.Height - 1;
                }
            }
        }
    }
}
