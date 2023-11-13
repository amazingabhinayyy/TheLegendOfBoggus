﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles;

namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates
{
    public class RightSword : Sword
    {
        public RightSword(Link link) : base(link)
        {
            itemPosition = new Vector2((int)link.Position.X + 45, (int)link.Position.Y + 24);
            flip = SpriteEffects.None;
        }

        public override void Update()
        {
            if (currentFrame >= 5 && currentFrame < 10)
            {
                sourceRectangle = new Rectangle(34, 85, 12, 3);
                HitBoxWidth = 36;
                HitBoxHeight = 9;
            }
            else if (currentFrame >= 10 && currentFrame < 15)
            {
                sourceRectangle = new Rectangle(60, 85, 9, 3);
                HitBoxWidth = 27;
                HitBoxHeight = 9;
            }
            else if (currentFrame >= 15 && currentFrame < 20)
            {
                sourceRectangle = new Rectangle(85, 85, 4, 3);
                HitBoxWidth = 12;
                HitBoxHeight = 9;
            }
            else if(currentFrame >= 20)
            {
                link.Items.Remove(this);
                CollisionManager.GameObjectList.Remove(this);
            }
            sprite.Update();
            currentFrame++;
        }
    }
}
