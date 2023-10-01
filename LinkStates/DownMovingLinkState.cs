using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.LinkStates
{
    public class DownMovingLinkState : IState
    {
        private Link link;
        public DownMovingLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDownMovingLinkSprite();
        }
        public void BecomeIdle()
        {
            link.State = new DownIdleLinkState(link);
        }
        public void MoveUp()
        {
            link.State = new UpMovingLinkState(link);
        }
        public void MoveDown()
        {

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
            link.State = new DownDamagedLinkState(link);
        }
        public void Attack()
        {
            link.State = new DownAttackLinkState(link);
        }
        public void Update()
        {
            link.position.Y += 2;
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
    }
}