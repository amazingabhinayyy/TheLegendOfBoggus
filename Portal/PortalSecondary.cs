using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Portal
{
    public class PortalSecondary : IPortal
    {
        public Rectangle position { get; set; }
        protected Rectangle sourceRectangle { get; set; }

        public PortalSecondary() { }
        public virtual void Update() { }
        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            spriteBatch.Draw(PortalSpriteFactory.Instance.portal, position, sourceRectangle, color);
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 change)
        {
            //Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width, sourceRectangle.Height);
            //sourceRectangle = new Rectangle(263, 20, 227, 466);
            //Rectangle destinationRectangle = new Rectangle(50, 50, 50, 20);
            Rectangle destinationRectangle = new Rectangle(position.X + (int)(change.X * 3.125), position.Y + (int)(change.Y * 3.125), 50, 50);
            
            spriteBatch.Draw(PortalSpriteFactory.Instance.portal, destinationRectangle, sourceRectangle, Color.White);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 change, Vector2 initialPos)
        {
            Rectangle newSourceRectangle = new Rectangle(sourceRectangle.X, sourceRectangle.Y, sourceRectangle.Width, sourceRectangle.Height);
            Rectangle destinationRectangle = new Rectangle((int)(position.X + initialPos.X + change.X * 3.125), (int)(position.Y + initialPos.Y + change.Y * 3.125), 50, 50);
            spriteBatch.Draw(PortalSpriteFactory.Instance.portal, destinationRectangle, sourceRectangle, Color.White);
        }

        public Rectangle GetHitBox()
        {
            return new Rectangle(position.X+24, position.Y+24,  1, 1);
        }
    }
}
