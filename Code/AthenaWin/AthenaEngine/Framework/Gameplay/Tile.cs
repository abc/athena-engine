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

using AthenaEngine.Framework.Primatives;
using AthenaEngine.Framework.Interfaces;

namespace AthenaEngine.Framework.Gameplay
{
    /// <summary>
    /// A tile is used to draw levels.
    /// </summary>
    public class Tile : IFocusable
    {
        private int X;
        private int Y;
        private bool Drawable;

        public Vector2 Position { get; set; }

        private DrawableEntity Sprite;

        /// <summary>
        /// Class constructor for a new Tile object.
        /// </summary>
        /// <param name="x">The X coordinate of the new tile.</param>
        /// <param name="y">The Y coordinate of the new tile.</param>
        public Tile (int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Position = new Vector2(this.X, this.Y);
        }

        /// <summary>
        /// Make a tile drawable by giving it a texture and a spriteBatch.
        /// </summary>
        /// <param name="spriteBatch">The SpriteBatch to draw the tile with.</param>
        /// <param name="texture">The texture to draw the tile with.</param>
        public void MakeDrawable(SpriteBatch spriteBatch, Texture2D texture)
        {
            Vector2 Position = new Vector2(this.X * 25, this.Y * 25);
            Vector2 Size = new Vector2(25, 25);

            this.Drawable = true;

            this.Sprite = new DrawableEntity(Position, Size, spriteBatch, texture);
        }

        /// <summary>
        /// Draw the tile.
        /// </summary>
        public void Draw()
        {
            if (this.Drawable)
            {
                this.Sprite.Draw();
            }
            
        }
    }
}
