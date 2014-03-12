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
    /// A character class holds important detail about each character such as their items, level, experience, skills, etc.
    /// </summary>
    public class Character : DrawableEntity, IFocusable
    {
        private int Level;
        private int Experience;

        public Vector2 Position { get; set; }

        /// <summary>
        /// Constructor for the Character class
        /// </summary>
        /// <param name="position">The coordinates of the character</param>
        /// <param name="size">The size of the character</param>
        /// <param name="spriteBatch">Which spritebatch will draw the character</param>
        /// <param name="texture">What is the texture for the character</param>
        public Character(Vector2 position, Vector2 size, SpriteBatch spriteBatch, Texture2D texture) : base(position, size, spriteBatch, texture)
        {
            this.Position = position;
        }
        /*
         * TODO: fix this

        public Move(string direction)
        {

        }

        private CheckMove ()
        {

        }
         */
    }
}
