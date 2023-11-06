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

        public DungeonRoom() { 
            sprite = DungeonSpriteFactory.Instance.CreateDungeonRoomSprite();
    }

        public void Draw(SpriteBatch spriteBatch) {
            sprite.Draw(spriteBatch, Globals.DungeonStandard);
        }
        public void Draw(SpriteBatch spriteBatch,Vector2 change)
        {
            sprite.Draw(spriteBatch, Globals.DungeonStandard, change);
        }
    }
}
