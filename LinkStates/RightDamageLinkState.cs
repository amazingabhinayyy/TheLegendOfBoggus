using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.LinkStates
{
    public class RightDamagedLinkState : IState
    {
        private Link link;
        public RightDamagedLinkState(Link link)
        {
            this.link = link;
        }
        public void BecomeIdle()
        {

        }
        public void MoveUp()
        {
            link.State = new UpDamagedLinkState(link);
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
        public void UseBlueBoomerang() { }
        public void UseBlueArrow()
        {

        }
    }
}
