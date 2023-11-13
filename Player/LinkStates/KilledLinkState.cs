using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class KilledLinkState : ILinkState
    {
        private Link link;
        public KilledLinkState(Link link) 
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateDeadLink();
        }

        public void Attack()
        {
        }

        public void BecomeIdle()
        {
        }

        public void GetDamaged()
        {
        }

        public void Killed()
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

        public void MoveUp()
        {
        }

        public void Update()
        {
        }

        public void UseArrow()
        {
        }

        public void UseBlueArrow()
        {
        }

        public void UseBlueBoomerang()
        {
        }

        public void UseBomb()
        {
        }

        public void UseBoomerang()
        {
        }

        public void UseFire()
        {
        }
        public void CollectBow()
        {

        }
        public void CollectTriForce()
        {

        }
    }
}
