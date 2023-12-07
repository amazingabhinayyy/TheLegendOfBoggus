using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.GanonProjectiles;
using System;
using System.Timers;

namespace Sprint2_Attempt3.Enemy.Ganon
{
    internal class AttackedVisibleState : IEnemyState
    {
        private Ganon ganon;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        private Rectangle[] sourceRectangles;
        private Random random;
        private double elapsedTime;
        private int endFrame;
        public AttackedVisibleState(Ganon ganon)
        {
            this.ganon = ganon;
            sprite = EnemySpriteFactory.Instance.CreateVisibleGanonSprite();
            // left arm up, standing menacingly, crissed arms, cat statue, two arms cat statue
            sourceRectangles = new Rectangle[] { new Rectangle(121, 368, 97, 89), new Rectangle(223, 367, 97, 89), new Rectangle(120, 540, 98, 90), new Rectangle(223, 541, 98, 90), new Rectangle(223, 541, 98, 89),new Rectangle(324, 541, 98, 90) };
           random = new Random();
            elapsedTime = 0;
            ganon.Position = new Rectangle(ganon.X, ganon.Y, (int)(sourceRectangle.Width * Globals.scale*ganon.GanonScale), (int)(sourceRectangle.Height * Globals.scale * ganon.GanonScale));

            if (ganon.StartOfBattle)
            {
                sourceRectangle = sourceRectangles[0];
                ganon.StartOfBattle = false;
            }
            else
            {
                sourceRectangle = sourceRectangles[random.Next(sourceRectangles.Length)];
            }
        }
        public void ChangeDirection()
        {
            ganon.State = new InvisibleFireballState(ganon);
           
        }
        public void ChangeAttackedStatus() {
            
        }
        public void Update()
        {
            GameTime gameTime = ganon.Game1.Gametime;
            double time = gameTime.ElapsedGameTime.TotalSeconds;
            elapsedTime += time;
            if (elapsedTime >=1.00f)
            {
                elapsedTime = 0;
                ChangeDirection();
            }
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, ganon.X, ganon.Y, sourceRectangle);
          
        }
    }
}
