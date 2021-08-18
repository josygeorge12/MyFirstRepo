using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesTypes
{
    abstract class Shape
    {
        public abstract void Area();
        public void type()
        {
            Console.WriteLine("It is a 2D type object");
        }
    }
    class Circle : Shape
    {
        double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public override void Area()
        {
            Console.WriteLine("Area of Circle" + Math.PI * r * r);
        }
    }
    class Triangle : Shape
    {
        double l;
        double w;

        public Triangle(double l, double w)
        {
            this.l = l;
            this.w = w;
        }

        public override void Area()
        {
            Console.WriteLine("Area of Triangle" + (l * w));
        }
    }
    class AbstractClass
    {
        static void Main()
        {
            Shape[] shapes = new Shape[2];
            shapes[0] = new Circle(4);
            shapes[1] = new Triangle(2.4, 6.7);
        }
    }
}
