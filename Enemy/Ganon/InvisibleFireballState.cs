using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Enemy.Ganon;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.GanonProjectiles;
using System;

namespace Sprint2_Attempt3.Enemy.Ganon
{
    internal class InvisibleFireballState : IEnemyState
    {
        private Ganon ganon;
        private Game1 game1;
        private double elapsedTime;
        private Random random;
        private Rectangle sourceRectangle;
        private int count;
        private IEnemySprite sprite;
        public InvisibleFireballState(Ganon ganon)
        {
            this.ganon = ganon;
            sourceRectangle = new Rectangle(121, 368, 97, 89);
            this.game1 = ganon.Game1;
            elapsedTime = 0;
            this.random = new Random();
            count = 0;
            sprite = EnemySpriteFactory.Instance.CreateVisibleGanonSprite();
        }
        public void ChangeDirection()
        {
                            
        }
        public void ChangeAttackedStatus() {
            if (ganon.Health > 1)
                ganon.State = new AttackedVisibleState(ganon);
            else
                ganon.State = new GanonDefeatedIdleState(ganon);
        }
        public void Update()
        {
            GameTime gameTime = ganon.Game1.Gametime;
            double time = gameTime.ElapsedGameTime.TotalSeconds;
            elapsedTime += time;
            if (elapsedTime >= 1.25f)
            {
                count++;
                Vector2 linkPos = game1.link.Position;
                int posX = random.Next(100, 575);
                while (Math.Abs(posX-linkPos.X)>400)
                {
                    posX = random.Next(100, 575);
                }

                int posY = random.Next(Globals.YOffset+100, 275+Globals.YOffset);
                while (Math.Abs(posY - linkPos.Y) > 400)
                {
                    posY = random.Next(Globals.YOffset + 100, 275 + Globals.YOffset);
                }

                ganon.Position = new Rectangle(posX, posY, (int)(sourceRectangle.Width * Globals.scale * ganon.GanonScale), (int)(sourceRectangle.Height * ganon.GanonScale * Globals.scale));
                Vector2 FireballPosition = new Vector2(ganon.Position.X, ganon.Position.Y);
                Vector2 linkPosition = new Vector2(linkPos.X + 7, linkPos.Y + 7);
                GanonFireball fire = new GanonFireball(FireballPosition, linkPosition, gameTime);
                CollisionManager.GameObjectList.Add((IGameObject)fire);
                ganon.Fireball.Add(fire);
                elapsedTime = 0;  
            }

            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, ganon.Position.X, ganon.Position.Y, sourceRectangle);
        }
    }
}
