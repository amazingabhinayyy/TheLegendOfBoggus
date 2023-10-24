using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player.LinkProjectiles;
﻿using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class UpAttackLinkState : ILinkState
    {
        private Link link;
        private int count = 0;
        public UpAttackLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpAttackLinkSprite();
            UpSword sword = new UpSword(link);
            link.Items.Add(sword);
            CollisionDetector.GameObjectList.Add(sword);
        }
        public void FinishAttack()
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
            count++;
            if (count > 30)
            {
                FinishAttack();
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