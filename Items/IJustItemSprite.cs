using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Items
{
    public interface IJustItemSprite
    {
        void Update();
        void Spawn();
        void Collected();
        Rectangle DestRectangle();
        void Draw(SpriteBatch spriteBatch);
    }
}
