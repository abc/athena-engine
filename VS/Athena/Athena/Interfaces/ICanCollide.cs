using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Athena.Classes
{
    interface ICanCollide <T>
    {
        bool CollidesWith (T compareWith);

        BoundingBox Bounds
        {
            get;
            set;
        }
    }
}
