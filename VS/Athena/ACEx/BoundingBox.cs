#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace ACEx
{
    public class BoundingBox2D : IIsCollidable <BoundingBox2D>
    {
        private Rectangle Bounds;

        public BoundingBox2D(int x, int y, int width, int height)
        {
            Bounds.X = x;
            Bounds.Y = y;
            Bounds.Width = width;
            Bounds.Height = height;
        }

        public int X
        {
            get { return Bounds.X; }
            set { Bounds.X = value; }
        }
        public int Y
        {
            get { return Bounds.Y; }
            set { Bounds.Y = value; }
        }
        public int Width
        {
            get { return Bounds.Width; }
            set { Bounds.Width = value; }
        }
        public int Height
        {
            get { return Bounds.Height; }
            set { Bounds.Height = value; }
        }

        public bool CollidesWith(BoundingBox2D comparison)
        {
            return true;
        }

    }
}
