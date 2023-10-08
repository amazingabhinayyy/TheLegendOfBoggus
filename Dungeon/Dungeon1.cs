using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon
{
    internal class Dungeon1 : DungeonSecondary
    {
        DungeonSprite sprite;
        public Dungeon1() {
            sprite = DungeonSpriteFactory.Instance.CreateDungeonSprite();
            northDoor = DungeonSpriteFactory.Instance.CreateOpenNorthDoorSprite();
            southDoor = DungeonSpriteFactory.Instance.CreateOpenSouthDoorSprite();
            eastDoor = DungeonSpriteFactory.Instance.CreateOpenEastDoorSprite();
            westDoor = DungeonSpriteFactory.Instance.CreateOpenWestDoorSprite();
        }
        public override void Draw(SpriteBatch spriteBatch) {
            sprite.Draw(spriteBatch, Globals.Dungeon1);
            northDoor.Draw(spriteBatch);
            southDoor.Draw(spriteBatch);
            eastDoor.Draw(spriteBatch);
            westDoor.Draw(spriteBatch);
        }
    }
}
