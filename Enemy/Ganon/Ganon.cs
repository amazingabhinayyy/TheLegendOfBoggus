using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3;
using System;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Enemy.Projectile.GanonProjectiles;
using Sprint2_Attempt3.Enemy.Ganon;
using Sprint2_Attempt3.Sounds;
using Sprint2_Attempt3.Player.Interfaces;
using System.Collections.Generic;
using Sprint2_Attempt3.Inventory;

namespace Sprint2_Attempt3.Enemy.Ganon
{
    internal class Ganon : EnemySecondary
    {
        private float ganonScale = 0.34f;
        public float GanonScale { get { return ganonScale; } }
        public List<IEnemyProjectile> Fireball { get; set; }
        public Vector2 FireballPosition { get; set; }
        private Game1 game1;
        public Game1 Game1 { get { return game1; } }

        private bool startOfBattle;
        public bool StartOfBattle { get { return startOfBattle; } set { startOfBattle = value; } }
        private bool invincible;
        public bool Invincible { get { return invincible; } set { invincible = value; } }
        public float Health { get { return this.health; } }

        private Rectangle sourceRectangle = new Rectangle(121, 368, 97, 89);

        
        public Ganon(int x, int y, Game1 game1)
        {
            this.X = x;
            this.Y = y;
            Position = new Rectangle(x,y, (int)(sourceRectangle.Width * Globals.scale * ganonScale), (int)(sourceRectangle.Height * ganonScale * Globals.scale));

            FireballPosition = new Vector2(x, y);
            Fireball = new List<IEnemyProjectile>();
            this.health = 5;
            this.game1 = game1;
            startOfBattle = true;
            invincible = false;
            
        }

        public override void Generate() {
            SoundFactory.PlaySound(SoundFactory.Instance.bowserRoar);
            State = new AttackedVisibleState(this);
        }

        public override void Update()
        {

            foreach(IEnemyProjectile fireball in Fireball)
            {
                fireball.Update();
            }
       
            
            if(invinciblityTimer > 0) 
            {
                invinciblityTimer--;
            }
            State.Update();
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);

            foreach (IEnemyProjectile fireball in Fireball)
            {
                fireball.Draw(spriteBatch);
            }
        }

        public override void GetDamaged(float damage)
        {
            if (!invincible)
            {
                health -= damage;
                State.ChangeAttackedStatus();
                SoundFactory.PlaySound(SoundFactory.Instance.enemyHit);

                if (health <= 0)
                {
                    Kill();
                    SoundFactory.Instance.ganonBossMusic.Pause();
                    SoundFactory.Instance.backgroundMusic.Play();
                }
            }
        }

        public override void MoveUp() { }
        public override void MoveDown() { }
        public override void MoveLeft() {}
        public override void MoveRight(){}

        public override void DropItem() { }

        public override void Stun(){}

        public override Rectangle GetHitBox()
        {
            if (!death)
            {
                return new Rectangle(this.Position.X, this.Position.Y, (int)(sourceRectangle.Width * Globals.scale * this.GanonScale), (int)(sourceRectangle.Height * Globals.scale * this.GanonScale));
                
            }
            return new Rectangle(0, 0, 0, 0);
        }
    }
}
