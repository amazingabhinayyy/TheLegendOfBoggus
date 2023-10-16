using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Interfaces
{
    public interface ILinkItem : IGameObject
    {
        public void Update();
        public void Draw(SpriteBatch spriteBatch);
    }
}
