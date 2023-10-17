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
using System.Collections.Generic;

namespace Sprint2_Attempt3
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public int itemIndex;
        public int blockIndex;
        private IController kController;
        private IEnemy Enemy;
        private IItem Item;
        private ILink Character;
        private IBlock Block;
        private IDungeonRoom DungeonRoom;

        public struct GameObjectPair
        {
            public IGameObject Object { get; }
            public Rectangle Rect { get; }
            public GameObjectPair(IGameObject obj, Rectangle rectangle)
            {
                Object = obj;
                Rect = rectangle;
            }
        }
        private List<GameObjectPair> objects;

        public CollisionDetector collisionDetector
        { get; private set; }
        public CollisionResponse collisionResponse { get; private set; }
        public IController keyController
        {
            get { return kController; }
            set { kController = value; }
        }

        public IEnemy enemy
        {
            get { return Enemy; }
            set { Enemy = value; }
        }
        
        public IItem item { 
            get { return Item; } 
            set {Item = value; } 
        }
        public ILink link { 
            get { return Character; } 
            set {Character = value; } 
        }

        public IBlock block { 
            get { return Block; } 
            set {Block = value; } 
        }

        public IDungeonRoom dungeonRoom
        {
            get { return DungeonRoom; }
            set { DungeonRoom = value; }
        }

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
            EnemySpriteFactory.Instance.LoadAllTextures(this.Content);
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            ItemSpriteFactory.Instance.LoadAllTextures(Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Content);
            EnemyProjectileSpriteFactory.Instance.LoadAllTextures(Content);
            DungeonSpriteFactory.Instance.LoadAllTextures(Content);
            enemy = new Keese(200, 200);
            enemy.Spawn();
            dungeonRoom = new DungeonRoom1();
            link = new Link(this);
            item = new Item();
            block = new Block();
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
            
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}



