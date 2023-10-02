using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Projectile.GoriyaProjectiles;

namespace Sprint2_Attempt3.Enemy.Goriya
{
    internal class MovingDownGoriyaState : IEnemyState
    {
        private Goriya Goriya;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private int elaspedFrameCount;
        private int endFrame;
        public MovingDownGoriyaState(Goriya Goriya)
        {
            this.Goriya = Goriya;
            sprite = EnemySpriteFactory.Instance.CreateMovingDownGoriyaSprite();
            sourceRectangle = Globals.GoriyaRedDown;
            elaspedFrameCount = 0;
            endFrame = 100;
        }
        public void ChangeDirection()
        {
            Goriya.BoomerangPosition = new Vector2(Goriya.X, Goriya.Y);
            Goriya.Boomerang = new GoriyaBoomerang(Goriya.BoomerangPosition);
            ((GoriyaBoomerang)Goriya.Boomerang).GenerateDown();
            ((GoriyaBoomerang)Goriya.Boomerang).Throwing = true;
            Goriya.State = new AttackWithBoomerangDownState(Goriya);
        }
        public void ChangeAttackedStatus() {
            Goriya.State = new MovingAttackedDownGoriyaState(Goriya);
        }
        public void Update()
        {
            Goriya.Y += 1;
            sprite.Update();
            elaspedFrameCount++;
            if (elaspedFrameCount >= endFrame)
            {
                ChangeDirection();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, Goriya.X, Goriya.Y, sourceRectangle) ;
        }
    }
}
