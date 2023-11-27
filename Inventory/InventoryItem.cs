﻿using Microsoft.Xna.Framework;
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
        private float OriginalCount;
        public Rectangle destRectangle { get; private set; }
        private IItemSprite sprite;
        private ICommand command = null; 
        public InventoryItem() { }
        public InventoryItem(Rectangle destination, IItemSprite source, ICommand com, float c)
        {
            count = c;
            OriginalCount = c;
            destRectangle = destination;
            sprite = source;
            command = com;   
        }
        public void IncrementCount() { if (count < 99) { count++; } }
        public void DecrementCount() { count--; }
        public float Count() { return count; }
        public void SetCount(float c) { count = c; }
        public void ShiftUp() { destRectangle = new Rectangle(destRectangle.X, destRectangle.Y - 1, destRectangle.Width, destRectangle.Height); }
        public void ShiftDown() { destRectangle = new Rectangle(destRectangle.X, destRectangle.Y + 1, destRectangle.Width, destRectangle.Height); }
        public void UseItem() { command.Execute(); }
        public void Draw(SpriteBatch spriteBatch) { if (count > 0) { sprite.Draw(spriteBatch, destRectangle); } }
        public IItemSprite GetSprite() {  return sprite; }
    }
}
