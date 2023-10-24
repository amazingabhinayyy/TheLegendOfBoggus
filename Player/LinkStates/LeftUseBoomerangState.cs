using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.LinkProjectiles;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class LeftUseBoomerangState : ILinkState
    {
        private Link link;
        private int frameCounter;
        public LeftUseBoomerangState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateLeftItemLinkSprite(); ;
            LeftBoomerang boomerang = new LeftBoomerang(link);
            link.Items.Add(boomerang);
            CollisionDetector.GameObjectList.Add(boomerang);
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
        public void GetCaptured()
        {
            link.State = new Captured(link);
        }
    }
}

