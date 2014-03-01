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

namespace AthenaEngine.Components
{
    /// <summary>
    /// A Level object holds all details required to handle level drawing.
    /// </summary>
    public class Level
    {
        List<Tile> TileList;

        /// <summary>
        /// Object constructor for the Level class.
        /// </summary>
        /// <param name="levelName">The name of the level to load.</param>
        /// <param name="spriteBatch">The spritebatch to draw the level with.</param>
        /// <param name="resourceManager">The resourceManager handling the games' textures.</param>
        public Level(string levelName, SpriteBatch spriteBatch, ResourceManager<Texture2D> resourceManager)
        {
            this.TileList = LevelLoader.Load(levelName);

            foreach (Tile tile in TileList) 
            {
                tile.MakeDrawable(spriteBatch, resourceManager.Get("blank"));
            }
        }

        /// <summary>
        /// Draw the level.
        /// </summary>
        public void Draw()
        {
            foreach (Tile tile in TileList)
            {
                tile.Draw();
            }
        }
    }
}
