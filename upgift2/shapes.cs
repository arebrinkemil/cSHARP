using System;
using System.Collections.Generic;

namespace SHAPE3D
{


    class Cylinder : Shape3D

    {

        public double radien;
        public double height;



        public Cylinder(double r, double h)

        {
            height = h;
            radien = r;

        }

        public double GetArea()

        {

            return 2 * Math.PI * radien * height + 2 * Math.PI * radien * radien;

        }

         public double GetVolume()

         {

             return radien * radien * Math.PI * height;
         }




    }


    class Cube : Shape3D

    {

        public double langd;

        public Cube(double sida)
        {
            langd = sida;
        }
        public double GetArea()
        {
            return (langd * langd) * 6;
        }
        public double GetVolume()
        {
            return  Math.Pow(langd, 3);
        }




    }



    class Sphere : Shape3D

    {

        public double radien;
        

        public Sphere(double r)

        {
           
            radien = r;

        }

        public double GetArea()

        {

            return 4 * Math.PI * Math.Pow(radien, 2);

        }

         public double GetVolume()

         {

             return 4.0 / 3 * Math.PI * Math.Pow(radien, 3);
         }




    }

}