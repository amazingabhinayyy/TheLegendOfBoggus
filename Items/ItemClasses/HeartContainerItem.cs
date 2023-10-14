using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items.ItemClasses
{
    internal class HeartContainerItem : IJustItemSprite
    {
        private Texture2D texture;
        public int destx, desty;
        public Rectangle heartcontainerSource;
        public HeartContainerItem(Texture2D heartcontainerTexture, Vector2 Pos, Rectangle heartcontainerSource)
        {
            texture = heartcontainerTexture;
            destx = (int)Pos.X;
            desty = (int)Pos.Y;
            this.heartcontainerSource = heartcontainerSource;
        }

        public void Update()
        {
        }

        public Rectangle DestRectangle()
        {
            int width = heartcontainerSource.Width;
            int height = heartcontainerSource.Height;
            return new Rectangle(destx, desty, width * 2, height * 2);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle srcRectangle = heartcontainerSource;
            spriteBatch.Draw(texture, DestRectangle(), srcRectangle, Color.White);
        }
    }
}
