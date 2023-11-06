using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.CommandClasses;

namespace Sprint2_Attempt3.Inventory
{
    public class InventoryItem
    {
            private float count = 0;
            public Rectangle destRectangle { get; private set; }
            public Rectangle sourceRectangle { get; private set; }
            private ICommand command = null; 
            public InventoryItem() { }
            public InventoryItem(Rectangle destination, Rectangle source, ICommand com)
            {
                count = 1;
                destRectangle = destination;
                sourceRectangle = source;
                command = com;   
            }

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

            public InventoryItem(Rectangle destination, Rectangle source, ICommand com, float c)
            {
                count = c;
                destRectangle = destination;
                sourceRectangle = source;
                command = com;
            }

            public void IncrementCount()
            {
                if (count < 99)
                {
                    count++;
                }
            }

            public void DecrementCount()
            {
                count--;
            }

            public void IncrementCount(float i)
            {
                if (count + i < 99)
                {
                    count += i;
                }
                else {
                    count = 99;
                }
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

            public void UseItem() {
                command.Execute();
            } 
    }
}
