using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public abstract class Shape3D : Shape
    {
        public abstract float Volume { get; }
    }
}
