using System;
using System.Numerics;
using ShapeLibrary;

using System.Collections.Generic;

namespace ShapeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            int ammountOfShapes = 20;
            List<Shape> shapes = new List<Shape>(ammountOfShapes);
            float totalTriangleCicumference = 0;
            float totalArea = 0;
            float biggestVolume = 0;
            int biggestVolumeIndex = 0;


            for (int i = 0; i < ammountOfShapes; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }

            for (int i = 0; i < ammountOfShapes; i++)
            {
                Console.WriteLine(shapes[i]);

                if (shapes[i].GetType() == typeof(Triangle))
                {
                    var triangle = shapes[i] as Triangle;
                    totalTriangleCicumference += triangle.Circumference;
                }

                totalArea += shapes[i].Area;

                if (shapes[i].GetType() == typeof(Cuboid) || shapes[i].GetType() == typeof(Sphere))
                {
                    var volume = shapes[i] as Shape3D;
                    if (volume.Volume > biggestVolume)
                    {
                        biggestVolume = volume.Volume;
                        biggestVolumeIndex = i;
                    }
                }

            }

            Console.WriteLine("\nThe total circumference of the triangles is: " + totalTriangleCicumference);
            Console.WriteLine("The average area of all the shapes is: " + totalArea / 20);
            Console.WriteLine("The 3D shape with the biggest volume is shape nr: " + (biggestVolumeIndex + 1) + " with a volume of: " + biggestVolume);


            Console.WriteLine("\nVG Uppgift: \n");
            Triangle t = new Triangle(Vector2.Zero, Vector2.One, new Vector2(2.0f, .5f));
            
            foreach (Vector2 v in t)
            {
                Console.WriteLine(v);
            }

        }
    }
}
