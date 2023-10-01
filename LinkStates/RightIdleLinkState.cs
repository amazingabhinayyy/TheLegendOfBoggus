using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.LinkStates
{
    public class RightIdleLinkState : IState
    {
        private Link link;
        public RightIdleLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateRightIdleLinkSprite();
        }
        public void BecomeIdle()
        {
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
            link.State = new LeftMovingLinkState(link);
        }
        public void MoveRight()
        {
            link.State = new RightMovingLinkState(link);
        }
        public void GetDamaged()
        {
            link.State = new RightDamagedLinkState(link);
        }
        public void Attack()
        {
            link.State = new RightAttackLinkState(link);
        }
        public void Update()
        {

        }
        public void UseBomb()
        {
            link.State = new RightUseBombLinkState(link);
        }
        public void UseArrow()
        {
            link.State = new RightUseArrowState(link);
        }
        public void UseBoomerang()
        {
            link.State = new RightUseBoomerangState(link);
        }
        public void UseBlueBoomerang() 
        {
            link.State = new RightUseBlueBoomerangState(link);
        }
    }
}