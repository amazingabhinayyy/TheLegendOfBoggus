using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint2;
using Sprint2_Attempt3.Enemy;
using Sprint2_Attempt3.Enemy.Keese;
using Sprint2_Attempt3.Enemy.Rope;
using Sprint2_Attempt3.Projectile;
using Sprint2_Attempt3.ItemClasses;
using System;
using System.Diagnostics;

namespace Sprint2_Attempt3
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private IController keyboardController;
        public IController KeyController
        {
            get { return keyboardController; }
            set { keyboardController = value; }
        }

        private IEnemy currentEnemy;
        public int currentItemInd;
        public IEnemy enemy
        {
            get { return currentEnemy; }
            set { currentEnemy = value; }
        }
        private ILink link;
        private IItem item;
        private Link link;
        public IItem Item { get { return item; } set {item = value; } }
        public int itemIndex;
        public IItem Item { get { return item; } set {; } }
=========
        private ILink link;
>>>>>>>>> Temporary merge branch 2
        public ILink Link { 
            get { return link; } 
            set {link = value; } 
        }

        private IBlock block;
        public IBlock Block { get { return block; } set {block = value; } }

        public int blockIndex;


            blockIndex = 0;
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            currentItemInd = 0;
            itemIndex = 0;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            keyboardController = new KeyboardController(this);
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
            keyboardController = new KeyboardController(this);
            EnemySpriteFactory.Instance.LoadAllTextures(this.Content);
            currentEnemy = new Keese(200, 200);
            currentEnemy.Spawn();
            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            link = new Link();
            ItemSpriteFactory.Instance.LoadAllTextures(Content);
            item = new Item();
            BlockSpriteFactory.Instance.LoadAllTextures(Content);
            block = new Block();
            EnemyProjectileSpriteFactory.Instance.LoadAllTextures(Content);
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
            block.Update();
            keyboardController.Update(gameTime);
            currentEnemy.Update();
            link.Update();
            item.Update();
            //Debug.WriteLine(itemIndex);
            base.Update(gameTime);
        }



        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            currentEnemy.Draw(spriteBatch);
            link.Draw(spriteBatch, Color.White);
            item.Draw(spriteBatch);
            block.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}