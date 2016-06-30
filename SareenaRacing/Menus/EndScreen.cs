namespace SareenaRacing.Menus
{
    using System.Threading;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class EndScreen : MainGame
    {
        private Texture2D background;
        private SpriteFont font;
        private Selector selector;

        private Button startGameButton = new Button("New Game", new Rectangle(400, 400, 100, 80));
        private Button quitGameButton = new Button("Quit Game", new Rectangle(550, 400, 100, 80));

        public void Load(ContentManager content)
        {
            background = content.Load<Texture2D>("startBackground");
            font = content.Load<SpriteFont>("forte-36");
            startGameButton.Load(content);
            quitGameButton.Load(content);

            selector = new Selector(420, 420);
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Begin();
            spritebatch.Draw(background, new Rectangle(0, 0, 800, 600), Color.White);
            spritebatch.DrawString(font, "Game Over", new Vector2(400, 25), Color.SlateGray);

            startGameButton.DrawButton(spritebatch, font);
            quitGameButton.DrawButton(spritebatch, font);

            spritebatch.End();
        }

        public void Update(GameTime gameTime, MainGame game)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                selector.x -= 25;
                if (selector.x < 430)
                {
                    selector.x = 430;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                selector.x += 25;
                if (selector.x > 630)
                    selector.x = 630;
            }

            //create rectangle to chekc if the selector is inside the buttons
            Rectangle rect = new Rectangle(selector.x, selector.y, 20, 20);

            if (rect.Intersects(startGameButton.location))
            {
                startGameButton.isSelected = true;
            }
            else
            {
                startGameButton.isSelected = false;
            }

            if (rect.Intersects(quitGameButton.location))
            {
                quitGameButton.isSelected = true;
            }
            else
            {
                quitGameButton.isSelected = false;
            }

            //if the button is selected execute function

            if (startGameButton.isSelected)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Enter))
                {
                    MenuManager.gameStartOn = true;
                    MenuManager.mainMenuOn = false;
                    MenuManager.TurnOtherMenusOff();

                    Thread.Sleep(100);
                }
            }
            else if (quitGameButton.isSelected)
            {
                //quit button exits the game
                if (Keyboard.GetState().IsKeyDown(Keys.Enter))
                {
                    game.Exit();
                }
            }
        }

    }
}
