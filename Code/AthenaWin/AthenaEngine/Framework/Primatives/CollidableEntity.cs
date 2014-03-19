﻿using System;
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

namespace AthenaEngine.Framework.Primatives
{
    /// <summary>
    /// The Entity class is used to store objects that have positions.
    /// </summary>
    public abstract class CollidableEntity : Entity, ICollidable<CollidableEntity>, IMoveable
    {
        private BoundingBox2D Bounds;
        protected Vector2 Position;

        /// <summary>
        /// Constructor for the CollidableEntity class.
        /// </summary>
        /// <param name="position">x/y coordinates of the entity.</param>
        /// <param name="size">width/height of the entity.</param>
        public CollidableEntity(Vector2 position, Vector2 size)
        {
            this.Position.X = position.X;
            this.Position.Y = position.Y;
            this.Bounds = new BoundingBox2D(position, size);
        }

        /// <summary>
        /// Get the bounding box of the array
        /// </summary>
        /// <returns>Returns a boundingbox</returns>
        public BoundingBox2D GetBounds()
        {
            return this.Bounds;
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

        public bool CanMove(string direction)
        {
            return true;
        }

        public bool Move(string direction)
        {
            if (CanMove(direction))
            {
                switch (direction)
                {
                    case "up":
                        this.Bounds.Bounds.Y = this.Bounds.Bounds.Y - 25;
                        break;
                    case "down":
                        this.Bounds.Bounds.Y = this.Bounds.Bounds.Y + 25;
                        break;
                    case "left":
                        this.Bounds.Bounds.X = this.Bounds.Bounds.X - 25;
                        break;
                    case "right":
                        this.Bounds.Bounds.X = this.Bounds.Bounds.X + 25;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid direction to move in");
                }
            }

            return true;
        }
    }
}