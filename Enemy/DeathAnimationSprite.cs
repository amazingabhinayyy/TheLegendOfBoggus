using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Enemy
{
    internal class DeathAnimationSprite : IEnemySprite
    {
        private Texture2D texture;
        private int currentFrame;
        private Rectangle sourceRectangle;
        private int x, y;

        private bool dead;

        public bool Died { get { return dead; } }
        public DeathAnimationSprite(Texture2D texture)
        {
            this.texture = texture;
            this.currentFrame = 0;
            
            this.sourceRectangle = new Rectangle(39, 19, 15, 16);
       
            this.x = 200;
            this.y = 200;
            
            this.dead = false;
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == 10)
            {
                sourceRectangle.X += 16;
            }
            else if (currentFrame == 20)
            {
                sourceRectangle.X += 16;
            }
            else if (currentFrame == 30)
            {
                sourceRectangle.X += 16;
            }
            else if (currentFrame == 40)
            {
                dead = true;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                texture,
                new Vector2(x, y),
                sourceRectangle,
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
