using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.Items;

namespace Sprint2_Attempt3.Collision
{
    internal class HandleCollision
    {
        public HandleCollision()
        {
        }
        public static void HandleLinkBlockCollision(Rectangle wall, ILink link)
        {
            Rectangle linkRectangle = link.GetHitBox();
            ICollision side = CollisionDetector.SideDetector(linkRectangle, wall);
            if (side is BottomCollision)
            {
                link.BecomeIdle();
                link.Y = wall.Bottom + 1;
            }
            else if (side is LeftCollision)
            {
                link.BecomeIdle();
                link.X = wall.Left - linkRectangle.Width - 1;
            }
            else if (side is RightCollision)
            {
                link.BecomeIdle();
                link.X = wall.Right + 1;
            }
            else
            {
                link.BecomeIdle();
                link.Y = wall.Top - linkRectangle.Height - 1;
            }
        }

        public static void HandleEnemyBlockCollision(Rectangle wall, IEnemy enemy)
        {
            ICollision side = CollisionDetector.SideDetector(enemy.GetHitBox(), wall);
            if (side is BottomCollision)
            {
                enemy.MoveDown();
                enemy.Y = wall.Bottom + 1;
            }
            else if (side is LeftCollision)
            {
                enemy.MoveLeft();
                enemy.X = wall.Left - enemy.Position.Width - 1;
            }
            else if (side is RightCollision)
            {
                enemy.MoveRight();
                enemy.X = wall.Right + 1;
            }
            else
            {
                enemy.MoveUp();
                enemy.Y = wall.Top - enemy.Position.Height - 1;
            }
        }

        public static void HandleProjectileBlockCollision(ILinkItem projectile)
        {
            //change sprite to poof animation
            if (projectile is IBoomerang)
            {
                System.Diagnostics.Debug.WriteLine("boomerang");
            }
            else
            {
                LinkSpriteFactory.Instance.CreatePoofAnimation();
            }
        }
    }
}
