using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class UpAttackLinkState : IState
    {
        private Link link;
        private int count = 0;
        public UpAttackLinkState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpAttackLinkSprite();
            link.AttackSprite = LinkSpriteFactory.Instance.CreateUpAttackLinkSwordSprite();
        }
        public void FinishAttack()
        {
            link.State = new UpIdleLinkState(link);
            link.AttackSprite = LinkSpriteFactory.Instance.CreateSwordPlaceholderSprite();

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
    }
}