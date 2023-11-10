using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Collision.SideCollisionHandlers;

namespace Sprint2_Attempt3.Blocks.Block
{
    public class MovingBlock : BlockSecondary
    {
        public bool Moved { get; private set; }
        private bool beginMovement;
        private ICollision pushedSide;
        private int timer;
        private bool movementComplete;
        public MovingBlock(Rectangle position)
        {
            this.position = position;
            sourceRectangle = new Rectangle(17, 0, 16, 16);
            isWalkable = false;
            Moved = false;
            beginMovement = false;
            movementComplete = false;
            //Amount of buffer time for the block to actually move
            timer = -585;
        }
        public override void Update()
        {
            if (!movementComplete && timer > 0)
            {
                if(pushedSide is LeftCollision)
                {
                    position = new Rectangle(position.X + 3, position.Y, position.Width, position.Height);
                }
                else if (pushedSide is RightCollision)
                {
                    position = new Rectangle(position.X - 3, position.Y, position.Width, position.Height);
                }
                else if (pushedSide is TopCollision)
                {
                    position = new Rectangle(position.X, position.Y + 3, position.Width, position.Height);
                }
                else if (pushedSide is BottomCollision)
                {
                    position = new Rectangle(position.X, position.Y - 3, position.Width, position.Height);
                }
                if(timer == 1)
                {
                    movementComplete = true;
                }
                timer--;
            }
        }
        public void MoveBlock(ICollision side)
        {
            if (!Moved)
            {
                if (timer <= 0)
                {
                    timer += 15;
                }
                else
                {
                    Moved = true;
                    pushedSide = side;
                }
            }
        }
    }
}
