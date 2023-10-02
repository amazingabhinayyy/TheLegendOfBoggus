using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Zol;

using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Enemy.Keese
{
    internal class DeathAnimationState : IEnemyState
    {
        private IEnemy enemy;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private static EnemySpriteFactory enemySpriteFactory;
        private bool dead;
        public DeathAnimationState(IEnemy enemy)
        {
            this.enemy = enemy;
            enemySpriteFactory = new EnemySpriteFactory();
            sprite = EnemySpriteFactory.Instance.CreateDeathAnimationSprite();
            sourceRectangle = new Rectangle(39, 19, 15, 16);
            currentFrame = 0;
            dead = false;
        }
        public void ChangeDirection()
        {
            
        }
        public void ChangeAttackedStatus() {
            enemy.Spawn();
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
            if (!dead)
            {
                sprite.Draw(spriteBatch, enemy.X, enemy.Y, sourceRectangle);
            }
        }
    }
}
