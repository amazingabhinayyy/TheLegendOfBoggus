﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Aquamentus;

namespace Sprint2_Attempt3.Projectile.AquamentusProjectiles;

internal class AquamentusFireballLeftState : IEnemyProjectileState
{
    private AquamentusFireball AquamentusFireball;
    private IEnemyProjectileSprite sprite;

    private static EnemyProjectileSpriteFactory enemyProjectileSpriteFactory;

   
    private int timeSinceLastUpdate;
    private int spriteIndex;
    private int currentFrame;
    private int currentFrame2;
    private int change;
    private int projDistance;
    private int traveledDistance;



    public AquamentusFireballLeftState(AquamentusFireball AquamentusFireball)
    {
        this.AquamentusFireball = AquamentusFireball;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.MovingFireball();

        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;

        projDistance = Globals.fireBallMaxDistance;
        change = Globals.fireballSpeed;
        traveledDistance = 0;

    }


    public void Update(/*gameTime gametime*/)
    {
        /*
        timeSinceLastUpdate += gametime.ElapsedGameTime;
        spriteIndex = (int)(timeSinceLastUpdate / (0.5f));
        if (spriteIndex > 7)
        {
            spriteIndex = 0;
            timeSinceLastUpdate = 0;
        }*/
        currentFrame++;
        if (currentFrame < Globals.fireballSpriteSwitchSpeed)
        {
            currentFrame2++;
            spriteIndex = currentFrame2 / 10;
            if (spriteIndex > 7)
            {
                spriteIndex = 0;
                currentFrame2 = 0;
            }
           
            
            AquamentusFireball.Position2 = new Vector2(AquamentusFireball.Position2.X - change, AquamentusFireball.Position2.Y);
            traveledDistance += change;
            if (traveledDistance>=projDistance)
            {
                    AquamentusFireball.Fire = false;
            }
            
        }
        else
        {
            currentFrame = 0;
        }

    }
    public void Draw(SpriteBatch spriteBatch)
    {
        sprite.Draw(spriteBatch, (int)AquamentusFireball.Position2.X+12, (int)(AquamentusFireball.Position2.Y+0.35*traveledDistance), Globals.AquamentusFireballLeft[spriteIndex]);
        sprite.Draw(spriteBatch, (int)AquamentusFireball.Position2.X+12, (int)(AquamentusFireball.Position2.Y), Globals.AquamentusFireballLeft[spriteIndex]);
        sprite.Draw(spriteBatch, (int)AquamentusFireball.Position2.X+12, (int)(AquamentusFireball.Position2.Y-0.35*traveledDistance), Globals.AquamentusFireballLeft[spriteIndex]);
    }
}
