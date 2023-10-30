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
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class DownUseItemState : ILinkState
    {
        private Link link;
        private int frameCounter;
        public DownUseItemState(Link link, ILinkProjectile item)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownItemLinkSprite();
            link.Items.Add(item);
            CollisionDetector.GameObjectList.Add(item);
            frameCounter = 0;
        }
        public void Stop()
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
