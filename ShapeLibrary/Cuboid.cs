using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Cuboid : Shape3D
    {
        private Vector3 center;
        private Vector3 size;


        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            this.center = center;
            this.size.X = width;
            this.size.Y = width;
            this.size.Z = width;
        }

        public override float Volume
        {
            get
            {
                return size.X * size.Y * size.Z;
            }
        }

        public override float Area
        {
            get
            {
                return ((size.X * size.Y) * 2) + ((size.X * size.Z) * 2) + ((size.Y * size.Z) * 2);
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
            if (IsCube())
            {
                return "cube @(" + center.X + ", " + center.Y + ", " + center.Z + "): w = " + size.Y + ", h = " + size.X + ", l = " + size.Z;
            }
            else
            {
                return "cuboid @(" + center.X + ", " + center.Y + ", " + center.Z + "): w = " + size.Y + ", h = " + size.X + ", l = " + size.Z;
            }
        }

        public bool IsCube()
        {
            if(size.X == size.Y && size.Y == size.Z)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
