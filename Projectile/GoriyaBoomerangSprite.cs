using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Projectile;

namespace Sprint2_Attempt3.Projectile
{
    internal class GoriyaBoomerangSprite : IEnemyProjectileSprite
    {
        private Texture2D texture;
       

    
        public GoriyaBoomerangSprite(Texture2D texture)
        {
            this.texture = texture;
           
           
        }

        public void Update()
        {
          
        }

        public void Draw(SpriteBatch spriteBatch, int x, int y, Rectangle sourceRectangle,SpriteEffects effect,Vector2 origin)
        {
            spriteBatch.Draw(
                texture,
                new Vector2(x, y),
                sourceRectangle,
                Color.White,
                0f,
                new Vector2(0, 0),
                Globals.scale,
                effect,
                0f
            );
        }

    
    }
}
