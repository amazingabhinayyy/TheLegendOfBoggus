using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Interfaces;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Player.Interfaces
{
    public interface ILink : IGameObject
    {
        public List<ILinkProjectile> Items { get; set; }
        public Vector2 Position { get; set; }
        public void Knockback(ICollision side);
        public void BecomeIdle();
        public void MoveUp();
        public void MoveDown();
        public void GetCaptured();
        public void MoveLeft();
        public void MoveRight();
        public void Attack();
        public void GetDamaged(ICollision side);
        public void UseBomb();
        public void UseArrow();
        public void UseBoomerang();
        public void UseBlueBoomerang();
        public void UseBlueArrow();
        public void UseFire();
        public void UseThrowingSword();
        public void Update();
        public void Draw(SpriteBatch spriteBatch, Color color);
        
    }
}
