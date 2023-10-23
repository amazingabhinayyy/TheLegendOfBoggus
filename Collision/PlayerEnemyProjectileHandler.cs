﻿using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Player.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Collision
{
    internal class PlayerEnemyProjectileHandler
    {
        public static void HandleLinkProjectileCollision(ILink link, IEnemyProjectile projectile, ICollision side) 
        {
            link.GetDamaged(side);
        }
    }
}
