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
    public class ContentDirector
    {
        public ContentDirector ()
        {

        }

        public ContentManager Content { get; set; }

        public T GetContent<T> (string assetString)
        {
            return LoadContent<T>(assetString);
        }

        private T LoadContent<T> (string contentString)
        {
            return Content.Load<T>(contentString);
        }
    }
}
