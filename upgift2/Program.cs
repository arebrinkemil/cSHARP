using System;
using System.Collections.Generic;

namespace SHAPE3D
{
    interface Shape3D

    {

        double GetArea();

       double GetVolume();

        
    }


    




class Database

    {

   List<Shape3D> shapes = new List<Shape3D>();
       



         public void AdShape(Shape3D shape)

        {

            shapes.Add(shape);

        }


        public void Print()
        {
            foreach (Shape3D shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name);
                Console.WriteLine("AREAN " + shape.GetArea());
                Console.WriteLine("VOLYMEN " + shape.GetVolume() + "\n");
            }
        }

      

    }





    class Program

    {

        static void Main(string[] args)

        {

            Database former = new Database();

      

            former.AdShape(new Cylinder(4, 6.0));
            former.AdShape(new Cylinder(2.4, 6.6));
            former.AdShape(new Cylinder(4.5, 3.0));

            former.AdShape(new Cube(4.0));
            former.AdShape(new Cube(5.0));
            former.AdShape(new Cube(10.0));

            former.AdShape(new Sphere(2.4));
            former.AdShape(new Sphere(4.5));



            former.Print();

        }

    }
}

