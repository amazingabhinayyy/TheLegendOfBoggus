using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using System;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class MovingRightSpikeTrapState : IEnemyState
    {
        private SpikeTrap spikeTrap;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private Random random;
        private int direction;
        public MovingRightSpikeTrapState(SpikeTrap spikeTrap)
        {
            this.spikeTrap = spikeTrap;
            sprite = EnemySpriteFactory.Instance.CreateSpkieTrapSprite();
            sourceRectangle = Globals.SpikeTrapSprite;
            spikeTrap.Position = new Rectangle(spikeTrap.X, spikeTrap.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void ChangeDirection()
        {
            spikeTrap.State = new MovingDownSpikeTrapState(spikeTrap);
        }
        public void ChangeAttackedStatus()
        {

        }
        public void Update()
        {
            spikeTrap.X += 1;
            spikeTrap.Position = new Rectangle(spikeTrap.X, spikeTrap.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, spikeTrap.X, spikeTrap.Y, sourceRectangle);
        }
    }
}
