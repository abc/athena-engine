using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ACEx.UI
{
    public class Cursor
    {

        public MouseState state;
        public bool clickState = false;

        public void Draw (Texture2D texture, SpriteBatch spriteBatch)
        {
            state = Mouse.GetState();
            spriteBatch.Draw(texture, new Rectangle(state.X, state.Y, texture.Width, texture.Height), Color.White);
        }

        public bool Clicks (Button button)
        {
            state = Mouse.GetState();

            Rectangle bounds = button.GetBounds();

            if ((state.X) >= bounds.Left && (state.X <= bounds.Right) && (state.Y <= bounds.Bottom) && (state.Y >= bounds.Top) && (state.LeftButton == ButtonState.Pressed))
            {
                return true;
            }
            else
            {
                button.UnClick();
                return false;
            }
        }
    }
}
