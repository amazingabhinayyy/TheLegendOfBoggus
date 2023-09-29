using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Enemy
{
    internal class SpawnAnimationSprite : IEnemySprite
    {
        private Texture2D texture;
        private int currentFrame;
        private Rectangle sourceRectangle;
        private int x, y;
        private bool spawned;

        public bool Spawn { get { return spawned; } }
        public SpawnAnimationSprite(Texture2D texture) {
            this.texture = texture;
            this.currentFrame = 0;
            this.sourceRectangle = new Rectangle(1, 1, 16, 16);
            this.x = 200; 
            this.y = 200;
            this.spawned = false;
        }
        public void Update() {
            currentFrame++;
            if (currentFrame == 10)
            {
                sourceRectangle.X = 18;
            }
            else if (currentFrame == 20) {
                sourceRectangle.X = 35;
            } 
            else if(currentFrame == 30)
            {
                spawned = true;
            }
        }
        public void Draw(SpriteBatch spriteBatch) {
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
