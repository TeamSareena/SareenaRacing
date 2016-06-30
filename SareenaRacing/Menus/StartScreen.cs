namespace SareenaRacing.Menus
{
    using System.Threading;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class StartScreen : MainGame
    {
        private Texture2D background;
        private SpriteFont font;
        //private Selector selector;

        //private Button startGameButton = new Button("New Game", new Rectangle(400, 400, 100, 80));
        //private Button quitGameButton = new Button("Quit Game", new Rectangle(550, 400, 100, 80));

        public void Load(ContentManager content)
        {
            background = content.Load<Texture2D>("startBackground");
            font = content.Load<SpriteFont>("FORTE");
            //startGameButton.Load(content);
            //quitGameButton.Load(content);

            //selector = new Selector(420, 420);
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Begin();
            spritebatch.Draw(background, new Rectangle(0, 0, 800, 600), Color.White);
            spritebatch.DrawString(font, "Sareena Racing", new Vector2(400, 25), Color.SlateGray);

            //startGameButton.DrawButton(spritebatch, font);
            //quitGameButton.DrawButton(spritebatch, font);

            spritebatch.End();
        }

        public void Update(GameTime gameTime, MainGame game)
        {
            //if (Keyboard.GetState().IsKeyDown(Keys.Left))
            //{
            //    selector.x -= 25;
            //    if (selector.x < 430)
            //    {
            //        selector.x = 430;
            //    }
            //}
            //if (Keyboard.GetState().IsKeyDown(Keys.Right))
            //{
            //    selector.x += 25;
            //    if (selector.x > 630)
            //        selector.x = 630;
            //}
        }
    }
}
