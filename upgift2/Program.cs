using System;
using System.Collections.Generic;

namespace SHAPE3D
{
    interface Shape3D

    {

        double GetArea();



        double GetVolume();



        void ToString();

    }


    




class Database

    {

        List<Shape3D> shapes = new List<Shape3D>();



        public void Print()

        {

            foreach (Shape3D shape in shapes)

            {

                Console.WriteLine(shape.GetType().Name);

                shape.ToString();

                Console.WriteLine("Area: " + shape.GetArea());

                Console.WriteLine("Volym: " + shape.GetVolume());

            }

        }



        public void AdShape(Shape3D shape)

        {

            shapes.Add(shape);

        }

    }





    class Program

    {

        static void Main(string[] args)

        {

            Database mindatabas = new Database();

      

            mindatabas.AdShape(new Cylinder(4, 6.0));


            mindatabas.Print();

        }

    }
}

