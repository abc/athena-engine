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

namespace AthenaEngine.Components
{
    /// <summary>
    /// This is an entity which can be drawn.
    /// </summary>
    public class DrawableEntity : CollidableEntity, Interfaces.IDrawable
    {
        private Color SpriteColor;
        private Rectangle SpriteRectangle;
        private SpriteBatch SpriteController;
        private Texture2D SpriteTexture;

        /// <summary>
        /// This is the constructor for the DrawableEntity class.
        /// </summary>
        /// <param name="position">Where the DrawableEntity will start</param>
        /// <param name="size">The size in pixels of the DrawableEntity</param>
        /// <param name="spriteBatch">The SpriteBatch responsible for drawing the entity</param>
        /// <param name="texture">The texture used to draw the entity</param>
        public DrawableEntity(Vector2 position, Vector2 size, SpriteBatch spriteBatch, Texture2D texture) : base(position, size)
        {
            this.SpriteColor = Color.White;
            this.SpriteTexture = texture;
            this.SpriteRectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            this.SpriteController = spriteBatch;
        }

        /// <summary>
        /// This draws the DrawableEntity.
        /// </summary>
        public void Draw()
        {
            this.SpriteController.Draw(this.SpriteTexture, this.SpriteRectangle, this.SpriteColor);
        }
    }
}
