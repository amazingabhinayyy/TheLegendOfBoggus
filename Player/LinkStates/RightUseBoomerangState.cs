﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class RightUseBoomerangState : ILinkState
    {
        private Link link;
        private int frameCounter;
        public RightUseBoomerangState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateRightItemLinkSprite();
            link.ItemPosition = new Vector2(link.position.X + 45, link.position.Y);
            link.Items.Add(LinkSpriteFactory.Instance.CreateBoomerangItem());
            link.Direction = Link.LinkDirection.Right;
            frameCounter = 0;
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
        public void Stop()
        {
            link.State = new RightIdleLinkState(link);
        }
        public void Update()
        {
            frameCounter++;
            if (frameCounter >= 10)
            {
                Stop();
            }
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
        public void UseBlueBoomerang() { }
        public void UseBlueArrow()
        {

        }
        public void UseFire()
        {

        }
        public void UseThrowingSword()
        {

        }
    }
}
