using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectile;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class AttackWithBoomerangUpState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int currentFrame;
        private int currentBoomerangFrame;
        private IEnemyProjectile boomerang;
       
        public AttackWithBoomerangUpState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingUpGoriyaSprite();
            currentFrame = 0;
            currentBoomerangFrame = 0;
            sourceRectangle = Globals.GoriyaRedUp;
            boomerang = Goriya.Boomerang;
         

        }
        public void ChangeDirection()
        {
            if (Goriya.end)
            {
                Goriya.State = new MovingRightGoriyaState(Goriya);
                Goriya.end = false;
            }
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new MovingAttackedUpGoriyaState(Goriya);
        }
        public void Update()
        {
            sprite.Update();
            boomerang.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle);
            boomerang.Draw(spriteBatch);
        }
    }
}
