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
    public class LeftUseFireState : ILinkState
    {
        private Link link;
        private int frameCounter;
        public LeftUseFireState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateLeftItemLinkSprite();
            //Constant is to make the item spawn infront of link
            link.ItemPosition = new Vector2(link.position.X - 45, link.position.Y);
            link.Items.Add(LinkSpriteFactory.Instance.CreateFireItem());
            link.Direction = Link.LinkDirection.Left;
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
            link.State = new LeftIdleLinkState(link);
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