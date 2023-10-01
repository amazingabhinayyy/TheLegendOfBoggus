using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.LinkStates
{
    public class DownDamagedLinkState : IState
    {
        private Link link;
        public DownDamagedLinkState(Link link)
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
        public void UseBlueBoomerang() 
        { 
        }
        public void UseBlueArrow()
        {

        }
    }
}