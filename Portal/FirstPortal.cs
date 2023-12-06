using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Portal
{
    public class FirstPortal : PortalSecondary
    {
        private static Rectangle src = new Rectangle(263, 20, 227, 466);
        public FirstPortal(Rectangle Position)
        {
            position = Position;
            sourceRectangle = src;
        }
    }
}
