using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SceneGraph2
{
    public class GrapicsObject
    {
        public virtual void Accept(Visitor v)
        {
        }
    }

    public class Visitor
    {
        public virtual void VisitGroup(Group group)
        {
        }

        public virtual void VisitCuboid(Cuboid cuboid)
        {
        }

        public virtual void VisitSphere(Sphere sphere)
        {
        }
    }

    class RenderVisitor : Visitor
    {
        public override void VisitGroup(Group group)
        {
            Console.WriteLine("Rendering Group with " + group.Children.Count + " children.");
        }

        public override void VisitCuboid(Cuboid cuboid)
        {
            Console.WriteLine("A Cube sized: " + cuboid.a + "; " + cuboid.b + "; " + cuboid.c);
        }

        public override void VisitSphere(Sphere sphere)
        {
            Console.WriteLine("A Sphere with radius " + sphere.radius);
        }
    }


    public class Group : GrapicsObject
    {
        public List<GrapicsObject> Children;

        public override void Accept(Visitor v)
        {
            v.VisitGroup(this);

            foreach (var child in Children)
            {
                child.Accept(v);
            }
        }
    }

    public class Cuboid : GrapicsObject
    {
        public double a;
        public double b;
        public double c;

        public override void Accept(Visitor v)
        {
            v.VisitCuboid(this);
        }
    }

    public class Sphere : GrapicsObject
    {
        public double radius;

        public override void Accept(Visitor v)
        {
            v.VisitSphere(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var root = new Group { Children = new List<GrapicsObject>() };
            root.Children.Add(new Sphere { radius = 1 });
            root.Children.Add(new Cuboid { a = 1, b = 1, c = 1 });

            var childGroup = new Group { Children = new List<GrapicsObject>() };
            childGroup.Children.Add(new Sphere { radius = 2 });
            childGroup.Children.Add(new Cuboid { a = 2, b = 2, c = 2 });

            root.Children.Add(childGroup);

            RenderVisitor visitor = new RenderVisitor();

            root.Accept(visitor);
        }
    }
}
