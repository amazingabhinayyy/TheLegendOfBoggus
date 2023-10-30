using Sprint2_Attempt3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

<<<<<<<< HEAD:Player/LinkProjectiles/ProjectileInterfaces/IBoomerang.cs
namespace Sprint2_Attempt3.Player.LinkProjectiles.ProjectileInterfaces
========
namespace Sprint2_Attempt3.Player.LinkProjectiles.LinkProjectiles
>>>>>>>> master:Player/LinkProjectilesStates/IBoomerang.cs
{
    public interface IBoomerang : ILinkProjectile
    {
        public Vector2 BoomerangPositionUpdater(Vector2 itemPosition, Vector2 linkPosition, int speed);
        public void ReverseDirection();
    }
}
