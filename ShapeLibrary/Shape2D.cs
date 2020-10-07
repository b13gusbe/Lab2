using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ShapeLibrary
{
    public abstract class Shape2D : Shape
    {
        public abstract float Circumference { get; }
    }
}
