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
        private bool DoorExists;
        public bool IsWalkable { get; private set; }
        protected static Dictionary<int, Action> actions;
        public DoorSecondary() {
            DoorExists = true;
            actions = new Dictionary<int, Action>() {
                { 0, () => { Open(); } },
                { 1, () => { Close(); } },
                { 2, () => { DiamondLock(); } },
                { 3, () => { Damage(); } },
                { 4, () => { NoDoor(); } }
            };
        }
        public void Update() { }
        public void Close()
        {
            sourceRectangle.X = 292;
            IsWalkable = false;
        }

        public void Damage()
        {
            sourceRectangle.X = 358;
            IsWalkable = true;
        }

        public void DiamondLock()
        {
            sourceRectangle.X = 325;
            IsWalkable = false;
        }

        public void Open()
        {
            sourceRectangle.X = 259;
            IsWalkable = true;
        }

        public void NoDoor()
        {
            DoorExists = false;
            IsWalkable = false;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (DoorExists)
            {
                sprite.Draw(spriteBatch, sourceRectangle);
            }
        }

        public virtual Rectangle GetHitBox() {
            return Position;
        }
    }
}
