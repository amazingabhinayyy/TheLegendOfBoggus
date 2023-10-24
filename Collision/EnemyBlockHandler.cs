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
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Dungeon.Doors;

namespace Sprint2_Attempt3.Collision
{
    public class EnemyBlockHandler
    {
        //public static void HandleEnemyWallCollision()
        public static void HandleEnemyBlockCollision(IEnemy enemy, IGameObject obj, Rectangle collisionRectangle)
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
            else if(obj is IDoor)
            {
                blocked = true;
            }
            if (blocked)
            {
                Rectangle hitBox = enemy.GetHitBox();
                if (enemy is Hand)
                {
                    hitBox = new Rectangle(hitBox.X, hitBox.Y, hitBox.Width / 2, hitBox.Height / 2);
                }
                ICollision side = CollisionDetector.SideDetector(hitBox, collisionRectangle);

                if (side is BottomCollision)
                {

                    enemy.MoveDown();
                    enemy.Y = collisionRectangle.Bottom;
                }
                else if (side is LeftCollision)
                {
                    enemy.MoveLeft();
                    enemy.X = collisionRectangle.Left - enemy.Position.Width - 1;
                }
                else if (side is RightCollision)
                {
                    enemy.MoveRight();
                    enemy.X = collisionRectangle.Right + 1;
                }
                else
                {
                    enemy.MoveUp();
                    enemy.Y = collisionRectangle.Top - enemy.Position.Height - 1;
                }
            }
        }
    }
}
