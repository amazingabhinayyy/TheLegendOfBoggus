using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sprint2_Attempt3.LinkStates
{
    public class UpUseArrowState : IState
    {
        private Link link;
        private int frameCounter;
        public UpUseArrowState(Link link)
        {
            this.link = link;
            link.Sprite = LinkSpriteFactory.Instance.CreateUpItemLinkSprite();
            link.ItemPosition = new Vector2(link.position.X, link.position.Y);
            link.Items.Add(LinkSpriteFactory.Instance.CreateArrowItem());
            link.Direction = Link.LinkDirection.Up;
            frameCounter = 0;
        }
        public void Stop()
        {
            link.State = new UpIdleLinkState(link);
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
            frameCounter++;
            if (frameCounter >= 10)
            {
                Stop();
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
        public void UseBlueBoomerang() { }
    }
}

