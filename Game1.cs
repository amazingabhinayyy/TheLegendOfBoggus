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
using Sprint2_Attempt3.Collision;
using Sprint2_Attempt3.Inventory;
using Sprint2_Attempt3.Sounds;
using Sprint2_Attempt3.Screens;

namespace Sprint2_Attempt3
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        public static Texture2D InventoryTexture { get; set; }
        private KeyboardController keyController { get; set; }
        private MouseController mouseController { get; set; }
        private InventoryController inventoryController { get; set; }
        public ILink link { get; set; }
        public IRoom room { get; set; }
        public bool gameStarted { get; set; }
        public bool linkDead { get; set; }
        public bool gamePaused { get; set; }
        public bool deathAnimationActive { get; set; }

        private GameTime gameTime;
        public GameTime Gametime { get { return gameTime; } }

        public CollisionManager collisionManager;
        private StartScreenState startScreen;
        private DeathScreenState deathScreen;
        private PauseScreenState pauseScreen;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            graphics.PreferredBackBufferHeight = Globals.ScreenHeight;
            graphics.ApplyChanges();
            RoomGenerator.Instance.LoadAllFiles();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Globals.MakeFloorGrid();
            EnemySpriteFactory.Instance.LoadAllTextures(this.Content);
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            ItemSpriteFactory.Instance.LoadAllTextures(Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Content);
            EnemyProjectileSpriteFactory.Instance.LoadAllTextures(Content);
            SoundFactory.Instance.LoadAllTextures(Content);
            DungeonSpriteFactory.Instance.LoadAllTextures(Content);
            ScreenSpriteFactory.Instance.LoadAllTextures(Content);
            //check if we need start screen
            //StartScreenSpriteFactory.Instance.LoadAllTextures(Content);
            TransitionHandler.Instance.setGame1(this);
            //update into states later
            Room16TransitionHandler.Instance.setGame1(this);
            RoomGenerator.Instance.LoadAllFiles();
            InventoryTexture = Content.Load<Texture2D>("Inventory");
            link = new Link(this);
            collisionManager = new CollisionManager(this, (Link)link);
            gameStarted = false;
            linkDead = false;
            inventoryController = new InventoryController(this);
            keyController = new KeyboardController(this);
            mouseController = new MouseController(this);
            room = new Room17(this);
            startScreen = new StartScreenState(this);
            deathScreen = new DeathScreenState(this);
            pauseScreen = new PauseScreenState(this);
            deathAnimationActive = false;
        }

        protected override void UnloadContent()
        {
        }
        public void Reset()
        {
            link = new Link(this);
            linkDead = false;
            deathAnimationActive = false;
            gamePaused = false;
            collisionManager = new CollisionManager(this, (Link)link);
            room = new Room1(this);
        }

        protected override void Update(GameTime gameTime)
        {
            keyController.Update(gameTime);
            if (!gamePaused && !linkDead && gameStarted)
            {
                room.Update();
                if (!deathAnimationActive)
                {
                    inventoryController.Update();
                    collisionManager.Update();
                    //mouseController.Update(gameTime);
                }
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            this.gameTime = gameTime;
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            if (linkDead)
            {
                deathScreen.Draw(spriteBatch);
            }
            else if (gamePaused)
            {
                pauseScreen.Draw(spriteBatch);
            }
            else if (gameStarted)
            {
                room.Draw(spriteBatch, Color.White);
                inventoryController.Draw(spriteBatch);
            }
            else
            {
                startScreen.Draw(spriteBatch);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}