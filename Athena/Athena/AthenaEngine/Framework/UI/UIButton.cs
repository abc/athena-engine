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

using AthenaEngine.Framework;
using AthenaEngine.Framework.Gameplay;
using AthenaEngine.Framework.Interfaces;
using AthenaEngine.Framework.Primatives;
using AthenaEngine.Framework.Systems;

namespace AthenaEngine.Framework.UI
{
	/// <summary>
	/// User interface button.
	/// </summary>
    public class UIButton
    {
        private SpriteBatch Batch;
        private Texture2D Texture;
        private SpriteFont Font;
        private Color Color;
        private string Label;
        public Level Level;

        private Rectangle SpriteRect;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="AthenaEngine.Framework.UI.UIButton"/> class.
		/// </summary>
		/// <param name='rectangle'>
		/// Rectangle.
		/// </param>
		/// <param name='spriteBatch'>
		/// Sprite batch.
		/// </param>
		/// <param name='texture'>
		/// Texture.
		/// </param>
		/// <param name='color'>
		/// Color.
		/// </param>
		/// <param name='label'>
		/// Label.
		/// </param>
		/// <param name='font'>
		/// Font.
		/// </param>
        public UIButton (Rectangle rectangle, SpriteBatch spriteBatch, Texture2D texture, Color color, string label, SpriteFont font)
        {
            this.SpriteRect = rectangle;
            this.Batch = spriteBatch;
            this.Texture = texture;
            this.Color = color;
            this.Label = label;
            this.Font = font;
        }
		
		/// <summary>
		/// Draw this instance.
		/// </summary>
        public void Draw ()
        {
            // DrawableEntity Base = new DrawableEntity(new Vector2(SpriteRect.X, SpriteRect.Y), new Vector2(SpriteRect.Width, SpriteRect.Height), Batch, Texture, Level);
            // DrawableEntity Stroke = new DrawableEntity(new Vector2(SpriteRect.X - 2, SpriteRect.Y - 2), new Vector2(SpriteRect.Width + 4, SpriteRect.Height + 4), Batch, Texture, Level);
            // Stroke.SpriteColor = Color.Black;
            // Base.SpriteColor = this.Color;
            // Stroke.Draw();
            // Base.Draw();
            // int x = (int)SpriteRect.X + Font.MeasureString(Label).X / 2

            int X = SpriteRect.X + (SpriteRect.Width - (int) Font.MeasureString(Label).X) / 2;
            int Y = SpriteRect.Y;
            Batch.DrawString(Font, Label, new Vector2(X, Y), Color.Black);
        }
    }
}
