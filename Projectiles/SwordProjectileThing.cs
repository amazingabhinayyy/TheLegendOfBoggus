using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Projectiles
{
    internal class SwordProjectileThing
    {
        private int x, y;
        private int xTopLeft;
        private int yTopLeft;
        private int xTopRight;
        private int yTopRight;
        private int xBottomLeft;
        private int yBottomLeft;
        private int xBottomRight;
        private int yBottomRight;
        private int currentFrame;

        private Rectangle sourceRectangleTopLeft;
        private Rectangle sourceRectangleTopRight;
        private Rectangle sourceRectangleBottomLeft;
        private Rectangle sourceRectangleBottomRight;

        private Texture2D texture;

        public SwordProjectileThing(Texture2D texture) {
            this.texture = texture;
            currentFrame = 0;
            this.sourceRectangleTopLeft = new Rectangle(1, 18, 8, 10);
            this.sourceRectangleTopRight = new Rectangle(10, 18, 8, 10);
            this.sourceRectangleBottomLeft = new Rectangle(1, 29, 8, 10);
            this.sourceRectangleBottomRight = new Rectangle(10, 29, 8, 10);

            this.xTopLeft = x - 4 * (int)Globals.scale;
            this.yTopLeft = y - 6 * (int)Globals.scale;
            this.xTopRight = x + 9 * (int)Globals.scale;
            this.yTopRight = y - 6 * (int)Globals.scale;
            this.xBottomLeft = x - 5 * (int)Globals.scale;
            this.yBottomLeft = y + 10 * (int)Globals.scale;
            this.xBottomRight = x + 10 * (int)Globals.scale;
            this.yBottomRight = y + 11 * (int)Globals.scale;
        }

        public void Update() {
            currentFrame++;
            if (currentFrame == 10)
            {
                sourceRectangleTopLeft.X += 18;
                sourceRectangleTopRight.X += 18;
                sourceRectangleBottomLeft.X += 18;
                sourceRectangleBottomRight.X += 18;

                this.xTopLeft -= 2 * (int)Globals.scale;
                this.yTopLeft -= 2 * (int)Globals.scale;
                this.xTopRight += 2 * (int)Globals.scale;
                this.yTopRight -= 2 * (int)Globals.scale;
                this.xBottomLeft -= 2 * (int)Globals.scale;
                this.yBottomLeft += 2 * (int)Globals.scale;
                this.xBottomRight += 2 * (int)Globals.scale;
                this.yBottomRight += 2 * (int)Globals.scale;
            }
            else if (currentFrame == 20)
            {
                sourceRectangleTopLeft.X -= 18;
                sourceRectangleTopRight.X -= 18;
                sourceRectangleBottomLeft.X -= 18;
                sourceRectangleBottomRight.X -= 18;

                this.xTopLeft -= 2 * (int)Globals.scale;
                this.yTopLeft -= 2 * (int)Globals.scale;
                this.xTopRight += 2 * (int)Globals.scale;
                this.yTopRight -= 2 * (int)Globals.scale;
                this.xBottomLeft -= 2 * (int)Globals.scale;
                this.yBottomLeft += 2 * (int)Globals.scale;
                this.xBottomRight += 2 * (int)Globals.scale;
                this.yBottomRight += 2 * (int)Globals.scale;
            }
            else if (currentFrame == 30)
            {
                sourceRectangleTopLeft.X += 18;
                sourceRectangleTopRight.X += 18;
                sourceRectangleBottomLeft.X += 18;
                sourceRectangleBottomRight.X += 18;

                this.xTopLeft -= 2 * (int)Globals.scale;
                this.yTopLeft -= 2 * (int)Globals.scale;
                this.xTopRight += 2 * (int)Globals.scale;
                this.yTopRight -= 2 * (int)Globals.scale;
                this.xBottomLeft -= 2 * (int)Globals.scale;
                this.yBottomLeft += 2 * (int)Globals.scale;
                this.xBottomRight += 2 * (int)Globals.scale;
                this.yBottomRight += 2 * (int)Globals.scale;
            }
        }

        public void Draw(SpriteBatch spriteBatch) {
            spriteBatch.Draw(
                texture,
                new Vector2(xTopLeft, yTopLeft),
                sourceRectangleTopLeft,
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                SpriteEffects.None,
                0f
            );

            spriteBatch.Draw(
                texture,
                new Vector2(xTopRight, yTopRight),
                sourceRectangleTopRight,
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                SpriteEffects.None,
                0f
            );

            spriteBatch.Draw(
                texture,
                new Vector2(xBottomLeft, yBottomLeft),
                sourceRectangleBottomLeft,
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                SpriteEffects.None,
                0f
            );

            spriteBatch.Draw(
                texture,
                new Vector2(xBottomRight, yBottomRight),
                sourceRectangleBottomRight,
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                SpriteEffects.None,
                0f
            );
        }

    }
}
