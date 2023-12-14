using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Ganon;
using System;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Collision;
using System.Reflection;

namespace Sprint2_Attempt3.Enemy.Projectile.GanonProjectiles;

internal class GanonFireballMovingState : IEnemyProjectileState
{
    private GanonFireball GanonFireball;
    private IEnemyProjectileSprite sprite;

    private int spriteIndex;
    private int currentFrame;
    private int currentFrame2;
    private int projDistance;
    private int traveledDistance;
    private int index;

    private Vector2 fireballPosition;
    private Vector2 linkPosition;
    private Vector2 velocity;
    private GameTime gameTime;
    private Vector2 change;
    private int distance;
    private double elapsedTime;
    private int count;
    private bool goLeft;
    public GanonFireballMovingState(GanonFireball GanonFireball)
    {
        this.GanonFireball = GanonFireball;
        sprite = EnemyProjectileSpriteFactory.Instance.MovingGanonFireball();
        fireballPosition = GanonFireball.Position2;
        linkPosition = GanonFireball.LinkPosition;
        elapsedTime = 0;
        distance = 50;

        this.gameTime = GanonFireball.GameTime;
        goLeft = fireballPosition.X > linkPosition.X;
        Vector2 direction = new Vector2(linkPosition.X - fireballPosition.X, linkPosition.Y - fireballPosition.Y);
        direction.Normalize();
        velocity = direction * distance;
    }


    public void Update()
    {
        /*
        Vector2 slope = new Vector2(linkPosition.X - fireballPosition.X, linkPosition.Y - fireballPosition.Y);
        float yIntercept = fireballPosition.Y - slope.Y / slope.X * fireballPosition.X;
        double time = gameTime.ElapsedGameTime.TotalSeconds;
        elapsedTime += time;

        if (elapsedTime >= 0.25f)
        {
            if (goLeft)
            {
                fireballPosition.X -= speed;

            }
            else 
            {
                fireballPosition.X += speed;
            }
            
            fireballPosition.Y = slope.Y / slope.X * fireballPosition.X + yIntercept;
            GanonFireball.Position2 = fireballPosition;
            elapsedTime = 0;
        }


        index = (int)(elapsedTime / (0.25f/4));
        */
        
        double time = gameTime.ElapsedGameTime.TotalSeconds;
        elapsedTime += time;

        if (elapsedTime >= 0.25f)
        {
           
                fireballPosition += velocity;
            
            GanonFireball.Position2 = fireballPosition;
            elapsedTime = 0;
        }


        index = (int)(elapsedTime / (0.25f / 4));



    }
    public void Draw(SpriteBatch spriteBatch)
    {
      
            sprite.Draw(spriteBatch, (int)GanonFireball.Position2.X, (int)GanonFireball.Position2.Y, GanonFireball.GanonFireballs[index]);
       
    }
}
