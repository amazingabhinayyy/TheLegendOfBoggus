using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class BlueCandleItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle bluecandleSource;
        public bool isCollected { get; private set; } = false;

        public BlueCandleItem(Texture2D bluecandleTexture, Vector2 Pos, Rectangle bluecandleSource)
        {
            texture = bluecandleTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.bluecandleSource = bluecandleSource;
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
            int width = bluecandleSource.Width;
            int height = bluecandleSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = bluecandleSource;
            if (!isCollected)
            {
                spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
            }
        }
    }
}
