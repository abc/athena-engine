using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

using AthenaEngine.Framework.Gameplay;

namespace AthenaEngine.Framework.Systems
{
    /// <summary>
    /// the LevelLoader is used to load levels.
    /// </summary>
    public static class LevelLoaderXml
    {
        public class Sprite
        {
            public int X;
            public int Y;
            public string Name;
            public bool Collides;

            public Sprite(int x, int y, string name, bool collides)
            {
                this.X = x;
                this.Y = y;
                this.Name = name;
                this.Collides = collides;
            }
        }
		
		/// <summary>
		/// Load the specified levelName and level.
		/// </summary>
		/// <param name='levelName'>
		/// Level name.
		/// </param>
		/// <param name='level'>
		/// Level.
		/// </param>
        public static List<Tile> Load (string levelName, Level level)
        {
            List<Tile> LevelList = new List<Tile>();
            XDocument Document = XDocument.Load("Content/Levels/" + levelName + "/tiles.xml");
            XElement Level = Document.Element("level");
            string Tileset = Level.Attribute("tileset").Value;
            int RowLength = Int32.Parse(Level.Attribute("rowlength").Value);

            Dictionary<string, Sprite> SpriteList = LoadSpriteSet(Tileset);

            System.Console.WriteLine(Tileset);
            int TileSize = Int32.Parse(Level.Attribute("tilesize").Value);

            IEnumerable<XElement> Tiles = Level.Elements("tile");
            int Y = 0;
            int X = 0;
            foreach (XElement Tile in Tiles)
            {
                string SpriteName = Tile.Element("sprite").Value;
                Sprite sprite = SpriteList[SpriteName];
                    

                Tile newTile = new Tile(X * TileSize, Y * TileSize, Tileset, sprite.X, sprite.Y, level);
                    
                var Te = Tile.Elements();
                foreach(var Tee in Te)
                {
                    if (Tee.Name == "trigger")
                    {
                        newTile.AddTrigger(Tee.Value);
                    }
                }
                newTile.Collides = sprite.Collides;
                    
                LevelList.Add(newTile);
                X++;
                if (X >= RowLength)
                {
                    Y++;
                    X = 0;
                }
                    
            }

            return LevelList;
        }
		
		/// <summary>
		/// Loads the sprite set.
		/// </summary>
		/// <returns>
		/// The sprite set.
		/// </returns>
		/// <param name='spriteSet'>
		/// Sprite set.
		/// </param>
        public static Dictionary<string, Sprite> LoadSpriteSet (string spriteSet)
        {
            Dictionary<string, Sprite> SpriteList = new Dictionary<string, Sprite>();
            
            XDocument TileSet = XDocument.Load("Content/Tilesets/" + spriteSet + ".xml");
            XElement TileSetDeclaration = TileSet.Element("tileset");
            int TileSize = Int32.Parse(TileSetDeclaration.Attribute("tilesize").Value);

            IEnumerable<XElement> Sprites = TileSetDeclaration.Elements("sprite");
            foreach (XElement Sprite in Sprites)
            {
                int x = Int32.Parse(Sprite.Element("x").Value) * TileSize;
                int y = Int32.Parse(Sprite.Element("y").Value) * TileSize;

                string name = Sprite.Element("name").Value;
                bool collides = Boolean.Parse(Sprite.Element("collides").Value);

                Sprite newSprite = new Sprite(x, y, name, collides);
                SpriteList.Add(name, newSprite);
            }

            return SpriteList;
        }
    }
}
