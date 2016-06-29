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

        public void Load(ContentManager content)
        {

        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Begin();
            
            spritebatch.End();
        }

        public void Update(GameTime gameTime, MainGame game)
        {

        }
    }
}
