using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Rooms
{
    public class DungeonRoom
    {
        private DungeonRoomSprite sprite;

        public Rectangle GetHitBox()
        {
            return new Rectangle(0, 0, 0, 0);
        }

        public DungeonRoom() { 
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
    }

        public void Draw(SpriteBatch spriteBatch) {
            sprite.Draw(spriteBatch, Globals.Dungeon1);
        }
    }
}
