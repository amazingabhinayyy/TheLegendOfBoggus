using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Sprint2_Attempt3
{
    public interface IController
    {
        public int EnemyIndex
        {
            get { return EnemyIndex; }
            set { EnemyIndex = value; }
        }
        void Update(GameTime gametime);

    }
}