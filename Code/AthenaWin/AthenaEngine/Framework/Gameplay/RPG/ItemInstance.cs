using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AthenaEngine.Framework.Gameplay.RPG
{
    /// <summary>
    /// An item instance is a particular instance of an item.
    /// </summary>
    public class ItemInstance : Item
    {
        private int Quantity;
        /// <summary>
        /// Constructor for the ItemInstance class.
        /// </summary>
        /// <param name="item">The actual item of which this is an instance</param>
        /// <param name="quantity">How many of that item are in this particular instance?</param>
        public ItemInstance(Item item, int quantity) : base(item.Name)
        {
            this.Quantity = quantity;
        }
    }
}
