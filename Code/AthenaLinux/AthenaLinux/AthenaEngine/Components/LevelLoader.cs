using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AthenaEngine.Components
{
    /// <summary>
    /// the LevelLoader is used to load levels.
    /// </summary>
    public static class LevelLoader
    {
        /// <summary>
        /// Load a level from a text file and return it as a list of tiles.
        /// </summary>
        /// <param name="levelName">The name of the level</param>
        /// <returns>Return a list of tiles.</returns>
        public static List<Tile> Load (string levelName)
        {
            List<Tile> LevelList = new List<Tile>();

            StreamReader reader = new StreamReader("Content/" + levelName + ".apt");

            int i = 0;
            do
            {
                string line = reader.ReadLine();

				if (line[0] == '#')
				{
					// It's a comment.
				}
				else
				{
					for (int j = 0; j < line.Length; j++)
	                {
	                    if (line[j] != ' ')
						{
							LevelList.Add(new Tile(j, i)); 
						}
					}
	                i++;
				}
            }
            while (reader.Peek() != -1);

            return LevelList;
        }
    }
}
