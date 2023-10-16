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
            if (intersection.Width > intersection.Height)
            {
                // Collision occurred from the left or right
                if (spriteObject.Center.X < wall.Center.X)
                {
                    // Collision occurred from the left, so prevent movement to the right
                    // You can set the object's X position to the left edge of the wall
                    spriteObject.X = wall.Left - spriteObject.Width;
                }
                else
                {
                    // Collision occurred from the right, so prevent movement to the left
                    // You can set the object's X position to the right edge of the wall
                    spriteObject.X = wall.Right;
                }
            }
            // Stop movement in the Y direction (vertical)
            else
            {
                // Collision occurred from the top or bottom
                if (spriteObject.Center.Y < wall.Center.Y)
                {
                    // Collision occurred from the top, so prevent movement downward
                    // You can set the object's Y position to the top edge of the wall
                    spriteObject.Y = wall.Top - spriteObject.Height;
                }
                else
                {
                    // Collision occurred from the bottom, so prevent movement upward
                    // You can set the object's Y position to the bottom edge of the wall
                    spriteObject.Y = wall.Bottom;
                }
            }
        }
    }
}
