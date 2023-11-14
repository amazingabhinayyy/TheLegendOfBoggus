using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using System;

namespace Sprint2_Attempt3.Enemy.SpikeTrap
{
    internal class MovingDownSpikeTrapState : IEnemyState
    {
        private SpikeTrap spikeTrap;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        public MovingDownSpikeTrapState(SpikeTrap spikeTrap)
        {
            this.spikeTrap = spikeTrap;
            sprite = EnemySpriteFactory.Instance.CreateSpkieTrapSprite();
            sourceRectangle = SpikeTrap.SpikeTrapSprite;
            spikeTrap.Position = new Rectangle(spikeTrap.X, spikeTrap.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void ChangeDirection()
        {
            spikeTrap.State = new MovingUpSpikeTrapState(spikeTrap);
        }
        public void ChangeAttackedStatus() {

        }
        public void Update()
        {
            spikeTrap.Y += 1;
            spikeTrap.Position = new Rectangle(spikeTrap.X, spikeTrap.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, spikeTrap.X, spikeTrap.Y, sourceRectangle);
        }
    }
}
