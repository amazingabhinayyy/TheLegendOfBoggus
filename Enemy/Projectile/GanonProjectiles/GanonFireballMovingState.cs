using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy.Keese;
using System;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Collision;

namespace Sprint2_Attempt3.Enemy.Projectile.AquamentusProjectiles;

internal class GanonFireballMovingState : IEnemyProjectileState
{
    private GanonFireball GanonFireball;
    private IEnemyProjectileSprite sprite;

    private int spriteIndex;
    private int currentFrame;
    private int currentFrame2;
    private int change;
    private int projDistance;
    private int traveledDistance;

    public GanonFireballMovingState(GanonFireball GanonFireball)
    {
        this.GanonFireball = GanonFireball;
        sprite = EnemyProjectileSpriteFactory.Instance.MovingFireball();

        spriteIndex = 0;
        currentFrame = 0;
        currentFrame2 = 0;

        projDistance = GanonFireball.fireBallMaxDistance;
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

            GanonFireball.Position2 = new Vector2(GanonFireball.Position2.X - change, GanonFireball.Position2.Y);
            traveledDistance += change;
            
            if (traveledDistance >= projDistance)
            {
                GanonFireball.Fire = false;
                CollisionManager.GameObjectList.Remove(GanonFireball);
            }
        }
        else
        {
            currentFrame = 0;
        }

    }
    public void Draw(SpriteBatch spriteBatch)
    {
        if (GanonFireball.Fire)
        {
            sprite.Draw(spriteBatch, (int)GanonFireball.Position2.X, (int)GanonFireball.Position2.Y, GanonFireball.GanonFireballLeft[spriteIndex]);
        }
    }
}
