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
        public bool DoorExists { get; private set; }
        public bool IsWalkable { get; private set; }
        public bool IsLocked { get; private set; }
        public bool IsDiamondLocked { get; private set; }
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
            IsLocked = true;
            IsDiamondLocked = false;
        }

        public void Damage()
        {
            sourceRectangle.X = 358;
            IsWalkable = true;
            IsLocked = false;
            IsDiamondLocked = false;
        }

        public void DiamondLock()
        {
            sourceRectangle.X = 325;
            IsWalkable = false;
            IsLocked = false;
            IsDiamondLocked = true;
        }

        public void Open()
        {
            sourceRectangle.X = 259;
            IsWalkable = true;
            IsLocked = false;
            IsDiamondLocked = false;
        }

        public void NoDoor()
        {
            DoorExists = false;
            IsWalkable = false;
            IsLocked = false;
            IsDiamondLocked = false;
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

        public void Draw(SpriteBatch spriteBatch, Vector2 change)
        {
            if (DoorExists)
            {
                sprite.Draw(spriteBatch, sourceRectangle, change);
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 change, Vector2 initialPos)
        {
            if (DoorExists)
            {
                sprite.Draw(spriteBatch, sourceRectangle, change, initialPos);
            }
        }
    }
}
