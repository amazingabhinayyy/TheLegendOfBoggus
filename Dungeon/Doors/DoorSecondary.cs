using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.Doors.DoorSprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Dungeon.Doors
{
    public class DoorSecondary : IDoor
    {
        protected Rectangle Position;
        protected Rectangle sourceRectangle;
        protected IDoorSprite sprite;
        protected static Dictionary<int, Action> actions;
        public DoorSecondary() {
            actions = new Dictionary<int, Action>() {
                { 0, () => { Open(); } },
                { 1, () => { Close(); } },
                { 2, () => { DiamondLock(); } },
                { 3, () => { Damage(); } }
            };
        }
        public void Close()
        {
            sourceRectangle.X = 292;
        }

        public void Damage()
        {
            sourceRectangle.X = 358;
        }

        public void DiamondLock()
        {
            sourceRectangle.X = 325;
        }

        public void Open()
        {
            sourceRectangle.X = 259;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch, sourceRectangle);
        }

        public Rectangle GetHitBox() {
            return Position;
        }
    }
}
