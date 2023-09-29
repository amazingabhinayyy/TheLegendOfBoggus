using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3
{
    public interface ISprite
    {

        void UpdateSprite();
       


        void Draw(SpriteBatch spriteBatch,Color color);

        
    }
}
