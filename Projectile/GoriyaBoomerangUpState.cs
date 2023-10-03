﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Goriya;

namespace Sprint2_Attempt3.Projectile;

internal class GoriyaBoomerangUpState : IEnemyProjectileState
{
    private GoriyaBoomerang goriyaBoomerang;
    private IEnemyProjectileSprite sprite;
    
    private static EnemyProjectileSpriteFactory enemyProjectileSpriteFactory;
    private bool goUp;
    /*private bool finished;
    public bool Finished
    {
        get { return finished; }
        set { finished = value; }
    }*/
    private int timeSinceLastUpdate;
    private int spriteIndex;
    private int currentFrame;
    private int currentFrame2;
    private int change;
  


    public GoriyaBoomerangUpState(GoriyaBoomerang goriyaBoomerang)
    {
        this.goriyaBoomerang = goriyaBoomerang;
        enemyProjectileSpriteFactory = new EnemyProjectileSpriteFactory();
        sprite = EnemyProjectileSpriteFactory.Instance.MovingBoomerang();
        
        timeSinceLastUpdate = 0;
        spriteIndex = 0;
        this.currentFrame = 0;
        this.currentFrame2 = 0;
        //finished = false;
        goUp = goriyaBoomerang.GoUp;
        change = Globals.boomerangSpeed;
  
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
        if (currentFrame < Globals.boomerangSpriteSwitchSpeed)
        {
            currentFrame2++;
            spriteIndex = (int)currentFrame2 / 10;
            if (spriteIndex > 7)
            {
                spriteIndex = 0;
                currentFrame2 = 0;
            }
            goUp = goriyaBoomerang.GoUp;
            if (goUp)
            {
                goriyaBoomerang.Position2 = new Vector2(goriyaBoomerang.Position2.X, goriyaBoomerang.Position2.Y-change);
                if (goriyaBoomerang.Position2.Y<=18)
                {
                    goriyaBoomerang.GoUp = false;
                }
            }
            else 
            {
                goriyaBoomerang.Position2 = new Vector2(goriyaBoomerang.Position2.X, goriyaBoomerang.Position2.Y+change);
                if (goriyaBoomerang.Position2.Y >= goriyaBoomerang.InitialY)
                {
                    Goriya.end = true;
                    goriyaBoomerang.GoUp = true;
                    //finished = true;
                   
                }
            }
        }
        else
        {
            currentFrame = 0;
        }

    }
    public void Draw(SpriteBatch spriteBatch)
    {
        sprite.Draw(spriteBatch, (int)goriyaBoomerang.Position2.X+6, (int)goriyaBoomerang.Position2.Y-18, Globals.GoriyaBoomerangUp[spriteIndex], Globals.GoriyaBoomerangLeftEffects[spriteIndex], Globals.originsLeft[spriteIndex]);
    }
}
