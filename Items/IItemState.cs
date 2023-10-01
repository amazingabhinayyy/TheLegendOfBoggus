using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Items
{
    public interface IItemState
    {
        public void Update();
        public void NoItemActive();
    }
}
