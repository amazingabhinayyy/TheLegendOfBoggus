using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3;

namespace Sprint2_Attempt3.Enemy
{
    public interface IEnemyProjectile
    {
        public void Generate();
        public void Update(GameTime gametime);
        public void Draw(SpriteBatch spriteBatch, int x, int y);
    }
}
