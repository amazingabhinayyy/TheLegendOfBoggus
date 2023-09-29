using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items
{
    public class BombState : IItemState
    {
        private int frameCounter;
        private Link link;
        public BombState(Link link)
        {
            this.link = link;
            link.ItemSprite = LinkSpriteFactory.Instance.CreateBombItem();
            frameCounter = 0;
        }
        public void Update()
        {
            frameCounter++;
            if (frameCounter >= 60)
            {
                NoItemActive();
            }
        }
        public void NoItemActive()
        {
            link.ItemState = new NoItemState(link);
        }
    }
}
