using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class KeyItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle keySource;
        public bool isCollected { get; private set; } = false;

        public KeyItem(Texture2D keyTexture, Vector2 Pos, Rectangle keySource)
        {
            texture = keyTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.keySource = keySource;
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
            int width = keySource.Width;
            int height = keySource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = keySource;
            if (!isCollected)
            {
                spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
            }
        }
    }
}
