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
    public class Sprite
    {

        public Sprite(string spriteString, Vector2 spriteSize)
        {
            this.String = spriteString;
            this.Size.Width = (int)spriteSize.X;
            this.Size.Height = (int)spriteSize.Y;
            this.Color = Color.White;
            this.Origin = new Vector2(0, 0);
            this.Scale = new Vector2(1, 1);
        }

        public Vector2 Position;

        public Rectangle Size;

        public Color Color;

        public string String;

        public float Rotation;

        public Vector2 Origin;

        public Vector2 Scale;

        public SpriteEffects SpriteEffects;

        public float Layer;

        public void FlipHorizontal ()
        {
            this.SpriteEffects = SpriteEffects.FlipHorizontally;
        }

        public void Draw (Dictionary<string, Texture2D> dictionary, SpriteBatch spriteBatch)
        {
             spriteBatch.Draw(
                // Texture to draw
                dictionary[this.String],
                // Origin of texture
                this.Position,
                // Where to draw (for spritesheet)
                this.Size,
                // Colour
                this.Color,
                // Rotation
                this.Rotation,
                // Origin
                this.Origin,
                // Scale
                this.Scale,
                // Effects
                this.SpriteEffects,
                // layer
                this.Layer
                );
        }
    }
}
