using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Collision
{
    internal class BlockCollisionClass : ICollision
    {
        private Vector2 linkPosition;
        public Vector2 LinkPosition { get; private set; }
        public bool collided;
        public Rectangle spriteObject;
        public List<Rectangle> wallBlocks;
        public BlockCollisionClass()
        {
            wallBlocks = Globals.WallBlocks;
            spriteObject = new Rectangle(0, 0, 0, 0);
        }
        public void Update()
        {/*
            
            foreach (Enemy in Globals)
            {
                collided = CheckCollision.CheckEnemyWallCollision(spriteObject, wallBlocks);
                if (collided)
                {
                    HandleEnemyBlockCollision();
                }
            }

            foreach (projectiles in Globals)
            {
                collided = CheckCollision.CheckProjectileWallCollision(spriteObject, wallBlocks);
            }
            
            
            collided = CheckCollision.CheckPlayerWallCollision(linkObject, wallBlocks);*/
        }
    }

}