using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface IBlockSprite
    {
        void Update();
        Rectangle DestRectangle();
        void Draw(SpriteBatch spriteBatch);
    }
}
