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
    class CollidableEntity : Entity
    {
        private BoundingBox2D Bounds;
        

        public CollidableEntity (string spriteString, Vector2 spriteSize) : base (spriteString, spriteSize)
        {
            throw new NotImplementedException();
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
            get { return Bounds.Width; }
            set { Bounds.Width = value; }
        }
        
    }
}
