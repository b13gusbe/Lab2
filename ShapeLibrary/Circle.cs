using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Circle : Shape2D
    {
        private Vector2 center;
        private float radius;
        

        public Circle(Vector2 center, float radius)
        {
            this.radius = radius;
            this.center = center;

        }

        public override float Circumference
        {
            get
            {
                return (radius + radius) * (float)Math.PI;
            }
        }

        public override float Area
        {
            get
            {
                return radius * radius * (float)Math.PI;
            }

        }

        public override Vector3 Center
        {
            get
            {
                return new Vector3(Center.X, Center.Y, 0.0f);
            }
        }

        public override string ToString()
        {
            return "circle @(" + center.X + ", " + center.Y + "): r = " + radius;
        }


    }
}
