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

using AthenaEngine.Framework.Gameplay;

namespace AthenaEngine.Framework.Primatives
{
    /// <summary>
    /// This is an entity which can be drawn.
    /// </summary>
    public class DrawableEntity : CollidableEntity, Interfaces.IDrawable, Interfaces.IFocusable
    {
        public Color SpriteColor;

        protected SpriteBatch SpriteController;
        protected Texture2D SpriteSheet;
        protected Rectangle SpriteSource;
        public Level level;

        /// <summary>
        /// This is the constructor for the DrawableEntity class.
        /// </summary>
        /// <param name="position">Where the DrawableEntity will start</param>
        /// <param name="size">The size in pixels of the DrawableEntity</param>
        /// <param name="spriteBatch">The SpriteBatch responsible for drawing the entity</param>
        /// <param name="texture">The texture used to draw the entity</param>
        public DrawableEntity(Vector2 position, Vector2 size, Rectangle SpriteSource, SpriteBatch spriteBatch, Texture2D tileset, Level level) : base(position, size, level)
        {
            this.SpriteSource = SpriteSource;
            this.SpriteColor = Color.White;
            this.SpriteSheet = tileset;
            this.Position = position;
            this.Size = size;
            this.SpriteController = spriteBatch;
        }

        /// <summary>
        /// This draws the DrawableEntity.
        /// </summary>
        public void Draw()
        {
            this.SpriteController.Draw(this.SpriteSheet, this.Rectangle, this.SpriteSource, this.SpriteColor);
        }
        public Vector2 Position
        {
            get
            {
                return base.Position;
            }
            set
            {
                base.Position = value;
            }
        }
        
    }
}
