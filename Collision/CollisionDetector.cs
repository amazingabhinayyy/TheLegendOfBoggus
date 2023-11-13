using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;
using Sprint2_Attempt3.Dungeon.Doors;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.WallBlocks;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2_Attempt3.Collision
{
    public class CollisionDetector
    {
        public Vector2 LinkPosition { get; private set; }
        private static List<IGameObject> gameObjectList = new List<IGameObject>();
        public ILink linkObj;
        public static List<IGameObject> GameObjectList
        {
            get { return gameObjectList; }
            set { gameObjectList = value; }
        }
        private static int spawnItemCount;
        public static int SpawnItem
        {
            get { return spawnItemCount; }
            set { spawnItemCount = value; }
        }
        private static int spawnItemCountTrigger = 1;
        public static int SpawnItemTrigger { get { return spawnItemCountTrigger; } }
       

        private Game1 game;
        public CollisionDetector(Game1 game, ILink link)
        {
            spawnItemCount = 0;
            this.game = game;
            this.linkObj = link;
        }
        public void CheckPlayerCollision(ILink link)
        {
            Rectangle linkRectangle = link.GetHitBox();
            for(int c = 0; c < gameObjectList.Count; c++)
            {
                bool ChangedRooms = false;
                IGameObject obj = gameObjectList[c];
                Rectangle collisionRectangle = obj.GetHitBox();
                if (collisionRectangle.Intersects(linkRectangle))
                {
                    ICollision side = SideDetector(linkRectangle, collisionRectangle);
                    if (obj is IEnemy)
                    {
                        PlayerEnemyHandler.HandlePlayerEnemyCollision(link, (IEnemy)obj, side);
                    }
                    else if (obj is IWall)
                    {
                        CheckPlayerHitWallCollision.CheckPlayerWallCollision(linkObj);
                    }
                    else if (obj is IBlock)
                    {
                        PlayerBlockHandler.HandlePlayerBlockCollision(linkObj, (IBlock)obj, side);
                    }
                    else if (obj is IDoor)
                    {
                        ChangedRooms = PlayerBlockHandler.HandlePlayerDoorCollision(linkObj, (IDoor)obj, side, game);
                    }
                    else if(obj is ILinkProjectile)
                    {
                        PlayerLinkProjectileHandler.HandlePlayerLinkProjectileCollision(link, (ILinkProjectile)obj, side);
                    }
                    else if (obj is IItem)
                    {
                        ((IItem)obj).Collect();
                    } 
                    else if (obj is IEnemyProjectile)
                    {
                        PlayerEnemyProjectileHandler.HandleLinkProjectileCollision(link, (IEnemyProjectile)obj, side);
                    }
                }
                if (ChangedRooms) {
                    break;
                }
            }
        }
        public static ICollision SideDetector(Rectangle affectedSprite, Rectangle nonAffectedSprite)
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
                        IGameObject obj = gameObjectList[c];
                        Rectangle collisionRectangle = obj.GetHitBox();
                        if (collisionRectangle.Intersects(enemyRectangle))
                        {
                            ICollision side = SideDetector(collisionRectangle, enemyRectangle);
                            if (obj is ILinkProjectile)
                            {
                                EnemyLinkProjectileCollisionHandler.HandleLinkProjectileEnemyCollision((IEnemy)gameObjectList[i], (ILinkProjectile)gameObjectList[c], side, gameObjectList);
                            }
                            else if (obj is IBlock || obj is IDoor)
                            {
                                EnemyBlockHandler.HandleEnemyBlockCollision((IEnemy)gameObjectList[i], obj, collisionRectangle);
                            }
                        }
                    }
                }
            }
        }
        public void CheckEnemyWallCollision()
        {
            for (int i = 0; i < gameObjectList.Count; i++)
            {
                if (gameObjectList[i] is IEnemy)
                {

                    foreach (IWall wall in Globals.WallBlocks)
                    {
                        if (gameObjectList[i].GetHitBox().Intersects(wall.GetHitBox()))
                        {
                            EnemyWallHandler.HandleEnemyWallCollision(wall.GetHitBox(), (IEnemy)gameObjectList[i]);
                        }
                    }
                }
            }
        }
            public void CheckProjectileCollision()
        {
            for(int i = 0; i < gameObjectList.Count; i++)
            {
                Rectangle projectileRectangle = gameObjectList[i].GetHitBox();
                IGameObject projectile = gameObjectList[i];
                if(projectile is ILinkProjectile)
                {
                    Rectangle projHitBox = projectile.GetHitBox();
                    for(int c = 0; c < gameObjectList.Count; c++)
                    {
                        IGameObject obj = gameObjectList[c];
                        Rectangle collisionRectangle = obj.GetHitBox();
                        if (collisionRectangle.Intersects(projectileRectangle))
                        {
                            ICollision side = SideDetector(collisionRectangle, projectileRectangle);
                            if (gameObjectList[c] is IBlock)
                            {
                                ProjectileBlockCollisionHandler.HandleProjectileBlockCollision((IProjectile)projectile, (IBlock)obj, side);
                            }
                            else if (gameObjectList[c] is IWall)
                            {
                                ProjectileBlockCollisionHandler.HandleProjectileBlockCollision((IProjectile)projectile, (IWall)obj, side);
                            }
                            else if (gameObjectList[c] is IDoor)
                            {
                                ProjectileBlockCollisionHandler.HandleProjectileBlockCollision((IProjectile)projectile, (IDoor)obj, side);
                            }
                        }
                    }
                }
                else if (projectile is IEnemyProjectile)
                {
                    for (int c = 0; c < gameObjectList.Count; c++)
                    {

                        IGameObject obj = gameObjectList[c];
                        Rectangle collisionRectangle = obj.GetHitBox();
                        if (collisionRectangle.Intersects(projectileRectangle))
                        {
                            ICollision side = SideDetector(collisionRectangle, projectileRectangle);
                            if (gameObjectList[c] is IBlock)
                            {
                                //EnemyBlockCollisionHandler.CorrectPositioning();
                            }
                            else if (gameObjectList[c] is IWall)
                            {
                                EnemyProjectileBlockHandler.HandleEnemyProjectileBlockCollision((IProjectile)projectile, (IWall)obj, side);
                                //System.Diagnostics.Debug.WriteLine("enemy");
                                //HandleCollision.HandleProjectileBlockCollision((ILinkProjectile)gameObjectList[i]);
                            }
                            else if (gameObjectList[c] is IDoor)
                            {
                                EnemyProjectileBlockHandler.HandleEnemyProjectileBlockCollision((IProjectile)projectile, (IDoor)obj, side);
                            }
                        }
                    }
                }
            }
        }
        public void AddWallBlocks()
        {
            foreach(IWall wall in Globals.WallBlocks) 
                gameObjectList.Add(wall);
        }
        public void Update()
        {
            CheckPlayerCollision(game.link);
            CheckEnemyCollision();
            CheckProjectileCollision();
            CheckEnemyWallCollision();
        }
    }

}
