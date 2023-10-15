using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class BombItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle bombSource;
        public bool isCollected { get; private set; } = false;

        public BombItem(Texture2D bombTexture, Vector2 Pos, Rectangle bombSource)
        {
            texture = bombTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.bombSource = bombSource;
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
            int width = bombSource.Width;
            int height = bombSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = bombSource;
            if (!isCollected)
            {
                spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
            }
        }
    }
}
