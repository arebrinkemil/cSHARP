using System;
using System.Collections.Generic;
using System.Text;
namespace CD
{
    class Sak
    {
        
        protected String titel;
        protected String art;
        protected String sound;
        

        public Sak()
        {  
            titel = "lat";
            art = "";
            sound = "";

        }   
    }

     class cd : Sak
    {
        public cd()
        {
            
            art = "";
        }
    }

    class dvd : Sak
    {
        public dvd()
        {
            
            sound = "";
        }
    }

    class Zoo
    {
        private List<Sak> animals;

        public   Zoo()
        {
            animals = new List<Sak>();

        }

      public void Add(Sak anAnimal)
        {
            animals.Add(anAnimal);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            
            Zoo zoo = new Zoo();
            zoo.Add(new cd(12));
         
            


            Console.ReadKey();
        }


    }




}
