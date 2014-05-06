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

namespace AthenaEngine.Framework.Primatives
{
    /// <summary>
    /// BoundingBox2D is used for bounding boxes on 2D objects.
    /// </summary>
    public class BoundingBox2D : Entity, IEquatable<BoundingBox2D>
    {
        protected Rectangle Bounds
        {
            get
            {
                return this.Rectangle;
            }
            set
            {
                this.Rectangle = value;
            }
        }
        /// <summary>
        /// Constructor for BoundingBox2D
        /// </summary>
        /// <param name="min">x/y coordinates for the bounding box</param>
        /// <param name="max">width/height for the bounding box</param>
        public BoundingBox2D(Vector2 Position, Vector2 Size) 
        {
            base.Position = Position;
            base.Size = Size;
        }

        /// <summary>
        /// Check if the BoundingBox2D is equal to another BoundingBox2D
        /// </summary>
        /// <param name="otherBounds">The other BoundingBox2D to check against.</param>
        /// <returns></returns>
        public bool Equals (BoundingBox2D otherBounds)
        {
            if (this.Bounds.Equals(otherBounds.Bounds))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check to see if this BoundingBox2D collides with an other BoundingBox.
        /// </summary>
        /// <param name="otherBounds">The other BoundingBox2D to compare with.</param>
        /// <returns></returns>
        public bool CollidesWith(BoundingBox2D other)
        {
            
            bool Colliding = false;

            if (this.Equals(other))
            {
                Colliding = true;
            }
            if ((this.Bounds.Bottom < other.Bounds.Bottom) && (this.Bounds.Bottom > other.Bounds.Top))
            {
                Colliding = true;
            }
            if ((this.Bounds.Top > other.Bounds.Top) && (this.Bounds.Top < other.Bounds.Bottom))
            {
                Colliding = true;
            }
            if ((this.Bounds.Left > other.Bounds.Left) && (this.Bounds.Left < other.Bounds.Right))
            {
                Colliding = true;
            }
            if ((this.Bounds.Right < other.Bounds.Right) && (this.Bounds.Right > other.Bounds.Left))
            {
                Colliding = true;
            }

            return Colliding;
        }
    }
}
