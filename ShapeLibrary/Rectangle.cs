using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Rectangle : Shape2D
    {
        private Vector2 center;
        private Vector2 size;


        public Rectangle(Vector2 center, Vector2 size)
        {
            this.center = center;
            this.size = size;
        }

        public Rectangle(Vector2 center, float width)
        {
            this.center = center;
            this.size.X = width;
            this.size.Y = width;
        }

        public override float Circumference
        {
            get
            {
                return (size.X * 2) + (size.Y * 2);
            }
        }

        public override float Area
        {
            get
            {
                return size.X * size.Y;
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
            if (IsSquare())
            {
                return "square @(" + center.X + ", " + center.Y + "): w = " + size.Y + ", h = " + size.X;
            }
            else
            {
                return "rectangle @(" + center.X + ", " + center.Y + "): w = " + size.Y + ", h = " + size.X;
            }
        }


        public bool IsSquare()
        {
            if (size.X == size.Y)
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
