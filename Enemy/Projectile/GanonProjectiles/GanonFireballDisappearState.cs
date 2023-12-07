﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Ganon;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;

namespace Sprint2_Attempt3.Enemy.Projectile.GanonProjectiles;

internal class GanonFireballDisappearState : IEnemyProjectileState
{
    private GanonFireball GanonFireball;
    private IEnemyProjectileSprite sprite;

    private static EnemyProjectileSpriteFactory enemyProjectileSpriteFactory;
    private bool goRight;
    private int timeSinceLastUpdate;
    private int spriteIndex;
    private int currentFrame;
    private int currentFrame2;
    private int change;
    private int projDistance;
    private int traveledDistance;


    public GanonFireballDisappearState(GanonFireball GanonFireball)
    {
        this.GanonFireball = GanonFireball;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.MovingGanonFireball();
        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;
        change = GanonFireball.fireballSpeed;
        traveledDistance = 0;

    }
    public void Update()
    {
        currentFrame++;
        if (currentFrame < GanonFireball.fireballSpriteSwitchSpeed)
        {
            currentFrame2++;
            spriteIndex = currentFrame2 / 10;
            if (spriteIndex > 7)
            {
                spriteIndex = 0;
                currentFrame2 = 0;

            }
            GanonFireball.Position2 = new Vector2(GanonFireball.Position2.X + change, GanonFireball.Position2.Y);
            traveledDistance += change;
            if (traveledDistance >= projDistance)
            {
               
            }
        }
        else
        {
            currentFrame = 0;
        }


    }
    public void Draw(SpriteBatch spriteBatch)
    {
        //need to go through
        sprite.Draw(spriteBatch, (int)GanonFireball.Position2.X, (int)GanonFireball.Position2.Y, GanonFireball.GanonFireballs[0]);

    }
}
