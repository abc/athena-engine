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
    public class Button
    {
        public Vector2 Position;
        public SpriteFont Font;
        public Texture2D Texture;
        public string Label;
        public Rectangle ButtonRect;
        private Rectangle ShadowRect;
        private Rectangle ShadowRect2;
        public bool clickState = false;
        public static bool alreadyClicked;

        public Button (int x, int y, int width, int height, SpriteFont font, Texture2D texture, string label)
        {
            this.Position = new Vector2(x, y);
            this.Font = font;
            this.Texture = texture;
            this.Label = label;

            ButtonRect = new Rectangle(x, y, width, height);
            ShadowRect = new Rectangle(x, y, width - 1, height - 1);
            ShadowRect2 = new Rectangle(x + 1, y + 1, width - 2, height - 2);
        }

        public Color Color = Color.White;

        public void Draw (SpriteBatch spriteBatch)
        {
            switch (clickState)
            {
                case true:
                    Vector2 labelSize = Font.MeasureString(Label);
                    spriteBatch.Draw(this.Texture, ButtonRect, Color.Black);
                    spriteBatch.Draw(this.Texture, ShadowRect, Color.White);
                    spriteBatch.Draw(this.Texture, ShadowRect2, Color.LightGray);

                    float positionX = (Position.X + (ButtonRect.Width / 2) - (labelSize.X / 2));
                    float positionY = (Position.Y + (ButtonRect.Height / 2) - (labelSize.Y / 2));

                    Vector2 LabelPosition = new Vector2((int)positionX, (int)positionY);
                    spriteBatch.DrawString(this.Font, Label, LabelPosition, Color.Black);
                    break;
                case false:
                    Vector2 labelSize = Font.MeasureString(Label);
                    spriteBatch.Draw(this.Texture, ButtonRect, Color.Black);
                    spriteBatch.Draw(this.Texture, ShadowRect, Color.White);
                    spriteBatch.Draw(this.Texture, ShadowRect2, Color.LightGray);

                    float positionX = (Position.X + (ButtonRect.Width / 2) - (labelSize.X / 2));
                    float positionY = (Position.Y + (ButtonRect.Height / 2) - (labelSize.Y / 2));

                    Vector2 LabelPosition = new Vector2((int)positionX, (int)positionY);
                    spriteBatch.DrawString(this.Font, Label, LabelPosition, Color.Black);
                    break;
            }
            
        }

        public Rectangle GetBounds ()
        {
            return ButtonRect;
        }

        
        public void IsClicked ()
        {
            if (alreadyClicked)
            {
                
            }
            else
            {
                System.Console.WriteLine("I got clicked!.");
                alreadyClicked = true;
            }
        }

        public void UnClick ()
        {
            alreadyClicked = false;
        }

    }
}
