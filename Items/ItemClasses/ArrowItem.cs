using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class ArrowItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle arrowSource;
        public bool isCollected { get; private set; } = false;
        //bool firstUpdate = true;
        public ArrowItem(Texture2D arrowTexture, Vector2 Pos, Rectangle arrowSource)
        {
            texture = arrowTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.arrowSource = arrowSource;
        }

        public void Update()
        {
            //if (firstUpdate)
            //{
            //  Collected();
            // firstUpdate = false;
            // }
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
            int width = arrowSource.Width;
            int height = arrowSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = arrowSource;
            if (!isCollected)
            {
                spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
            }
        }
    }
}
