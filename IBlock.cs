using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public interface IBlock
    {
        public void Update();
        public void Draw(SpriteBatch spriteBatch, Color color);
        void CreateDiamondTile();
        void CreatePlainTile();
        public void plainTile();
        public void diamondTile();
    }
}
