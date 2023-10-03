using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3
{
    public interface ILink
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
