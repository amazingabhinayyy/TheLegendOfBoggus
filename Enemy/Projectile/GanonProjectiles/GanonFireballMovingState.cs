using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Ganon;
using System;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Collision;

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

    private Vector2 fireballPosition;
    private Vector2 slope;
    private GameTime gameTime;
    private Vector2 change;
    public GanonFireballMovingState(GanonFireball GanonFireball)
    {
        this.GanonFireball = GanonFireball;
        sprite = EnemyProjectileSpriteFactory.Instance.MovingGanonFireball();

        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;

        fireballPosition = GanonFireball.Position2;
        this.slope = GanonFireball.Slope;
        this.gameTime = GanonFireball.GameTime;

        actualLinkPosition.X = linkPosition.X + 7;
        actualLinkPosition.Y = linkPosition.Y + 7;

        if (Math.Abs(itemPosition.X - actualLinkPosition.X) > Math.Abs(itemPosition.Y - actualLinkPosition.Y))
        {
            if (itemPosition.X > actualLinkPosition.X)
            {
                newItemPosition.X -= speed;
            }
            else
            {
                newItemPosition.X += speed;
            }
            newItemPosition.Y = slope * newItemPosition.X + yInt;
        }
        else
        {
            if (itemPosition.Y > actualLinkPosition.Y)
            {
                newItemPosition.Y -= speed;
            }
            else
            {
                newItemPosition.Y += speed;
            }
            newItemPosition.X = (newItemPosition.Y - yInt) / slope;
        }
        return newItemPosition;

    }
    public void Update()
    {
        Vector2 fireballPosition = GanonFireball.Position2;
        Vector2 slope 


    }
    public void Draw(SpriteBatch spriteBatch)
    {
      
            sprite.Draw(spriteBatch, (int)GanonFireball.Position2.X, (int)GanonFireball.Position2.Y, GanonFireball.GanonFireballs[0]);
       
    }
}
