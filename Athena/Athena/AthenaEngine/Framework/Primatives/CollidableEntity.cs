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

using AthenaEngine.Framework.Interfaces;
using AthenaEngine.Framework.Gameplay;

namespace AthenaEngine.Framework.Primatives
{
    /// <summary>
    /// The Entity class is used to store objects that have positions.
    /// </summary>
    public abstract class CollidableEntity : Entity
    {
        protected BoundingBox2D Bounds
        {
            get
            {
                return new BoundingBox2D(Position, Size);
            }
            set
            {
                if (this.Size.X < 0 || this.Size.Y < 0)
                {
                    throw new ArithmeticException("Object size is invalid, less than 0.");
                }
                this.Position = new Vector2(value.X, value.Y);
                this.Size = new Vector2(value.Width, value.Height);
            }
        }

        public Level Level;

        /// <summary>
        /// Constructor for the CollidableEntity class.
        /// </summary>
        /// <param name="position">x/y coordinates of the entity.</param>
        /// <param name="size">width/height of the entity.</param>
        public CollidableEntity(Vector2 position, Vector2 size, Level level)
        {
            this.Position = position;
            this.Size = size;
            this.Bounds = new BoundingBox2D(position, size);
            this.Level = level;
        }

        /// <summary>
        /// Check if the CollidableEntity collides with another CollidableEntity.
        /// </summary>
        /// <param name="entity">The entity to check against</param>
        /// <returns>Returns true if it does collide, otherwise false.</returns>
        public bool CollidesWith (CollidableEntity entity)
        {
            if (this.Bounds.CollidesWith(entity.Bounds))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		/// <summary>
		/// Determines whether this instance can move the specified direction.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance can move the specified direction; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='direction'>
		/// If set to <c>true</c> direction.
		/// </param>
        public bool CanMove(int direction)
        {
            BoundingBox2D NewPosition = new BoundingBox2D(new Vector2(this.Bounds.X, this.Bounds.Y), new Vector2(this.Bounds.Width, this.Bounds.Height));
            
            switch (direction)
            {
                case Directions.UP:
                    NewPosition.Y -= 25;
                    break;
                case Directions.DOWN:
                    NewPosition.Y += 25;
                    break;
                case Directions.LEFT:
                    NewPosition.X -= 25;
                    break;
                case Directions.RIGHT:
                    NewPosition.X += 25;
                    break;
            }
            foreach (Tile t in Level.TileList)
            {
                if (t.Collides)
                {
                    if (NewPosition.CollidesWith(t.Bounds))
                    {
                        return false;
                    }
                    else
                    {
                        // There wasn't.
                    }
                }
            }

            return true;

        }
		
		/// <summary>
		/// Move the specified direction.
		/// </summary>
		/// <param name='direction'>
		/// If set to <c>true</c> direction.
		/// </param>
        public bool Move(int direction)
        {
            if (CanMove(direction))
            {
                base.Move(direction);
                foreach (Tile t in Level.TileList)
                { 
                    if ((t.X == this.X) && (t.Y == this.Y))
                    {
                        t.FireTrigger(null);
                    }
                }
                return true;
            }
            else
            {
                System.Console.WriteLine("Collision detected.");
                return false;
            }
        }
    }
}
