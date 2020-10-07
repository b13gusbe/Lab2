using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections;
using System.Threading;

namespace ShapeLibrary
{
    class TriangleEnumerator : IEnumerator
    {
        private readonly Vector2[] vectors;
        private int count = -1;

        public TriangleEnumerator(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            vectors = new Vector2[3] { p1, p2, p3 };
        }

        public object Current
        {
            get
            {
                return vectors[count];
            }
        }

        public bool MoveNext()
        {
            if (count < vectors.Length -1)
            {
                count++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset(){}

    }


    public class Triangle : Shape2D, IEnumerable
    {

        private Vector2 p1;
        private Vector2 p2;
        private Vector2 p3;
        private Vector2 centroid = new Vector2();
        
        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public override float Circumference
        {
            get
            {
                float ab = ((float)Math.Sqrt(Math.Pow(Math.Abs(p1.X - p2.X), 2) + Math.Pow(Math.Abs(p1.Y - p2.Y), 2)));
                float ac = ((float)Math.Sqrt(Math.Pow(Math.Abs(p1.X - p3.X), 2) + Math.Pow(Math.Abs(p1.Y - p3.Y), 2)));
                float bc = ((float)Math.Sqrt(Math.Pow(Math.Abs(p2.X - p3.X), 2) + Math.Pow(Math.Abs(p2.Y - p3.Y), 2)));

                return ab + ac + bc;
            }
        }

        public override float Area
        {
            get
            {
                float abx = p2.X - p1.X;
                float aby = p2.Y - p1.Y;
                float acx = p3.X - p1.X;
                float acy = p3.Y - p1.Y;

                return (float)(0.5 * Math.Abs((abx * acy) - (aby * acx)));
            }
        }

        public override Vector3 Center
        {
            get
            {
                centroid = CalculateCentroid();
                return new Vector3(centroid.X, centroid.Y, 0.0f);
            }
        }

        public override string ToString()
        {
            Vector2 centroid = CalculateCentroid();
            return "triangle @(" + Math.Round(centroid.X,1) + ", " + Math.Round(centroid.Y, 1) + "): p1(" + p1.X + ", " + p1.Y + "): p2(" + p2.X + ", " + p2.Y + "): p3(" + p3.X + ", " + p3.Y + ")";
        }

        private Vector2 CalculateCentroid()
        {
            return new Vector2((p1.X + p2.X + p3.X)/3, (p1.Y + p2.Y + p3.Y)/3);
        }

        public IEnumerator GetEnumerator()
        {
        return new TriangleEnumerator(p1, p2, p3);
        }

    }
}
