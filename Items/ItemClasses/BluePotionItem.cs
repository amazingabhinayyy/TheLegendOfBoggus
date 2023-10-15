using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class BluePotionItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle bluepotionSource;
        public bool isCollected { get; private set; } = false;

        public BluePotionItem(Texture2D bluepotionTexture, Vector2 Pos, Rectangle bluepotionSource)
        {
            texture = bluepotionTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.bluepotionSource = bluepotionSource;
        }

        public void Update()
        {
        }
        public void Spawn()
        {
            //Draw()
        }
        public void Collected()
        {
            isCollected = true;
        }

        public Rectangle DestRectangle()
        {
            int width = bluepotionSource.Width;
            int height = bluepotionSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = bluepotionSource;
            if (!isCollected)
            {
                spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
            }
        }
    }
}
