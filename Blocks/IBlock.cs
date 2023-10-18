using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Blocks
{
    public interface IBlock : IGameObject
    {
        public Rectangle Position { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public void Draw(SpriteBatch spriteBatch);

    }
}




