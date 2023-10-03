using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3
{
    public interface IJustItemSprite
    {
        void Update();
        Rectangle DestRectangle();
        void Draw(SpriteBatch spriteBatch);
    }
}
