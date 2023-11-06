using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Inventory
{
    public class InventoryItem
    {
            private float count = 0;
            public Rectangle destRectangle { get; private set; }
            public Rectangle sourceRectangle { get; private set; }
            public InventoryItem() { }
            public InventoryItem(Rectangle destination, Rectangle source)
            {
                count = 1;
                destRectangle = destination;
                sourceRectangle = source;
            }

            public InventoryItem(float c)
            {
                count = c;
                destRectangle = new Rectangle();
                sourceRectangle = new Rectangle();
            }

            public InventoryItem(Rectangle destination, Rectangle source, float c)
            {
                count = c;
                destRectangle = destination;
                sourceRectangle = source;
            }

            public void IncrementCount()
            {
                count++;
            }

            public void DecrementCount()
            {
                count--;
            }

            public void IncrementCount(float i)
            {
                count += i;
            }

            public void DecrementCount(float i)
            {
                count -= i;
            }

            public float Count() {
                return count;
            }

            public void ShiftUp()
            {
                destRectangle = new Rectangle(destRectangle.X, destRectangle.Y - 1, destRectangle.Width, destRectangle.Height);
            }

            public void ShiftDown()
            {
                destRectangle = new Rectangle(destRectangle.X, destRectangle.Y + 1, destRectangle.Width, destRectangle.Height);
            }
        }
}
