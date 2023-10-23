using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Player.LinkProjectiles
{
    public class BombExplosion : ILinkProjectile
    {
        private int currentFrame;
        private Link link;
        private ILinkProjectileSprite sprite;
        private SpriteEffects flip;
        private Rectangle sourceRectangle;
        private Vector2 itemPosition;
        private const int hitBoxWidth = 45;
        private const int hitBoxHeight = 45;
        private Vector2 startPosition;
        public BombExplosion(Link link, Vector2 position) 
        {
            this.link = link;
            currentFrame = 0;
            sprite = LinkSpriteFactory.Instance.CreateBombExplosion();
            itemPosition = position;
            sourceRectangle = new Rectangle(138, 185, 15, 15);
            flip = SpriteEffects.FlipHorizontally;
            startPosition.X = position.X - 22 * 3;
            startPosition.Y = position.Y - 15 * 3;

        }
        public void Update() 
        {
            if(currentFrame == 10)
            {
                CollisionDetector.GameObjectList.Remove(this);
                link.Items.Remove(this);
            }
            currentFrame++;
            sprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch) 
        {
            sprite.Draw(spriteBatch, itemPosition, sourceRectangle, flip);
        }
        public Rectangle GetHitBox()
        {
            return new Rectangle((int)startPosition.X, (int)startPosition.Y, hitBoxWidth * 3, hitBoxHeight * 3);
        }
    }
}
