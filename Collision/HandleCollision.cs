using System;
using System.Collections.Generic;
using System.Linq;
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
        private Link link;

        public HandleCollision(Link link)
        {
            //this.link = link;
        }
        public static void HandleLinkBlockCollision(Rectangle spriteObject, Rectangle wall, Link link)
        {
            Rectangle intersectRect = Rectangle.Intersect(spriteObject, wall);
            int width = intersectRect.Width;
            ICollision side = CollisionDetector.SideDetector(spriteObject, wall);
            if (side is BottomCollision)
            {
                link.BecomeIdle();
                //System.Diagnostics.Debug.WriteLine("link y position:" + link.position.Y);
                link.position.Y = wall.Bottom;
                //System.Diagnostics.Debug.WriteLine("link y position:" + link.position.Y);
            }
            else if (side is LeftCollision)
            {
                link.BecomeIdle();
                link.position.X = wall.Right - wall.Width - 45;
            }
            else if (side is RightCollision)
            {
                link.BecomeIdle();
                link.position.X = wall.Right;
            }
            else
            {
                link.BecomeIdle();
                link.position.Y = wall.Top - wall.Height + 40;
            }
            /*
            // Determine the direction of the collision (e.g., from which side the collision occurs)
            // You can use the intersection rectangle to determine this
            // Calculate the intersection rectangle between the object and the wall
            Rectangle intersection = Rectangle.Intersect(spriteObject, wall);

            // Now, you can check whether the collision occurred from the top, bottom, left, or right
            // Then, you can stop movement in that direction

            // Stop movement in the X direction (horizontal)
            if (intersection.Width >= intersection.Height)
            {
                //System.Diagnostics.Debug.WriteLine("test");
                // Collision occurred from left (object hits block on its left side)
                if (spriteObject.Center.X < wall.Center.X)
                {
                    // prevent movement to the right
                    // set the object's X position to the left edge of the wall - object's width
                    //link.position.X = wall.Left - spriteObject.Width;
                }
                // Collision occured from right (object hits block on its right side)
                else
                {
                    // prevent movement to the left
                    // set the object's left X position to the right edge of the wall
                    //link.position = new Vector2(wall.Right, link.position.Y);
                }
            }
            // Stop movement in the Y direction (vertical)
            else
            {
                // Collision occurred from the top (object hits block on its top side)
                if (spriteObject.Center.Y < wall.Center.Y)
                {
                    // Collision occurred from the top, so prevent movement downward
                    // You can set the object's Y position to the top edge of the wall
                    link.position = new Vector2(link.position.X, wall.Top - link.GetHitBox().Height);
                }
                // Collision occurred from the bottom
                else
                {
                    // Collision occurred from the bottom, so prevent movement upward
                    // You can set the object's Y position to the bottom edge of the wall
                    link.position = new Vector2(link.position.X, wall.Bottom);
                }
            }*/
        }

        public static void HandleEnemyBlockCollision(Rectangle spriteObject, Rectangle wall, IEnemy enemy)
        {
            Rectangle intersectRect = Rectangle.Intersect(spriteObject, wall);
            int width = intersectRect.Width;
            ICollision side = CollisionDetector.SideDetector(spriteObject, wall);
            if (side is BottomCollision)
            {

                //enemy.Y = wall.Bottom;
                //System.Diagnostics.Debug.WriteLine("link y position:" + link.position.Y);
                enemy.Y = wall.Bottom;
                //System.Diagnostics.Debug.WriteLine("link y position:" + link.position.Y);
                //enemy.ChangeDirection();
            }
            else if (side is LeftCollision)
            {
                enemy.X = wall.Right - wall.Width - 45;
                //enemy.ChangeDirection();
            }
            else if (side is RightCollision)
            {
                enemy.X = wall.Right;
                //enemy.ChangeDirection();
            }
            else
            {
                enemy.Y = wall.Top - wall.Height + 40;
                //enemy.ChangeDirection();
            }
        }
            //System.Diagnostics.Debug.WriteLine("testhandle");
            //changeDirection method from Avery
            // skeleton/glob/snake = if it hits top or bottom, change direction left or right randomly
            // bat = change direction randomly - not with blocks (just pass over)
            // dragon same as first?
            // hand just passes through?
            //Rectangle intersectRect = Rectangle.Intersect(spriteObject, wall);
            //int width = intersectRect.Width;
            
            /*ICollision side = CollisionDetector.SideDetector(spriteObject, wall);
            if (side is BottomCollision || side is TopCollision)
            {
                // enemy moves left or right
                //enemy.ChangeDirection();
                System.Diagnostics.Debug.WriteLine("testcollision");
                //link.position.Y = wall.Bottom;
                //System.Diagnostics.Debug.WriteLine("link y position:" + link.position.Y);
            }
            else //left or right collision
            {
                //enemy moves up or down
                enemy.ChangeDirection();
            }*/
        

        public static void HandleProjectileBlockCollision(Rectangle projObject, ILinkItem projectile)
        {
            //change sprite to poof animation
            if (projectile is IBoomerang)
            {
                System.Diagnostics.Debug.WriteLine("boomerang");
            }
            else
            {
                LinkSpriteFactory.Instance.CreatePoofAnimation();
                //projectile.poof();
                //CollisionDetector.GameObjectList.Remove(projectile);
                //projectile.collided();
                //System.Diagnostics.Debug.WriteLine("test");
            }

            //projectile.disappear();
            /*if (currentFrame >= 0 && currentFrame < 50)
            {
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            }
            else if (currentFrame >= 50 && currentFrame < 54)
            {
                srcRec = new Rectangle(138, 185, 15, 15);
                destinationRectangle = new Rectangle((int)location.X, (int)location.Y, srcRec.Width * 3, srcRec.Height * 3);
            }
            else if (currentFrame >= 54 && currentFrame < 57)
            {
                srcRec = new Rectangle(155, 185, 15, 15);
            }
            else
            {
                srcRec = new Rectangle(172, 185, 15, 15);
            }*/
        }
    }
}
