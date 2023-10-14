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
        IItem Spawn(); // when called create new?
        Boolean Collected(); //item no longer drawn
        Rectangle DestRectangle();
        void Draw(SpriteBatch spriteBatch);
    }
}
