using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Sphere : Shape3D
    {
        private Vector3 center;
        private float radius;

        public Sphere(Vector3 center, float radius)
        {
            this.radius = radius;
            this.center = center;
        }

        public override float Volume
        {
            get
            {
                return (float)(4 * Math.PI * Math.Pow(radius, 3)/3);
            }
        }

        public override float Area
        {
            get
            {
                return (float)(4 * Math.PI * Math.Pow(radius, 2));
            }

        }

        public override Vector3 Center
        {
            get
            {
                return new Vector3(Center.X, Center.Y, Center.Z);
            }
        }

        public override string ToString()
        {
            return "sphere @(" + center.X + ", " + center.Y + ", " + center.Z + "): r = " + radius;
        }

    }
}
