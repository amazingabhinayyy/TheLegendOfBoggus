using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Projectile
{
    internal interface IEnemyProjectileSprite
    {
        public void Update();
        public void Draw(SpriteBatch spriteBatch, int x, int y, Rectangle sourceRectangle,SpriteEffects effect,Vector2 origin);

    }
}
