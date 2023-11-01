using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles
{
    public abstract class Bomb : LinkProjectileSecondary, IBomb
    {
        public Bomb(Link link) : base(link)
        {
            sprite = LinkSpriteFactory.Instance.CreateBombItem();
            flip = SpriteEffects.None;
            sourceRectangle = new Rectangle(129, 185, 8, 15);
            HitBoxWidth = 24;
            HitBoxHeight = 45;
        }
        public void RemoveBomb()
        {
            link.Items.Remove(this);
            CollisionDetector.GameObjectList.Remove(this);
        }
        public void Explode()
        {
            RemoveBomb();
            BombExplosion explosion = new BombExplosion(link, itemPosition);
            link.Items.Add(explosion);
            CollisionDetector.GameObjectList.Add(explosion);
        }
        public override void Update()
        {
            currentFrame++;
            if (currentFrame == 50)
            {
                Explode();
            }
            sprite.Update();
        }
    }
}
