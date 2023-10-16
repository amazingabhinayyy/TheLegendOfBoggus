using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy;

namespace Sprint2_Attempt3.Collision
{
    internal class HandleCollision
    {
        public HandleCollision()
        {

        }
        public static void HandleLinkBlockCollision(Rectangle spriteObject, Rectangle wall)
        {
            // Determine the direction of the collision (e.g., from which side the collision occurs)
            // You can use the intersection rectangle to determine this
            // Calculate the intersection rectangle between the object and the wall
            Rectangle intersection = Rectangle.Intersect(spriteObject, wall);

            // Now, you can check whether the collision occurred from the top, bottom, left, or right
            // Then, you can stop movement in that direction

            // Stop movement in the X direction (horizontal)
            if (intersection.Width < intersection.Height)
            {
                // Collision occurred from left (object hits block on its left side)
                if (spriteObject.Center.X < wall.Center.X)
                {
                    // prevent movement to the right
                    // set the object's X position to the left edge of the wall - object's width
                    spriteObject.X = wall.Left - spriteObject.Width;
                }
                // Collision occured from right (object hits block on its right side)
                else
                {
                    // prevent movement to the left
                    // set the object's left X position to the right edge of the wall
                    spriteObject.X = wall.Right;
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
                    spriteObject.Y = wall.Top - spriteObject.Height;
                }
                // Collision occurred from the bottom
                else
                {
                    // Collision occurred from the bottom, so prevent movement upward
                    // You can set the object's Y position to the bottom edge of the wall
                    spriteObject.Y = wall.Bottom;
                }
            }
        }

        public static void HandleEnemyBlockCollision(Rectangle spriteObject, Rectangle wall)
        {
            //changeDirection method from Avery
        }

        public static void HandleProjectileBlockCollision(Rectangle spriteObject, Rectangle wall)
        {
            //change sprite to poof animation
        }
    }
}
