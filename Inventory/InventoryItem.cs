using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.CommandClasses;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Items.ItemSprites;

namespace Sprint2_Attempt3.Inventory
{
    public class InventoryItem : IInventoryItem
    {
        private float count = 0;
        public Rectangle destRectangle { get; private set; }
        private IItemSprite sprite;
        private ICommand command = null; 
        public InventoryItem() { }
        public InventoryItem(Rectangle destination, IItemSprite source, ICommand com)
        {
            count = 1;
            destRectangle = destination;
            sprite = source;
            command = com;   
        }

        public InventoryItem(Rectangle destination, IItemSprite source)
        {
            count = 1;
            destRectangle = destination;
            sprite = source;
        }

        public InventoryItem(float c)
        {
            count = c;
            destRectangle = new Rectangle();
        }

        public InventoryItem(Rectangle destination, IItemSprite source, float c)
        {
            count = c;
            destRectangle = destination;
            sprite = source;
        }

        public InventoryItem(Rectangle destination, IItemSprite source, ICommand com, float c)
        {
            count = c;
            destRectangle = destination;
            sprite = source;
            command = com;
        }

        public void IncrementCount()
        {
            if (count < 99) { count++; }
        }

        public void DecrementCount() { count--; }

        public void IncrementCount(float i)
        {
            if (count + i < 99) { count += i; }
            else { count = 99; }
        }

        public void DecrementCount(float i) { count -= i;  }

        public float Count() { return count; }

        public void ShiftUp() { destRectangle = new Rectangle(destRectangle.X, destRectangle.Y - 1, destRectangle.Width, destRectangle.Height); }

        public void ShiftDown() { destRectangle = new Rectangle(destRectangle.X, destRectangle.Y + 1, destRectangle.Width, destRectangle.Height); }

        public void UseItem() { command.Execute(); }
        public void Draw(SpriteBatch spriteBatch) {
            if (count > 0) { sprite.Draw(spriteBatch, destRectangle); }
        }
        public void SetDestRectangle(Rectangle newDestRectangle) { destRectangle = newDestRectangle; }

        public void SetSprite(IItemSprite newSprite) {  sprite = newSprite; }
        public IItemSprite GetSprite() {  return sprite; }
    }
}
