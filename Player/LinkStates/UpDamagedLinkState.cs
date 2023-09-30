using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public class UpDamagedLinkState : IState
    {
        private Link link;
        public UpDamagedLinkState(Link link)
        {
            this.link = link;
        }
        public void BecomeIdle()
        {

        }
        public void MoveUp()
        {

        }
        public void MoveDown()
        {
            link.State = new DownDamagedLinkState(link);
        }
        public void MoveLeft()
        {
            link.State = new LeftDamagedLinkState(link);

        }
        public void MoveRight()
        {
            link.State = new RightDamagedLinkState(link);
        }
        public void GetDamaged()
        {

        }
        public void Attack()
        {

        }
        public void Update()
        {

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