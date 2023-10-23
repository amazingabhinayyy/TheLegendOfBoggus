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
            if (blocked)
            {
                Rectangle wall = obj.GetHitBox();
                if (side is BottomCollision)
                {
                    enemy.Y = wall.Bottom;
                }
                else if (side is LeftCollision)
                {
                    enemy.X = wall.Left - enemy.GetHitBox().Width;
                }
                else if (side is RightCollision)
                {
                    enemy.X = wall.Right;
                }
                else
                {
                    enemy.Y = wall.Top - enemy.GetHitBox().Height;
                }
                enemy.ChangeDirection();
            }
        }
        
    }
}
