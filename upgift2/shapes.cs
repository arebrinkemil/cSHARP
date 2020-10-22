using System;
using System.Collections.Generic;

namespace SHAPE3D
{


    class Cylinder : Shape3D

    {

        public double radius;



        public double height;



        public Cylinder(double r, double h)

        {

            radius = r;

            height = h;

        }

        public double GetArea()

        {

            return 2 * Math.PI * radius * height + 2 * Math.PI * radius * radius;

        }



        public double GetVolume()

        {

            return Math.PI * (radius * radius) * height;

        }



        public void ToString()

        {

            Console.WriteLine("Radien: " + radius);

            Console.WriteLine("Höjd: " + height);

        }



    }

}