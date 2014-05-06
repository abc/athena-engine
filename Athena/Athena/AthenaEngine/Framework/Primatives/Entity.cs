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

using AthenaEngine.Framework.Primatives;


namespace AthenaEngine.Framework.Primatives
{
    /// <summary>
    /// The Entity class is the superclass for anything.
    /// </summary>
    public abstract class Entity
    {
        protected Vector2 Position;
        protected Vector2 Size;
		
		/// <summary>
		/// Gets or sets the rectangle.
		/// </summary>
		/// <value>
		/// The rectangle.
		/// </value>
        protected Rectangle Rectangle
        {
            get
            {
                return new Rectangle(X, Y, Width, Height);
            }
            set
            {
                this.Position = new Vector2(value.X, value.Y);
                this.Size = new Vector2(value.Width, value.Height);
            }
        }

        public int X
        {
            get
            {
                return (int) Position.X;
            }
            set
            {
                Position.X = value;
            }
        }
        public int Y
        {
            get
            {
                return (int)Position.Y;
            }
            set
            {
                Position.Y = value;
            }
        }
        public int Width
        {
            get
            {
                return (int)Size.X;
            }
            set
            {
                Size.X = value;
            }
        }
        public int Height
        {
            get
            {
                return (int)Size.Y;
            }
            set
            {
                Size.Y = value;
            }
        }
		
        protected void Move(int direction)
        {
            switch (direction)
            {
                case Directions.UP:
                    this.Y -= 25;
                    break;
                case Directions.DOWN:
                    this.Y += 25;
                    break;
                case Directions.LEFT:
                    this.X -= 25;
                    break;
                case Directions.RIGHT:
                    this.X += 25;
                    break;
                default:
                    throw new InvalidOperationException("Invalid direction to move in");
            }
        }

    }
}
