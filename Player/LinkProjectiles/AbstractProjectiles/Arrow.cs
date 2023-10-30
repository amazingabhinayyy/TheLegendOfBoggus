using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;

namespace Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles
{
    public abstract class Arrow : ProjectileSecondary, IArrow
    {
        //protected ILinkProjectileSprite Sprite { set { sprite = value; } }
        //protected Vector2 ItemPosition { set { itemPosition = value; } }
        //protected Rectangle SourceRectangle { set { sourceRectangle = value; } }

        public Arrow(Link link) : base(link)
        {
            sprite = LinkSpriteFactory.Instance.CreateArrowItem();
        }
        public void DestroyArrow()
        {
            link.Items.Remove(this);
            link.Items.Add(new ItemHit(link, itemPosition));
            CollisionDetector.GameObjectList.Remove(this);
        }
    }
}
