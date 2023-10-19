﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Interfaces;
using System.ComponentModel;

namespace Sprint2_Attempt3.Collision
{
    internal class BlockCollisionClass : ICollision
    {
        private Vector2 linkPosition;
        public Vector2 LinkPosition { get; private set; }
        public bool collided;
        public Rectangle projectileObject;
        public List<Rectangle> wallBlocks;
        public Rectangle linkObject;
        public Rectangle enemyObject;
        //private Link link;
        private Game1 game1;
        public BlockCollisionClass(Game1 game1)
        {
            wallBlocks = Globals.WallBlocks;
            //spriteObject = new Rectangle(0, 0, 0, 0);
            //this.link = link;
            this.game1 = game1;
            linkObject = this.game1.link.GetHitBox();
            //linkPosition = this.game1.link.position;
           
        }
        public void Update()
        {

            /*foreach (Enemy enemy in Globals)
            {
                enemyObject = enemy.GetHitBox();
                collided = CheckCollision.CheckEnemyWallCollision(enemyObject, wallBlocks);
                /*if (collided)
                {
                    HandleEnemyBlockCollision();
                }
            }

            foreach (projectiles in Globals)
            {
                collided = CheckCollision.CheckProjectileWallCollision(projectileObject, wallBlocks);
            }
            */

            linkObject = this.game1.link.GetHitBox();
            System.Diagnostics.Debug.WriteLine((int)linkObject.X);
            collided = CheckCollision.CheckPlayerWallCollision(linkObject, wallBlocks);
            /*if (!collided)
            {
                System.Diagnostics.Debug.WriteLine(collided);
            }*/
            
        }
    }

}