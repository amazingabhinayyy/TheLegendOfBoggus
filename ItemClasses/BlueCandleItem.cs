﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class BlueCandleItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle bluecandleSource;
        public BlueCandleItem(Texture2D bluecandleTexture, Vector2 Pos, Rectangle bluecandleSource)
        {
            texture = bluecandleTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.bluecandleSource = bluecandleSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.bluecandleSource.Width;
            int height = this.bluecandleSource.Height;
            return new Rectangle(destx, desty, width*2, height*2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = this.bluecandleSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}