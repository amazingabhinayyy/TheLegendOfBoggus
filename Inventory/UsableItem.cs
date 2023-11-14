using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.CommandClasses;
using Sprint2_Attempt3.Items.ItemSprites;

namespace Sprint2_Attempt3.Inventory
{
    internal class UsableItem : IInventoryItem
    {
        private float count = 0;
        public Rectangle destRectangle { get; private set; }
        private IItemSprite sprite;
        private ICommand command = null;
        public UsableItem() { }
        public UsableItem(Rectangle destination, IItemSprite source, ICommand com, int count)
        {
            this.count = count;
            destRectangle = destination;
            sprite = source;
            command = com;
        }
        public UsableItem(Rectangle destination, IItemSprite source, ICommand com)
        {
            count = 1;
            destRectangle = destination;
            sprite = source;
            command = com;
        }
        public void IncrementCount()
        {
            if (count < 99) { count++; }
        }

        public void ShiftUp() { destRectangle = new Rectangle(destRectangle.X, destRectangle.Y - 1, destRectangle.Width, destRectangle.Height); }

        public void ShiftDown() { destRectangle = new Rectangle(destRectangle.X, destRectangle.Y + 1, destRectangle.Width, destRectangle.Height); }

        public void UseItem() { 
            if (count >= 0) { 
                command.Execute();
                count--;
            } 
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (count >= 0) { sprite.Draw(spriteBatch, destRectangle); }
        }

        public IItemSprite GetSprite() { return sprite; }
    }
}
