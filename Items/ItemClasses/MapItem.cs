using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class MapItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle mapSource;
        public bool isCollected { get; private set; } = false;

        public MapItem(Texture2D mapTexture, Vector2 Pos, Rectangle mapSource)
        {
            texture = mapTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.mapSource = mapSource;
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
            int width = mapSource.Width;
            int height = mapSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = mapSource;
            if (!isCollected)
            {
                spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
            }
        }
    }
}
