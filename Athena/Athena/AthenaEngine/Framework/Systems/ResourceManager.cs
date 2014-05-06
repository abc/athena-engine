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

namespace AthenaEngine.Framework.Systems
{
    /// <summary>
    /// The ResourceManager class manages resources on behalf of the game.
    /// </summary>
    /// <typeparam name="T">The type of resource to manage</typeparam>
	public class ResourceManager<T>
	{
        private Game game;
        private Dictionary<String, T> Resources = new Dictionary<String, T>();

        /// <summary>
        /// Creates a new ResourceManager to manage resources for a game.
        /// </summary>
        /// <param name="game">The game to manage resources for.</param>
        public ResourceManager(Game game)
        {
            this.game = game;
        }
        
        /// <summary>
        /// Add a new resource to the resources list maintained by the ResourceManager.
        /// </summary>
        /// <param name="key">The key to associate the resource with</param>
        /// <param name="resource">The resource associated with the key</param>
        /// <returns></returns>
        public T Add(string key, T resource)
        {
            this.Resources.Add(key, resource);
            return resource;
        }

        /// <summary>
        /// Gets the resource stored associated with a key.
        /// </summary>
        /// <param name="key">The key to find the resource associated with.</param>
        /// <returns></returns>
        public T Get(string key)
        {
            return this.Resources[key];
        }
	}
}
