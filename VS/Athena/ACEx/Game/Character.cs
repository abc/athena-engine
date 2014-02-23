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
    public class Character : DrawableItem
    {
        public Character (int x, int y, Texture2D texture) : base (texture, Color.Red, new Rectangle(x * 25, y * 25, 25, 25))
        {
        }

        public void MoveLeft ()
        {
            this.destinationRectangle = new Rectangle(destinationRectangle.X - 25, destinationRectangle.Y, destinationRectangle.Width, destinationRectangle.Height);
        }
        public void MoveRight ()
        {
            this.destinationRectangle = new Rectangle(destinationRectangle.X + 25, destinationRectangle.Y, destinationRectangle.Width, destinationRectangle.Height);
        }
        public void MoveUp ()
        {
            this.destinationRectangle = new Rectangle(destinationRectangle.X, destinationRectangle.Y - 25, destinationRectangle.Width, destinationRectangle.Height);
        }
        public void MoveDown ()
        {
            this.destinationRectangle = new Rectangle(destinationRectangle.X, destinationRectangle.Y + 25, destinationRectangle.Width, destinationRectangle.Height);
        }
    }
}
