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
    public class Tile : DrawableItem
    {
        public Tile (int x, int y, Texture2D texture) : base (texture, Color.White, new Rectangle(x * 25, y * 25, 25, 25))
        {
            
        }
    }
}
