using System;
using System.Collections.Generic;

namespace Questions
{
    
     abstract class Questions12
    {
        protected String question;

        protected String answer;

    
         public void GetAnswer(Questions12 svaret)
                {
                    String SVAR = Console.ReadLine();
                    if (SVAR == svaret.answer)
                    {
                        Console.WriteLine("Rätt!");
                    }

                    else
                    {
                        Console.WriteLine("Fel!");
                    }
    
                }
        abstract public void Skrivut();    
        }


    class Program
    {

       static List<Questions12> fragor = new List<Questions12>();

        static void Main(string[] args)
        {
           
            
                
                fragor.Add(new QuestionText("Vad heter Norges1 huvudstad?", "Oslo"));
               
                fragor.Add(new QuestionChoice("Vad heter Norges2 huvudstad?","2", "Stockholm", "Lissabon", "Oslo"));

                fragor.Add(new QuestionChoice("Vad heter Norges3 huvudstad?","2", "Stockholm", "Lissabon", "Oslo"));

                fragor.Add(new QuestionChoice("Vad heter Norges4 huvudstad?","2", "Stockholm", "Lissabon", "Oslo"));

                fragor.Add(new QuestionChoice("Vad heter Norges5 huvudstad?","2", "Stockholm", "Lissabon", "Oslo"));
                
                fragor.Add(new QuestionText("Vad heter sveriges6 huvudstad?", "Stockholm"));
               
                fragor.Add(new QuestionChoice("Vad heter Sveriges7 huvudstad?","1", "Stockholm", "Lissabon", "Oslo"));
              
                shuffle();

                foreach (var fraga in fragor)
                {
                    fraga.Skrivut();
                    fraga.GetAnswer(fraga);

                }




                
                
        }

        static void shuffle()
        {
            
            Random random = new Random();
            int tal1;
            int tal2;

            for(int i = 0; i < 10; i=i+1)
            {
            tal1 = random.Next(fragor.Count);
            tal2 = random.Next(fragor.Count);
            Questions12 temp = fragor [tal1];
            fragor [tal1] = fragor [tal2];
            fragor [tal2] = temp;
            }

        }

    }



   
        

}
