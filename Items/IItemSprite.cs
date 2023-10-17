using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Items
{
    public interface IItemSprite
    {
        void Draw(SpriteBatch spriteBatch, Rectangle position, Rectangle sourceRectangle);
    }
}
