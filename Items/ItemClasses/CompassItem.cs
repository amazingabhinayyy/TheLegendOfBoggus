using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class CompassItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle compassSource;
        public bool isCollected { get; private set; } = false;

        public CompassItem(Texture2D compassTexture, Vector2 Pos, Rectangle source)
        {
            texture = compassTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            compassSource = source;
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
            int width = compassSource.Width;
            int height = compassSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = compassSource;
            if (!isCollected)
            {
                spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
            }
        }
    }
}
