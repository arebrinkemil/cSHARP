using System;
using System.Collections.Generic;


namespace IMDB
{


    public class SAK
    {
        private String titel;



        public SAK(String titel)
        {
           
            this.titel = titel;
        }   

        public override String ToString()
        {
            return titel;
        }


    }

     public class CD : SAK
    {
        String creator;

        public CD(String titel)     
        {

            this.titel = titel;
        }
    
    }


    public class DVD : SAK
    {
        String skapare;

        public DVD(String titel)
            
        {

            this.titel = titel;
        }
    }



    class MainClass
    {
        public static void Main(string[] args)
        {



            String titel = Console.ReadLine();

            SAK v = new SAK (titel);

            Console.WriteLine(v);



            //var Medialista = new List<Media>();

           //Console.WriteLine("Titel?");
            //string Titeln = Console.ReadLine();  
           // Console.WriteLine("author?");
            //string Forfattare = Console.ReadLine();

            //CD cd = new CD(titel);
            //Console.WriteLine(cd);
            //Medialista.Add(cd);



           
        }
    }


}
  

    


         


       
        


    
   
    

