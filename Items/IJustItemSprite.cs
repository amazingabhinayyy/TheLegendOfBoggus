using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Items
{
    public interface IJustItemSprite
    {
        void Update();
        Rectangle DestRectangle();
        void Draw(SpriteBatch spriteBatch);
    }
}
