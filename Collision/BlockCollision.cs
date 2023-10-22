using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Interfaces;
using System.ComponentModel;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Collision
{
    public class BlockCollisionClass : ICollision
    {
        public Vector2 LinkPosition { get; private set; }
        public ILink Link { get; }

        public bool collided;
        public Rectangle projectileObject;
        public List<Rectangle> wallBlocks;
        public Rectangle linkObject;
        public Rectangle enemyObject;
        public Link link;
        public EnemySecondary enemy;
        public Game1 game1;
        public BlockCollisionClass(Game1 game1)
        {
            wallBlocks = Globals.WallBlocks;
            //spriteObject = new Rectangle(0, 0, 0, 0);
            this.game1 = game1;
            this.link = (Link)game1.link;
            linkObject = this.game1.link.GetHitBox();
            this.enemy = (EnemySecondary)game1.enemy;
            //gethitbox for enemy? enemy
            //linkPosition = this.game1.link.position;
           
        }

        public BlockCollisionClass(Game1 game1, Link link1)
        {
            this.game1 = game1;
            Link = link1;
        }

        public void Update()
        {

            /*foreach (IGameObject obj in CollisionDetector.GameObjectList)
            {
                if (obj is IEnemy)
                {
                    enemyObject = obj.GetHitBox();
                    //System.Diagnostics.Debug.WriteLine("testEnemy");
                    collided = CheckCollision.CheckEnemyWallCollision(enemyObject, enemy);
                }
            }*/

            
            linkObject = this.game1.link.GetHitBox();
            collided = CheckCollision.CheckPlayerWallCollision(linkObject, link);
            
        }

        public void LinkEnemyKnockback(Link link)
        {
            throw new NotImplementedException();
        }
    }

}