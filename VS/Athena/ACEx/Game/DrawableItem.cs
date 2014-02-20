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

namespace ACEx.Game
{
    public class DrawableItem
    {
        public DrawableItem (Texture2D texture, Color color, Rectangle destinationRectangle)
        {
            this.texture = texture;
            this.color = color;
            this.destinationRectangle = destinationRectangle;
        }

        public Texture2D texture;
        public Color color;
        public Rectangle destinationRectangle;
    }
}
