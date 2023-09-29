using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3
{
   public class NoItemState : IItemState
    {
        public NoItemState(Link link) 
        {
            link.ItemSprite = LinkSpriteFactory.Instance.RemoveItem();
        }

        public void Update()
        {

        }
        public void NoItemActive()
        {

        }

    }
}
