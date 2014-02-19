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
    public class Entity
    {
        public Sprite Sprite;

        public Entity(string spriteString, Vector2 spriteSize)
        {
            this.Sprite = new Sprite(spriteString, spriteSize);
        }
    }
}
