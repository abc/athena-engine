#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion


namespace ACEx
{
    class WorldItem : Entity
    {
        public WorldItem(string spriteString, Vector2 spriteSize)
            : base(spriteString, spriteSize)
        {

        }
    }
}
