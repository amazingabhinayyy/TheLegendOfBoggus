using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Blocks.BlockSprites;
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Inventory;

namespace Sprint2_Attempt3
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D InventoryTexture;
        private KeyboardController keyController { get; set; }
        private MouseController mouseController { get; set; }
        private InventoryController inventoryController { get; set; }
        public ILink link { get; set; }
        public IRoom room { get; set; }

        public CollisionDetector collisionDetector;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            graphics.PreferredBackBufferHeight = 725;
            graphics.ApplyChanges();
            RoomGenerator.Instance.LoadAllFiles();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            EnemySpriteFactory.Instance.LoadAllTextures(this.Content);
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            ItemSpriteFactory.Instance.LoadAllTextures(Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Content);
            EnemyProjectileSpriteFactory.Instance.LoadAllTextures(Content);
            DungeonSpriteFactory.Instance.LoadAllTextures(Content);
            RoomGenerator.Instance.LoadAllFiles();
            InventoryTexture = Content.Load<Texture2D>("Inventory");
            link = new Link(this);
            collisionDetector = new CollisionDetector(this, (Link)link);
            keyController = new KeyboardController(this);
            mouseController = new MouseController(this);
            inventoryController = new InventoryController(InventoryTexture);
            room = new Room1(this);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            keyController.Update(gameTime);
            mouseController.Update(gameTime);
            collisionDetector.Update();
            room.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            //room.Draw(spriteBatch);
            inventoryController.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}



