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
	/// Inventory.
	/// </summary>
    class Inventory
    {
        private List<ItemInstance> ItemList = new List<ItemInstance>();
        private int ItemCount;
		
		/// <summary>
		/// Add the specified item and quantity.
		/// </summary>
		/// <param name='item'>
		/// Item.
		/// </param>
		/// <param name='quantity'>
		/// Quantity.
		/// </param>
        public void Add(Item item, int quantity)
        {
            this.ItemList.Add(new ItemInstance(item, quantity));
        }

    }
}
