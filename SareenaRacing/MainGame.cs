namespace SareenaRacing
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using SareenaRacing.Menus;
    using System.Threading;
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class MainGame : Game
    {
        public const int GAME_WIDTH = 800;
        public const int GAME_HEIGHT = 600;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        //Texture2D backgroundTexture;
        private StartScreen startScreen;
        private EndScreen endScreen;


        public MainGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = GAME_WIDTH;
            graphics.PreferredBackBufferHeight = GAME_HEIGHT;
            graphics.ApplyChanges();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            //changing screen size
            //this.graphics.PreferredBackBufferWidth = 800;
            //this.graphics.PreferredBackBufferHeight = 600;
            //this.graphics.ApplyChanges();

            MenuManager.endGameMenuOn = true;
            startScreen = new StartScreen();
            endScreen = new EndScreen();

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
            startScreen.Load(Content);
            endScreen.Load(Content);
            //DrawRect.LoadContent(Content);


            //loading background image
            //this.backgroundTexture = this.Content.Load<Texture2D>(@"startBackground");

            //changing screen size
            //this.graphics.PreferredBackBufferWidth = this.backgroundTexture.Width;
            //this.graphics.PreferredBackBufferHeight = this.backgroundTexture.Height;
            //this.graphics.ApplyChanges();

            // TODO: use this.Content to load your game content here
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
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            //    Exit();

            // TODO: Add your update logic here

            if (MenuManager.gameStartOn)
            {
                startScreen.Update(gameTime, this);
            }
            else if (MenuManager.endGameMenuOn)
            {
                endScreen.Update(gameTime, this);
            }
            else
            {
                //if (mainPlayer.playerHP <= 0)
                //{
                //    endScreen.UpdateScoreboard(mainPlayer.playerScore);
                //    Thread.Sleep(100);
                //    MenuManager.endGameMenuOn = true;
                //    MenuManager.mainMenuOn = false;
                //    MenuManager.TurnOtherMenusOff();
                //}
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);

            if (MenuManager.gameStartOn)
            {
                startScreen.Draw(spriteBatch);
            }
            else if (MenuManager.endGameMenuOn)
            {
                endScreen.Draw(spriteBatch);
            }
            else
            {


                this.spriteBatch.Begin();

                //drawing background image
                //this.spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, backgroundTexture.Width, backgroundTexture.Height), Color.White);
                this.spriteBatch.End();

                // TODO: Add your drawing code here
            }
            base.Draw(gameTime);
        }
    }
}
