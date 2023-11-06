﻿using Sprint2_Attempt3.Player.Interfaces;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class KnockbackDownLinkState : ILinkState
    {
        int currentframe = 0;
        private Link link;
        public KnockbackDownLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownIdleLinkSprite();
        }
        public void FinishAnimation()
        {
            link.State = new DownIdleLinkState(link);
        }
        public void BecomeIdle()
        {
        }
        public void MoveUp()
        {
        }
        public void MoveDown()
        {
        }
        public void MoveLeft()
        {
        }
        public void MoveRight()
        {
        }
        public void GetDamaged()
        {

        }
        public void Attack()
        {
        }
        public void Update()
        {
            if (currentframe < 10)
            {
                link.Position = new Vector2(link.Position.X, link.Position.Y + 10);
                //link.Position.Y += 10;
            } 
            else
            {
                FinishAnimation();
            }
            currentframe++;
        }
        public void UseBomb()
        {
        }
        public void UseArrow()
        {
        }
        public void UseBoomerang()
        {
        }
        public void UseBlueBoomerang()
        {
        }
        public void UseBlueArrow()
        {
        }
        public void UseFire()
        {
        }
       
    }
}