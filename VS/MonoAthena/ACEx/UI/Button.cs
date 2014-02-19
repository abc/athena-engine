#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace ACEx.UI
{
    public class Button
    {
        Rectangle ButtonRect;
        public Sprite ButtonSprite;

        public Button (int x = 10, int y = 10, int width = 80, int height = 30)
        {
            this.ButtonRect = new Rectangle(x, y, width, height);
            this.ButtonSprite = new Sprite("blank", new Vector2(width, height));
        }

        public void Draw (Dictionary<string, Texture2D> dictionary, SpriteBatch spriteBatch)
        {
            var ButtonSprite = new Sprite("blank", new Vector2(ButtonRect.Width, ButtonRect.Height));
            ButtonSprite.Position = new Vector2(ButtonRect.X, ButtonRect.Y);
            ButtonSprite.Color = new Color(198, 198, 198);

            var Border = new Sprite("blank", new Vector2(ButtonRect.Width - 1, ButtonRect.Height - 1));
            Border.Position = new Vector2(ButtonRect.X + 1, ButtonRect.Y + 1);
            Border.Color = Color.Black;

            var InsideBorder = new Sprite("blank", new Vector2(ButtonRect.Width - 2, ButtonRect.Height - 2));
            InsideBorder.Position = new Vector2(ButtonRect.X + 1, ButtonRect.Y + 1);
            InsideBorder.Color = Color.White;

            var InsideBorder2 = new Sprite("blank", new Vector2(ButtonRect.Width - 3, ButtonRect.Height - 3));
            InsideBorder2.Position = new Vector2(ButtonRect.X + 2, ButtonRect.Y + 2);
            InsideBorder2.Color = new Color(132, 132, 132);

            var InsideBorder3 = new Sprite("blank", new Vector2(ButtonRect.Width - 4, ButtonRect.Height - 4));
            InsideBorder3.Position = new Vector2(ButtonRect.X + 2, ButtonRect.Y + 2);
            InsideBorder3.Color = new Color(198, 198, 198);

            

            ButtonSprite.Draw(dictionary, spriteBatch);
            Border.Draw(dictionary, spriteBatch);
            InsideBorder.Draw(dictionary, spriteBatch);
            InsideBorder2.Draw(dictionary, spriteBatch);
            InsideBorder3.Draw(dictionary, spriteBatch);
        }
    }
}
