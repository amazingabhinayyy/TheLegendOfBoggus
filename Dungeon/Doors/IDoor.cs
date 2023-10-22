using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    public interface IDoor : IGameObject
    {
        public void Open();
        public void Close();
        public void DiamondLock();
        public void Damage();
        public void Draw(SpriteBatch spriteBatch);
    }
}
