using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2_Attempt3.Enemy
{
    public interface IEnemy
    {
        public int X { 
            get { return X; } 
            set { X = value; }
        }
        public int Y
        {
            get { return Y; }
            set { Y = value; }
        }

        public void Generate();
        public void Spawn();
        public void ChangeDirection();
        public void ChangeAttackedStatus();
        public void Kill();
        public void Update();
        public void Draw(SpriteBatch spriteBatch);
    }
}
