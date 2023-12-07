using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Enemy.Ganon;
using System.Runtime.CompilerServices;

namespace Sprint2_Attempt3.Enemy.Aquamentus
{
    internal class GanonDefeatedIdleState : IEnemyState
    {
        private Aquamentus ganon;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;
        public static Rectangle[] rectangles = new Rectangle[] { new Rectangle(51, 0, 24, 33), new Rectangle(76, 0, 24, 33) };

        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        private int stunTimer;

        public GanonDefeatedIdleState(Ganon ganon)
        {
            this.ganon = ganon;
            sprite = EnemySpriteFactory.Instance.CreateMovingLeftAquamentusSprite();
            currentFrame = 0;
            sourceRectangle = rectangles[0];
            this.ganon.Position = new Rectangle(this.ganon.X, this.ganon.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            //implement
            elaspedFrameCount = 0;
            endFrame = 100;
            stunTimer = 0;
        }
        public void ChangeDirection()
        {
            ganon.FireballPosition = new Vector2(ganon.X, ganon.Y);
            ganon.Fireball = new AquamentusFireball(ganon.FireballPosition);
            ((AquamentusFireball)ganon.Fireball).GenerateLeft();
            ganon.State = new AttackWithFireballLeftState(ganon);
        }

        public void ChangeAttackedStatus()
        {
            if(stunTimer >= 100)
                ganon.State = new MovingAttackedLeftAquamentusState(ganon);
        }   
        public void Update()
        {
            stunTimer++;
            ChangeDirection();
            ganon.Position = new Rectangle(ganon.X, ganon.Y, (int)(sourceRectangle.Width * Globals.scale), (int)(sourceRectangle.Height * Globals.scale));
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, ganon.X, ganon.Y, sourceRectangle);
        }
    }
}

