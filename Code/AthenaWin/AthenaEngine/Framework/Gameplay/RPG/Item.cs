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

namespace AthenaEngine.Framework.Gameplay.RPG
{
    /// <summary>
    /// A gameplay item can be held by a character.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The name of the item
        /// </summary>
        public string Name {
            get { return this.Name; }
            private set { this.Name = value; }
        }

        /// <summary>
        /// Constructor for the item class
        /// </summary>
        /// <param name="name">Name of the item</param>
        public Item(string name)
        {
            this.Name = name;
        }
    }
}
