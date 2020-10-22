using System;
using System.Collections.Generic;


namespace IMDB
{


    public abstract class SAK
    {
        protected String titel;
    

        public SAK(String titel)
        {
            this.titel = titel;
        }   

       


    }

    public class CD : SAK
    {
        
        protected String artist;

        public CD(String titel, String name):base (titel)
        {
         
         artist = name;
        }

        public override String ToString()
        {
            
            return ("CD: ") + "\n" + ("artist: ") + artist + "\n" + ("Titel ") + titel;
        }
    }

     public class DVD : SAK
    {
        
        protected String director;

        public DVD(String titel, String name):base (titel)
        {
         
         director = name;
        }

        public override String ToString()
        {
            
            return ("DVD: ") + "\n" + ("Director: ") + director + "\n" + ("Titel ") + titel;
        }
    }

     public class BOK : SAK
    {
        
        protected String author;

        public BOK(String titel, String name):base (titel)
        {
         
         author = name;
        }

        public override String ToString()
        {
            
            return ("BOK: ") + "\n" + ("Author: ") + author + "\n" + ("Titel ") + titel;
        }
    }

    


    class MainClass
    {
        public static void Main (string[] args)
        {
             List<SAK> objekt = new List<SAK>();
            
            
            CD cd = new CD("titel", "name");
            objekt.Add(cd);

            DVD dvd = new DVD("titel", "name");
            objekt.Add(dvd);

            BOK bok = new BOK("titel", "name");
            objekt.Add(bok);    
            
            
           
            foreach (SAK media in objekt)
            {
                Console.WriteLine(media);
                
            }

           // Console.WriteLine(dvdn);
        }
    }


}