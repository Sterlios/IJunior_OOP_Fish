using System;
using System.Collections.Generic;
using System.Text;

namespace Aquarium
{
    struct CursorPosition
    {
        public int X { get; }
        public int Y { get; }

        public CursorPosition(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
    }
}
