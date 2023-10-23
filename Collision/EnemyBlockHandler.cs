using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.WallBlocks;
using Sprint2_Attempt3.Dungeon.Doors;

namespace Sprint2_Attempt3.Collision
{
    public class EnemyBlockHandler
    {
        public static void HandleEnemyBlockCollision(IEnemy enemy, IGameObject obj, ICollision side)
        {
            bool blocked = false;
            if (obj is IBlock)
            {
                var block = (IBlock)obj;
                if (!block.isWalkable)
                {
                    blocked = true;
                }
            }
            else if (obj is IWall)
            {
                blocked = true;
            }
            else if (obj is IDoor)
            {
                blocked = true;
            }
            if (blocked)
            {
                Rectangle wall = obj.GetHitBox();
                if (side is BottomCollision)
                {
                    enemy.Y = wall.Top - enemy.GetHitBox().Height - 1;
                    enemy.MoveRight();
                }
                else if (side is LeftCollision)
                {
                    enemy.X = wall.Right + 1;
                    enemy.MoveUp();
                }
                else if (side is RightCollision)
                {
                    enemy.X = wall.Left - enemy.GetHitBox().Width - 1;
                    enemy.MoveDown();
                }
                else
                {
                    enemy.Y = wall.Bottom + 1;
                    enemy.MoveLeft();
                }
            }
        }
        
    }
}
