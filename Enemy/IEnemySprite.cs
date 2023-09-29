using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Enemy
{
    internal interface IEnemySprite
    {
        public void Update();
        public void Draw(SpriteBatch spriteBatch);

    }
}
