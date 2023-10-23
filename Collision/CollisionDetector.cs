﻿using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Interfaces;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkProjectiles;
using System.Collections.Generic;

namespace Sprint2_Attempt3.Collision
{
    public class CollisionDetector
    {
        public Vector2 LinkPosition { get; private set; }
        private static List<IGameObject> gameObjectList = new List<IGameObject>();
        public static List<IGameObject> GameObjectList
        {
            get { return gameObjectList; }
            set { gameObjectList = value; }
        }
        private Game1 game;
        public CollisionDetector(Game1 game)
        {
            this.game = game;
        }

        public void CheckPlayerCollision(ILink link)
        {
            Rectangle linkRectangle = link.GetHitBox();
            foreach (IGameObject obj in gameObjectList)
            {
                Rectangle collisionRectangle = obj.GetHitBox();
                if (collisionRectangle.Intersects(linkRectangle))
                {
                    //Rectangle intersectRect = Rectangle.Intersect(collisionRectangle, linkRectangle);

                    ICollision side = SideDetector(linkRectangle, collisionRectangle);
                    if (obj is IEnemy)
                    {
                        if (obj is Hand)
                        {
                            //PlayerCollisionHandler.GetCaptured();   
                        }
                        else
                        {
                            PlayerEnemyHandler.HandlePlayerEnemyCollision(link, (IEnemy)obj, side);
                        }
                    }
                    else if (obj is IBlock)
                    {
                        PlayerBlockHandler.HandlePlayerBlockCollision(link, (IBlock)obj, side);
                    }
                    else if(obj is ILinkProjectile)
                    {
                        PlayerLinkProjectileHandler.HandlePlayerLinkProjectileCollision(link, (ILinkProjectile)obj, side);
                    }
                }
            }
        }
        public static ICollision SideDetector(Rectangle affectedSprite, Rectangle nonAffectedSprite)
        {
            Rectangle intersect = Rectangle.Intersect(affectedSprite, nonAffectedSprite);
            if (intersect.Width > intersect.Height)
            //if (CollisionRect.Width > CollisionRect.Height)
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
                if (affectedSprite.Left < nonAffectedSprite.Left && affectedSprite.Right < nonAffectedSprite.Right)
                {
                    return new LeftCollision();
                }
                else
                {
                    return new RightCollision();
                }
            }
        }

        public void CheckEnemyCollision()
        {
            for (int i = 0; i < gameObjectList.Count; i++)
            {
                if (gameObjectList[i] is IEnemy) {
                    Rectangle enemyRectangle = gameObjectList[i].GetHitBox();
                    for (int c = 0; c < gameObjectList.Count; c++)
                    {
                        Rectangle collisionRectangle = gameObjectList[c].GetHitBox();
                        if (collisionRectangle.Intersects(enemyRectangle))
                        {
                            ICollision side = SideDetector(collisionRectangle, enemyRectangle);
                            if (gameObjectList[c] is ILinkProjectile)
                            {
                                EnemyLinkProjectileCollisionHandler.HandleLinkProjectileEnemyCollision((IEnemy)gameObjectList[i], (ILinkProjectile)gameObjectList[c], side);
                            }
                            else if (gameObjectList[c] is IBlock)
                            {
                                //EnemyBlockCollisionHandler.CorrectPositioning();
                            }
                        }
                    }
                }
            }
        }
        public void Update()
        {
            CheckPlayerCollision(game.link);
            CheckEnemyCollision();

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
