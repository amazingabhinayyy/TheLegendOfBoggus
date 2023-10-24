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
    public class UpUseBlueArrowState : ILinkState
    {
        private Link link;
        private int frameCounter;
        public UpUseBlueArrowState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpItemLinkSprite(); ;
            UpBlueArrow blueArrow = new UpBlueArrow(link);
            link.Items.Add(blueArrow);
            CollisionDetector.GameObjectList.Add(blueArrow);
            frameCounter = 0;
        }
        public void Stop()
        {
            link.State = new UpIdleLinkState(link);
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

