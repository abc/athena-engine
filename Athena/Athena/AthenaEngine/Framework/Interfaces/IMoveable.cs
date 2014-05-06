using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AthenaEngine.Framework.Interfaces
{
    interface IMoveable
    {
        bool Move(string direction);
        bool CanMove(string direction);

    }
}
