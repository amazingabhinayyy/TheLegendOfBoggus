using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.ItemClasses
{
    internal class BluePotionItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle bluepotionSource;
        public BluePotionItem(Texture2D bluepotionTexture, Vector2 Pos, Rectangle bluepotionSource)
        {
            texture = bluepotionTexture;
            this.destx = (int)Pos.X;
            this.desty = (int)Pos.Y;
            this.bluepotionSource = bluepotionSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = this.bluepotionSource.Width;
            int height = this.bluepotionSource.Height;
            return new Rectangle(destx, desty, width * 2, height*2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = this.bluepotionSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
