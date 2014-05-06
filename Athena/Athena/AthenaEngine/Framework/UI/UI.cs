using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
	/// UI
	/// </summary>
    public class UI
    {
        SpriteBatch SpriteBatch;
        ResourceManager<Texture2D> TextureManager;
        ResourceManager<SpriteFont> FontManager;
        public Level Level;
        /*
        public UIButton(Vector2 position, Vector2 size, SpriteBatch spriteBatch, Texture2D texture) : base(position, size, spriteBatch, texture)
        {
            this.SpriteColor = Color.White;
            this.SpriteTexture = texture;
            this.SpriteRectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            this.SpriteController = spriteBatch;
        }
         */
		
		/// <summary>
		/// Initializes a new instance of the <see cref="AthenaEngine.Framework.UI.UI"/> class.
		/// </summary>
		/// <param name='spriteBatch'>
		/// Sprite batch.
		/// </param>
		/// <param name='textureManager'>
		/// Texture manager.
		/// </param>
		/// <param name='fontManager'>
		/// Font manager.
		/// </param>
        public UI (SpriteBatch spriteBatch, ResourceManager<Texture2D> textureManager, ResourceManager<SpriteFont> fontManager)
        {
            this.SpriteBatch = spriteBatch;
            this.TextureManager = textureManager;
            this.FontManager = fontManager;
        }
		
		/// <summary>
		/// The buttons.
		/// </summary>
        private List<UIButton> Buttons = new List<UIButton>();
		
		/// <summary>
		/// Adds the button.
		/// </summary>
		/// <param name='position'>
		/// Position.
		/// </param>
		/// <param name='label'>
		/// Label.
		/// </param>
        public void AddButton(Vector2 position, string label)
        {
            // Buttons.Add(new UIButton(position, new Vector2(100, 40), SpriteBatch, TextureManager.Get("blank")));
            Buttons.Add(new UIButton(new Rectangle((int)position.X, (int)position.Y, 100, 40), this.SpriteBatch, TextureManager.Get("blank"), Color.Orange, label, FontManager.Get("SpriteFont1")));
        }
		
		/// <summary>
		/// Draw this instance.
		/// </summary>
        public void Draw ()
        { 
            foreach (UIButton btn in Buttons)
            {
                btn.Draw();
            }
        }
    }
}
