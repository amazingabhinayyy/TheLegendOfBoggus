using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Blocks
{
    public interface IBlockSprite
    {
        void Update();
        IItem Spawn(); // when called create new?
        Boolean Collected(); //item no longer drawn
        Rectangle DestRectangle();
        void Draw(SpriteBatch spriteBatch);
    }
}
