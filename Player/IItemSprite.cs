using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player
{
    public interface IItemSprite
    {
        public void Update(Link link);
        public void Draw(SpriteBatch spriteBatch, Vector2 location, Color color);
    }
}
