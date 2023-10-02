using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.LinkStates
{
    public class RightMovingLinkState : IState
    {
        private Link link;
        public RightMovingLinkState(Link link) 
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateRightMovingLinkSprite();
        }
        public void BecomeIdle()
        {
            link.State = new RightIdleLinkState(link);
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
            link.position.X += 2;
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
        public void UseBlueArrow()
        {
            link.State = new RightUseBlueArrowState(link);
        }
        public void UseFire()
        {
            link.State = new RightUseFireState(link);
        }
        public void UseThrowingSword()
        {

        }
    }
}
