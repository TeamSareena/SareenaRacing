namespace SareenaRacing
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Button : MainGame
    {
        private Texture2D button;
        private Texture2D buttonHovered;
        private string buttonText;
        public Rectangle location;
        public bool isSelected;

        public Button(string text, Rectangle location)
        {
            buttonText = text;
            this.location = location;
        }

        public Button(string text, Rectangle location, bool selected)
        {
            buttonText = text;
            this.location = location;
            isSelected = selected;
        }

        public void Load(ContentManager content)
        {
            buttonHovered = content.Load<Texture2D>("buttonhovered");
            button = content.Load<Texture2D>("button");
        }

        public void DrawButton(SpriteBatch spriteBatch, SpriteFont font)
        {
            int textX = location.X + location.Width / 6;
            int textY = location.Y + (location.Height * 25) / 80;
            if (isSelected)
            {
                spriteBatch.Draw(buttonHovered, location, Color.White);
                spriteBatch.DrawString(font, buttonText, new Vector2(textX, textY),
                    Color.Ivory);
            }
            else
            {
                spriteBatch.Draw(button, location, Color.White);
                spriteBatch.DrawString(font, buttonText, new Vector2(textX, textY),
                    Color.Ivory);
            }
        }
    }
}
