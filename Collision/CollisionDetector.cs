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
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Player.Interfaces;

namespace Sprint2_Attempt3.Collision
{
    public class CollisionDetector : ICollision
    {
        private Vector2 linkPosition;
        private Vector2 linkArrow; 
        private Vector2 linkBlueArrow;
        private Vector2 linkBomb;
        private Vector2 linkFire;
        private Vector2 linkBoomerang;
        private Vector2 linkBlueBoomerang;
        public Vector2 LinkPosition { get; private set; }
        private List<IGameObject> gameObjectList = new List<IGameObject>();
        private List<IGameObject> copyGameObjectList = new List<IGameObject>();
        public List<IGameObject> GameObjectList { get; set; }
        public CollisionDetector(Game game)
        {
            
        }
        public void CheckPlayerCollision(ILink link)
        {
            Rectangle linkRectangle = link.GetHitBox();
            foreach (IGameObject obj in gameObjectList){
                Rectangle collisionRectangle = obj.GetHitBox();
                if (collisionRectangle.Intersects(linkRectangle))
                {
                    ICollision side = SideDetector(linkRectangle, collisionRectangle);
                    if (obj is IEnemy)
                    {
                        if (obj is Hand)
                        {
                            PlayerCollisionHandler.GetCaptured();   
                        }
                        else
                        {
                            PlayerEnemyHandler.GetDamaged();
                        }
                    }
                    else if (obj is IBlock)
                    {
                        Rectangle rectangle = Rectangle.Intersect(collisionRectangle, linkRectangle);
                        if(rectangle.Width >= rectangle.Height)
                        {
                            if(link.Position.Y > obj.position.Y)
                            {
                                PlayerBlockHandler.CorrectPositioning(High);
                            } else
                            {
                                PlayerBlockHandler.CorrectPositioning(Low);
                            } 
                        } else
                        {
                            if (link.Position.X > obj.position.X)
                            {
                                PlayerBlockHandler.CorrectPositioning(left);
                            }
                            else
                            {
                                PlayerBlockHandler.CorrectPositioning(Right);
                            }
                        }

                        link.CorrectPositioning(rectangle);
                    }
                }
            }
        }
        public ICollision SideDetector(Rectangle affectedSprite, Rectangle nonAffectedSprite)
        {
            Rectangle intersect = Rectangle.Intersect(affectedSprite, nonAffectedSprite);
            if (intersect.Width > intersect.Height)
            {
                if (affectedSprite.Top < nonAffectedSprite.Top && affectedSprite.Bottom < nonAffectedSprite.Bottom)
                {
                    return new TopCollision();
                }
                else
                {
                    return new BottomCollision();
                }
            }
            else
            {
                if (affectedSprite.Left < nonAffectedSprite.Left & affectedSprite.Right < nonAffectedSprite.Right)
                {
                    return new LeftCollision();
                }
                else
                {
                    return new RightCollision();
                }
            }
        }

        public void CheckEnemyCollision(IEnemy enemy)
        {
            Rectangle enemyRectangle = enemy.GetHitBox();
            foreach (IGameObject obj in gameObjectList)
            {
                Rectangle collisionRectangle = obj.GetHitBox();
                if (collisionRectangle.Intersects(enemyRectangle))
                {
                    if (obj is ILinkItem)
                    {
                        EnemyItemCollisionHandler.Kill();
                    }
                    else if (obj is IBlock)
                    {
                        EnemyBlockCollisionHandler.CorrectPositioning();
                    }
                }
            }
        }
        public void Update()
        {
            
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
