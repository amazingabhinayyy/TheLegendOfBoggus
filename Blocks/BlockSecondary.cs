﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Blocks
{
    public abstract class BlockSecondary : IBlock
    {
        public bool isWalkable { get; set; }
        public Rectangle position { get; set; }
        protected Rectangle sourceRectangle { get; set; }

        public BlockSecondary() { }
        public void Update() { }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(BlockSpriteFactory.Instance.blocks, position, sourceRectangle, Color.White);
        }

        public Rectangle GetHitBox()
        {
            return new Rectangle(position.X, position.Y, position.Width, position.Height / 2);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 change)
        {
            Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width - (int)change.X, sourceRectangle.Height);
            Rectangle destinationRectangle = new Rectangle(position.X + (int)(change.X * 3.125), position.Y + (int)(change.Y * 3.125), 50, 50);
            spriteBatch.Draw(BlockSpriteFactory.Instance.blocks, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}