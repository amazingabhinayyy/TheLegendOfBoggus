using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.Items;

namespace Sprint2_Attempt3.Blocks.BlockSprites
{
    public class BlackBlock : BlockSecondary
    {
        public Rectangle position { get; set; }
        public BlackBlock(Rectangle Position)
        {
            position = Position;
            sourceRectangle = Globals.blackBlockScr;
            CollisionDetector.GameObjectList.Add(this);
        }
    }
}
