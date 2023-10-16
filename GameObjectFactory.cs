using Microsoft.Xna.Framework;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Aquamentus;
using Sprint2_Attempt3.Enemy.Dodongo;
using Sprint2_Attempt3.Enemy.Gel;
using Sprint2_Attempt3.Enemy.Goriya;
using Sprint2_Attempt3.Enemy.Hand;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Enemy.SpikeTrap;
using Sprint2_Attempt3.Enemy.Stalfos;
using Sprint2_Attempt3.Enemy.Zol;
using Sprint2_Attempt3.Items;

namespace Sprint2_Attempt3
{
    internal class GameObjectFactory
    {
        private static GameObjectFactory instance = new GameObjectFactory();

        public static GameObjectFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public GameObjectFactory() { }
        /*
        public IEnemy CreateNewKeese(Vector2 position) {
            return new Keese(position);
        }
        public IEnemy CreateNewAquamentus(Vector2 position)
        {
            return new Aquamentus(position);
        }
        public IEnemy CreateNewDodongo(Vector2 position)
        {
            return new Dodongo(position);
        }
        public IEnemy CreateNewGel(Vector2 position)
        {
            return new Gel(position);
        }
        public IEnemy CreateNewGoriya(Vector2 position)
        {
            return new Goriya(position);
        }
        public IEnemy CreateNewHand(Vector2 position)
        {
            return new Hand(position);
        }
        public IEnemy CreateNewRope(Vector2 position)
        {
            return new Rope(position);
        }
        public IEnemy CreateNewSpikeTrap(Vector2 position)
        {
            return new SpikeTrap(position);
        }
        public IEnemy CreateNewStalfos(Vector2 position)
        {
            return new Stalfos(position);
        }
        public IEnemy CreateNewZol(Vector2 position)
        {
            return new Zol(position);
        }
        */
        public IBlock CreateNewBlock() { return new Block(); }
        public IItem CreateNewItem() { return new Item(); }
    }
}
