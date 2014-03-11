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
    public class BoundingBox2D : IEquatable<BoundingBox2D>
    {
        private Rectangle Bounds;

        /// <summary>
        /// Constructor for BoundingBox2D
        /// </summary>
        /// <param name="min">x/y coordinates for the bounding box</param>
        /// <param name="max">width/height for the bounding box</param>
        public BoundingBox2D(Vector2 min, Vector2 max)
        {
            this.Bounds = new Rectangle((int)min.X, (int)min.Y, (int)max.X - (int)min.X, (int)max.Y - (int)min.Y);
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
        public bool CollidesWith(BoundingBox2D otherBounds)
        {
            if ((this.Bounds.Bottom   >= otherBounds.Bounds.Top)
                && (this.Bounds.Top   <= otherBounds.Bounds.Bottom)
                && (this.Bounds.Left  <= otherBounds.Bounds.Right)
                && (this.Bounds.Right >= otherBounds.Bounds.Left))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
