using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Enemy.Ganon;
using System.Runtime.CompilerServices;

namespace Sprint2_Attempt3.Enemy.Ganon
{
    internal class GanonDefeatedIdleState : IEnemyState
    {
        private Ganon ganon;
        private IEnemySprite sprite;
        private Rectangle sourceRectangle;

        private int currentFrame;
        private int elaspedFrameCount;
        private int endFrame;
        private int stunTimer;

        public GanonDefeatedIdleState(Ganon ganon)
        {
            this.ganon = ganon;
            sprite = EnemySpriteFactory.Instance.CreateVisibleGanonSprite();
            currentFrame = 0;
            sourceRectangle = new Rectangle(425, 541, 100,90);
            this.ganon.Position = new Rectangle(this.ganon.Position.X, this.ganon.Position.Y, (int)(sourceRectangle.Width * Globals.scale*ganon.GanonScale), (int)(sourceRectangle.Height * Globals.scale*ganon.GanonScale));
         
            elaspedFrameCount = 0;
            endFrame = 100;
            stunTimer = 0;
        }
        public void ChangeDirection()
        {
        }

        public void ChangeAttackedStatus()
        {
            
        }   
        public void Update()
        {
            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, ganon.Position.X, ganon.Position.Y, sourceRectangle);
        }

    }
}

