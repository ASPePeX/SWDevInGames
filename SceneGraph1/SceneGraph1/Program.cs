using System;
using System.Collections.Generic;

namespace SceneGraph1
{
    public class GrapicsObject
    {
        public virtual void Render()
        {
        }
    }

    public class Group : GrapicsObject
    {
        public List<GrapicsObject> Children;

        public override void Render()
        {
            Console.WriteLine("Rendering Group with " + Children.Count + " children.");

            
            foreach (var child in Children)
            {
                child.Render();
            }
        }
    }

    public class Cuboid : GrapicsObject
    {
        public double a;
        public double b;
        public double c;

        public override void Render()
        {
            Console.WriteLine("A Cube sized: " + a + "; " + b + "; " + c);
        }
    }

    public class Sphere : GrapicsObject
    {
        public double radius;

        public override void Render()
        {
            Console.WriteLine("A Sphere with radius " + radius);
        }
    }


    internal class Program
    {
        private static void Main(string[] args)
        {
            var root = new Group {Children = new List<GrapicsObject>()};
            root.Children.Add(new Sphere {radius = 1});
            root.Children.Add(new Cuboid {a = 1, b = 1, c = 1});

            var childGroup = new Group {Children = new List<GrapicsObject>()};
            childGroup.Children.Add(new Sphere {radius = 2});
            childGroup.Children.Add(new Cuboid {a = 2, b = 2, c = 2});

            root.Children.Add(childGroup);

            root.Render();
        }
    }
}
