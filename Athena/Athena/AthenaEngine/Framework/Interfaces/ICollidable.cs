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

using AthenaEngine.Framework.Primatives;

namespace AthenaEngine.Framework.Interfaces
{
    interface ICollidable<T>
    {
        bool CollidesWith(T type);
    }
}
