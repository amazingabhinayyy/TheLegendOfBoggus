using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles;

namespace Sprint2_Attempt3.Player.LinkProjectiles
{
    public class DownBoomerang : Boomerang
    {
        public DownBoomerang(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.position.X + 12, (int)link.position.Y + 45);
            sourceRectangle = new Rectangle(64, 189, 7, 7);
            sprite = LinkSpriteFactory.Instance.CreateBoomerangItem();
        }
        public override void Update()
        {
            int speed;
            if (!changeDirection && currentFrame >= 0 && currentFrame < 50)
            {
                speed = 5;
                itemPosition.Y = itemPosition.Y + speed;
            }
            else if (!changeDirection && currentFrame >= 50 && currentFrame < 60)
            {
                speed = 2;
                itemPosition.Y = itemPosition.Y + speed;
            }
            else if (!changeDirection && currentFrame >= 60 && currentFrame < 70)
            {
                speed = -2;
                itemPosition.Y = itemPosition.Y + speed;
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