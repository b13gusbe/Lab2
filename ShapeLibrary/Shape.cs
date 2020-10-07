using System;
using System.Numerics;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        
        public static Shape GenerateShape()
        {
            Random rnd = new Random();
            int shape = rnd.Next(7);

            if (shape == 0)
            {
                Vector2 circleCenter = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                float circleRadius = (float)Math.Round(rnd.NextDouble() * 10, 1);
                return new Circle(circleCenter, circleRadius);
            }
            else if (shape == 1)
            {
                Vector2 rectangleCenter = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                Vector2 rectangleSize = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                return new Rectangle(rectangleCenter, rectangleSize);
            }
            else if (shape == 2)
            {
                Vector2 squareCenter = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                float squareWidth = (float)Math.Round(rnd.NextDouble() * 10, 1);
                return new Rectangle(squareCenter, squareWidth);
            }
            else if (shape == 3)
            {
                Vector2 p1 = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                Vector2 p2 = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                Vector2 p3 = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                return new Triangle(p1, p2, p3);
            }
            else if (shape == 4)
            {
                Vector3 cuboidCenter = new Vector3((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                Vector3 cuboidSize = new Vector3((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                return new Cuboid(cuboidCenter, cuboidSize);
            }
            else if (shape == 5)
            {
                Vector3 cubeCenter = new Vector3((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                float cubeWidth = (float)Math.Round(rnd.NextDouble() * 10, 1);
                return new Cuboid(cubeCenter, cubeWidth);
            }
            else
            {
                Vector3 sphereCenter = new Vector3((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                float sphereRadius = (float)Math.Round(rnd.NextDouble() * 10, 1);
                return new Sphere(sphereCenter, sphereRadius);
            }
        }

        public static Shape GenerateShape(Vector3 center)
        {
            Random rnd = new Random();
            int shape = rnd.Next(7);

            if (shape == 0)
            {
                Console.WriteLine("Circle");
                Vector2 circleCenter = new Vector2(center.X, center.Y);
                float circleRadius = (float)Math.Round(rnd.NextDouble() * 10, 1);
                return new Circle(circleCenter, circleRadius);
            }
            else if (shape == 1)
            {
                Console.WriteLine("Rectangle");
                Vector2 rectangleCenter = new Vector2(center.X, center.Y);
                Vector2 rectangleSize = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                return new Rectangle(rectangleCenter, rectangleSize);
            }
            else if (shape == 2)
            {
                Console.WriteLine("Square");
                Vector2 squareCenter = new Vector2(center.X, center.Y);
                float squareWidth = (float)Math.Round(rnd.NextDouble() * 10, 1);
                return new Rectangle(squareCenter, squareWidth);
            }
            else if (shape == 3)
            {
                Console.WriteLine("Triangle");
                Vector2 p1 = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                Vector2 p2 = new Vector2((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                Vector2 p3 = new Vector2((3*center.X) - p1.X - p2.X, (3 * center.Y) - p1.Y - p2.Y);

                return new Triangle(p1, p2, p3);
            }
            else if (shape == 4)
            {
                Console.WriteLine("Cuboid");
                Vector3 cuboidSize = new Vector3((float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1), (float)Math.Round(rnd.NextDouble() * 10, 1));
                return new Cuboid(center, cuboidSize);
            }
            else if (shape == 5)
            {
                Console.WriteLine("Cube");
                float cubeWidth = (float)Math.Round(rnd.NextDouble() * 10, 1);
                return new Cuboid(center, cubeWidth);
            }
            else
            {
                Console.WriteLine("Sphere");
                float sphereRadius = (float)Math.Round(rnd.NextDouble() * 10, 1);
                return new Sphere(center, sphereRadius);
            }

        }

    }
}
