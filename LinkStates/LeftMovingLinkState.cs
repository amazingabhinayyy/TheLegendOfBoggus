using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.LinkStates
{
    public class LeftMovingLinkState : IState
    {
        private Link link;
        public LeftMovingLinkState(Link link)
        {
            this.link = link;
            
            link.Sprite = LinkSpriteFactory.Instance.CreateLeftMovingLinkSprite();
        }
        public void BecomeIdle()
        {
            link.State = new LeftIdleLinkState(link);
        }
        public void MoveUp()
        {
            link.State = new UpMovingLinkState(link);
        }
        public void MoveDown()
        {
            link.State = new DownMovingLinkState(link);
        }
        public void MoveLeft()
        {
        }
        public void MoveRight()
        {
            link.State = new RightMovingLinkState(link);
        }
        public void GetDamaged()
        {
            link.State = new LeftDamagedLinkState(link);
        }
        public void Attack()
        {
            link.State = new LeftAttackLinkState(link);
        }
        public void Update()
        {
            link.position.X -= 2;
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
    }
}