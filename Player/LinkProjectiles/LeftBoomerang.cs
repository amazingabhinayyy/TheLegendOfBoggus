using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Player.LinkProjectiles
{
    public class LeftBoomerang : Boomerang
    {
        public LeftBoomerang(Link link) : base(link)
        {
            this.ItemPosition = new Vector2((int)link.position.X - 23, (int)link.position.Y + 12);
            this.SourceRectangle = new Rectangle(64, 189, 7, 7);
            this.Sprite = LinkSpriteFactory.Instance.CreateBoomerangItem();
        }
        public override void Update()
        {
            int speed;
            if (!changeDirection && currentFrame >= 0 && currentFrame < 50)
            {
                speed = 5;
                itemPosition.X = itemPosition.X - speed;
            }
            else if (!changeDirection && currentFrame >= 50 && currentFrame < 60)
            {
                speed = 2;
                itemPosition.X = itemPosition.X - speed;
            }
            else if (!changeDirection && currentFrame >= 60 && currentFrame < 70)
            {
                speed = -2;
                itemPosition.X = itemPosition.X - speed;
            }
            else
            {
                itemPosition = BoomerangPositionUpdater(itemPosition, link.position, 5);
            }
            sprite.Update();
            currentFrame++;

        }
    }
}