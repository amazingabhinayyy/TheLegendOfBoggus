using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Items.ItemClasses;
using Sprint2_Attempt3.Dungeon;

namespace Sprint2_Attempt3
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public IItem item;
       
        private KeyboardController keyController { get; set; }
        private CollisionHandler collisionHandler { get; set; }
        public ILink link { get; set; }
        public IRoom room { get; set; }
        public IEnemy enemy { get; set; }

        public CollisionDetector collisionDetector
        { get; private set; }
        public CollisionResponse collisionResponse { get; private set; }

        private BlockCollisionClass blockCollision;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            RoomGenerator.Instance.LoadAllFiles();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            collisionHandler = new CollisionHandler();
            EnemySpriteFactory.Instance.LoadAllTextures(this.Content);
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            ItemSpriteFactory.Instance.LoadAllTextures(Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Content);
            EnemyProjectileSpriteFactory.Instance.LoadAllTextures(Content);
            DungeonSpriteFactory.Instance.LoadAllTextures(Content);
            RoomGenerator.Instance.LoadAllFiles();
            keyController = new KeyboardController(this);
            room = new Room1(this);
            link = new Link(this);
            enemy = new EnemySecondary();
            enemy.Spawn();
            collisionDetector = new CollisionDetector(this);
            collisionResponse = new CollisionResponse(this); 
            blockCollision = new BlockCollisionClass(this);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            collisionDetector.Update();
            blockCollision.Update();
            keyController.Update(gameTime);
            room.Update();
            item.Update();
            enemy.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            room.Draw(spriteBatch);
            enemy.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}



