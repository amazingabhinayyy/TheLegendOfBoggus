using System;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Interfaces;

namespace Sprint2_Attempt3.Collision
{
    public class BlockCollisionClass : ICollision
    {
        public bool collided;
        private Game1 game1;
        public BlockCollisionClass(Game1 game1)
        {
            this.game1 = game1;  
        }

        public void Update()
        {

            foreach (IGameObject obj in CollisionDetector.GameObjectList)
            //foreach (IEnemy enemyObject in Globals.enemies)
            {
                if (obj is IEnemy)
                {
                    collided = CheckCollision.CheckEnemyWallCollision((IEnemy)obj);
                }
                else if (obj is ILinkProjectile)
                {
                    collided = CheckCollision.CheckProjectileWallCollision((ILinkProjectile)obj);
                }
            }

            collided = CheckCollision.CheckPlayerWallCollision(this.game1.link);
            
        }

        public void LinkEnemyKnockback(Link link)
        {
            throw new NotImplementedException();
        }
    }

}