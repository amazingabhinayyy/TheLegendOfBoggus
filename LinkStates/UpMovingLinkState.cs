using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.LinkStates
{
    public class UpMovingLinkState : IState
    {
        private Link link;

        public UpMovingLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpMovingLinkSprite();
        }
        public void BecomeIdle()
        {
            link.State = new UpIdleLinkState(link);
        }
        public void MoveUp()
        {
        }
        public void MoveDown()
        {
            link.State = new DownMovingLinkState(link);
        }
        public void MoveLeft()
        {
            link.State = new LeftMovingLinkState(link);
        }
        public void MoveRight()
        {
            link.State = new RightMovingLinkState(link);
        }
        public void GetDamaged()
        {
            link.State = new UpDamagedLinkState(link);
        }
        public void Attack()
        {
            link.State = new UpAttackLinkState(link);
        }
        public void Update()
        {
            link.position.Y -= 2;
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
