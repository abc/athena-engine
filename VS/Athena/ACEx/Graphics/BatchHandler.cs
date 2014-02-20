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
using ACEx.Game;

namespace ACEx.Graphics
{
    public class BatchHandler
    {
        SpriteBatch spriteBatch;
        public BatchHandler (SpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
        }

        public void Draw<T> (DrawableItem t)
        {
            spriteBatch.Draw(t.texture, t.destinationRectangle, t.color);
        }
    }
}
