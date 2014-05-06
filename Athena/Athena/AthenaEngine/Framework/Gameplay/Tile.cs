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
using System.Reflection;

using AthenaEngine.Framework.Primatives;
using AthenaEngine.Framework.Interfaces;
using AthenaEngine.Framework.Systems;

namespace AthenaEngine.Framework.Gameplay
{
    /// <summary>
    /// A tile is used to draw levels.
    /// </summary>
    public class Tile : CollidableEntity
    {
        private bool Drawable;
        public bool Collides = false;
        private Texture2D Texture;
        public DrawableEntity Sprite;
        private string TileSet;
        private Rectangle SourceRectangle;
        private MethodInfo Trigger;
        public bool HasTrigger = false;

        /// <summary>
        /// Class constructor for a new Tile object.
        /// </summary>
        /// <param name="x">The X coordinate of the new tile.</param>
        /// <param name="y">The Y coordinate of the new tile.</param>
        public Tile(int x, int y, string TileSet, int xOffset, int yOffset, Level level) : base(new Vector2(x, y), new Vector2(25, 25), level)
        {
            this.TileSet = TileSet;
            this.SourceRectangle = new Rectangle(xOffset, yOffset, 25, 25);
        }

        /// <summary>
        /// Make a tile drawable by giving it a texture and a spriteBatch.
        /// </summary>
        /// <param name="spriteBatch">The SpriteBatch to draw the tile with.</param>
        /// <param name="texture">The texture to draw the tile with.</param>
        public void MakeDrawable(SpriteBatch spriteBatch, ResourceManager<Texture2D> resoureManager)
        {
            this.Drawable = true;

            this.Texture = resoureManager.Get(TileSet);

            this.Sprite = new DrawableEntity(Position, Size, SourceRectangle, spriteBatch, this.Texture, this.Level);
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

        public void FireTrigger (object[] args)
        {
            if (this.HasTrigger)
            {
                Trigger.Invoke(null, args);
            }
            
        }

        public void AddTrigger(string triggerName)
        {
            Type type = typeof(Triggers);
            MethodInfo method = type.GetMethod(triggerName);
            this.Trigger = method;
            this.HasTrigger = true;
        }
    }
}
