﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3
{
    public interface IGameObject
    {
        public void Update();
        public Rectangle GetHitBox();
    }
}
