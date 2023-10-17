using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint2_Attempt3.Dungeon.Rooms.DungeonRooms;
using Sprint2_Attempt3.Dungeon.Rooms;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Player;
using Sprint2_Attempt3.Items;
using Sprint2_Attempt3.Blocks;
using Sprint2_Attempt3.Enemy.Projectile;
using Sprint2_Attempt3.Player.Interfaces;
using Sprint2_Attempt3.Collision;

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
        public IEnemy enemy { get; set; }
        public IDungeonRoom dungeonRoom { get; set; }
        public IRoom room { get; set; }
        private IBlock[] blocks = { 
            new BlackBlock(Globals.NorthEastCollisionBlock),
            new BlackBlock(Globals.NorthWestCollisionBlock),
            new BlackBlock(Globals.SouthEastCollisionBlock),
            new BlackBlock(Globals.SouthWestCollisionBlock),
            new BlackBlock(Globals.EastNorthCollisionBlock),
            new BlackBlock(Globals.EastSouthCollisionBlock),
            new BlackBlock(Globals.WestNorthCollisionBlock),
            new BlackBlock(Globals.WestSouthCollisionBlock)
        };
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

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            keyController = new KeyboardController(this);
            collisionHandler = new CollisionHandler();
            EnemySpriteFactory.Instance.LoadAllTextures(this.Content);
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            ItemSpriteFactory.Instance.LoadAllTextures(Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Content);
            EnemyProjectileSpriteFactory.Instance.LoadAllTextures(Content);
            DungeonSpriteFactory.Instance.LoadAllTextures(Content);
            RoomGenerator.Instance.LoadAllFiles(Content);
            keyController = new KeyboardController(this);
            dungeonRoom = new DungeonRoom1();
            enemy = new Keese(200, 200);
            enemy.Spawn();
            link = new Link();
            collisionDetector = new CollisionDetector(this);
            collisionResponse = new CollisionResponse(this); 
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            // TODO: Add your update logic here
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            collisionDetector.Update();
            keyController.Update(gameTime);
            room.Update();
            enemy.Update();
            base.Update(gameTime);
        }



        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
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



