using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Player.LinkStates
{
    public interface IState
    {
        public void MoveUp();
        public void MoveDown();
        public void MoveLeft();
        public void MoveRight();
        public void GetDamaged();
        public void BecomeIdle();
        public void Attack();
        public void UseBomb();
        public void UseArrow();
        public void UseBoomerang();
        public void Update();
    }
}