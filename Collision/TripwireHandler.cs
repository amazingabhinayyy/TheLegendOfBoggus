using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Player.LinkStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Collision
{
    internal class TripwireHandler
    {
        public TripwireHandler() { }
        public static void HandleTripwire(IEnemy enemy, ILink link)
        {
            Rectangle leftVerticalTripwire = new Rectangle(124, 0, 1, 500);
            Rectangle rightVerticalTripwire = new Rectangle(674, 0, 1, 500);
            Rectangle downHorizontalTripwire = new Rectangle(0, 599, 800, 1);
            Rectangle upHorizontalTripWire = new Rectangle(0, 299, 800, 1);
            Rectangle linkintersect = link.GetHitBox();
            if (enemy is SpikeTrap)
            {
                if (linkintersect.Intersects(leftVerticalTripwire))
                {
                    if(enemy.X < 400 && enemy.Y < 375)
                    {
                        ((SpikeTrap)enemy).MoveDown();
                    }
                    else if(enemy.X < 400 && enemy.Y >= 375)
                    {
                        ((SpikeTrap)enemy).MoveUp();
                    }
                }
                else if (linkintersect.Intersects(rightVerticalTripwire))
                {
                    if (enemy.X >= 400 && enemy.Y < 375)
                    {
                        ((SpikeTrap)enemy).MoveDown();
                    }
                    else if (enemy.X >= 400 && enemy.Y >= 375)
                    {
                        ((SpikeTrap)enemy).MoveUp();
                    }
                }
                else if (linkintersect.Intersects(upHorizontalTripWire))
                {
                    if (enemy.Y < 375 && enemy.X < 400)
                    {
                        ((SpikeTrap)enemy).MoveRight();
                    }
                    else if (enemy.Y < 375 && enemy.X >= 400)
                    {
                        ((SpikeTrap)enemy).MoveLeft();
                    }
                }
                else if (linkintersect.Intersects(downHorizontalTripwire))
                {
                    if (enemy.Y >= 375 && enemy.X < 400)
                    {
                        ((SpikeTrap)enemy).MoveRight();
                    }
                    else if (enemy.Y >= 375 && enemy.X >= 400)
                    {
                        ((SpikeTrap)enemy).MoveLeft();
                    }
                }
            }
            else if(enemy is Hand)
            {

            }

        }
    }
}
