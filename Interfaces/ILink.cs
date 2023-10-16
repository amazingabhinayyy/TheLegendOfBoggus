using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Interfaces
{
    public interface ILink : IGameObject
    {
        public void BecomeIdle();
        public void MoveUp();
        public void MoveDown();
        public void MoveLeft();
        public void MoveRight();
        public void Attack();
        public void GetDamaged();
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
