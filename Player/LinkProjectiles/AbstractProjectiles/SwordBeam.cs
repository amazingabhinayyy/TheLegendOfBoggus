﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectilesStates;
using Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces;

namespace Sprint2_Attempt3.Player.LinkProjectiles.AbstractProjectiles
{
    public abstract class SwordBeam : LinkProjectileSecondary, ISwordBeam
    {
        protected int speed;
        public SwordBeam(Link link) : base(link)
        {
            sprite = LinkSpriteFactory.Instance.CreateSwordBeamSprite();
            speed = 10;
        }
        public void RemoveSwordBeam()
        {
            link.Items.Remove(this);
            CollisionDetector.GameObjectList.Remove(this);
            link.Items.Add(new SwordBeamExplosion(link, itemPosition));
        }
    }
}