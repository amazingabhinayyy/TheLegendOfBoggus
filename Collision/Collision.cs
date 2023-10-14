using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy;

namespace Sprint2_Attempt3.Collision
{
    internal class CollisionClass : ICollision
    {
        private Vector2 linkPosition;
        private Vector2 linkArrow; 
        private Vector2 linkBlueArrow;
        private Vector2 linkBomb;
        private Vector2 linkFire;
        private Vector2 linkBoomerang;
        private Vector2 linkBlueBoomerang;
        public Vector2 LinkPosition { get; private set; }
        public CollisionClass()
        {
            
        }
        public void Update()
        {
            if(linkPosition.X < 50 || linkPosition.X > 750 || linkPosition.Y < 50 || linkPosition.Y > 450)
            {
                //link.Stop?s
            }
            foreach (IEnemy enemy in Globals.enemies)
            {
                if(enemy.X > (linkPosition.X - 90) && (enemy.X + 90) < linkPosition.X)
                {
                    //link.GetDamaged?
                }
                if (enemy.Y > (linkPosition.Y - 90) && (enemy.Y+ 90) < linkPosition.Y)
                {
                    //link.GetDamaged?
                }
                /*I think update sword variables to link sword global?
                if (enemy.X > (linkSword.X) && (enemy.X ) < linkSword.X)
                {
                    //enemy.kill?
                }
                if (enemy.Y > (linkSword.Y) && (enemy.Y) < linkSword.Y)
                {
                    //enemy.kill?
                }*/

            }
            /*
             * want to use this for blocks. since we do not have a block thing going on it will not run if this is not commented.
            foreach(IBlock block in Globals.blocks)
            {
                if (block.X > (linkPosition.X - 90) && (block.X + 90) < linkPosition.X)
                {
                    //link.stop?
                }
                if (block.Y > (linkPosition.Y - 90) && (block.Y + 90) < linkPosition.Y)
                {
                    //link.stop?
                }
            }
            */



        }
    }

}
