using System;
using System.Collections.Generic;


namespace upgift2
{
  

    class Database
    {

    }

    interface Shape3D
    {
        public double GetArea();
        //public double GetVolume();
        //
        void animalSound();
        
    }

    class Sphere : Shape3D
    {
       /*public double GetArea()
        {
            return -1;
        }
       public double GetVolume()
        {
            return -1;
        }*/

         public double GetArea() 
    {
      // The body of animalSound() is provided here
      Console.WriteLine("The pig says: wee wee");
    }
    }

   



      class Program
    {
        static void Main(string[] args)
        {
            
             Sphere object = new Sphere();  // Create a Pig object
            object.GetArea();
    
        }
    }


}
